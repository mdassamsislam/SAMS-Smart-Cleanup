using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SamsSmartCleanup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInstalledPrograms();
        }

        private void btnCleanTemp_Click(object sender, EventArgs e)
        {
            string[] paths = {
                Path.GetTempPath(),
                @"C:\Windows\Temp",
                @"C:\Windows\Prefetch"
            };

            foreach (var dir in paths)
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    foreach (FileInfo file in di.GetFiles()) { try { file.Delete(); } catch { } }
                    foreach (DirectoryInfo subDir in di.GetDirectories()) { try { subDir.Delete(true); } catch { } }
                }
                catch { }
            }

            label1.Text = $"Temporary files cleaned!";
        }

        private void btnCleanLeftovers_Click(object sender, EventArgs e)
        {
            string[] leftovers = {
                @"C:\Program Files\UnusedApp",
                @"C:\Program Files (x86)\UnusedApp",
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UnknownApp")
            };

            foreach (string folder in leftovers)
            {
                try
                {
                    if (Directory.Exists(folder))
                        Directory.Delete(folder, true);
                }
                catch { }
            }

            label1.Text = $"Leftover files cleaned!";

        }

        private void LoadInstalledPrograms()
        {
            listPrograms.Items.Clear();
            string regPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath))
            {
                foreach (string subKeyName in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subKeyName))
                    {
                        string name = subkey?.GetValue("DisplayName") as string;
                        string uninstall = subkey?.GetValue("UninstallString") as string;

                        if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(uninstall))
                        {
                            ListViewItem item = new ListViewItem(name);
                            item.Tag = uninstall;
                            listPrograms.Items.Add(item);
                        }
                    }
                }
            }

            listPrograms.Sorting = SortOrder.Ascending;
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (listPrograms.SelectedItems.Count > 0)
            {
                string uninstallCmd = listPrograms.SelectedItems[0].Tag.ToString();
                try
                {
                    Process.Start("cmd.exe", "/C " + uninstallCmd);
                }
                catch (Exception)
                {
                    MessageBox.Show("Uninstall failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
