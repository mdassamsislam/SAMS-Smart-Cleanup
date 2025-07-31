namespace SamsSmartCleanup
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2GradientButton btnCleanTemp;
        private Guna.UI2.WinForms.Guna2GradientButton btnCleanLeftovers;
        private Guna.UI2.WinForms.Guna2GradientButton btnUninstall;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.ListView listPrograms;
        private Guna.UI2.WinForms.Guna2Panel topPanel;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify the
        /// contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCleanTemp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCleanLeftovers = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUninstall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.listPrograms = new System.Windows.Forms.ListView();
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCleanTemp
            // 
            this.btnCleanTemp.Animated = true;
            this.btnCleanTemp.BorderRadius = 10;
            this.btnCleanTemp.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCleanTemp.FillColor2 = System.Drawing.Color.DeepPink;
            this.btnCleanTemp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCleanTemp.ForeColor = System.Drawing.Color.White;
            this.btnCleanTemp.Location = new System.Drawing.Point(20, 80);
            this.btnCleanTemp.Name = "btnCleanTemp";
            this.btnCleanTemp.Size = new System.Drawing.Size(200, 40);
            this.btnCleanTemp.TabIndex = 1;
            this.btnCleanTemp.Text = "Clean Temp Files";
            this.btnCleanTemp.Click += new System.EventHandler(this.btnCleanTemp_Click);
            // 
            // btnCleanLeftovers
            // 
            this.btnCleanLeftovers.Animated = true;
            this.btnCleanLeftovers.BorderRadius = 10;
            this.btnCleanLeftovers.FillColor = System.Drawing.Color.Teal;
            this.btnCleanLeftovers.FillColor2 = System.Drawing.Color.Indigo;
            this.btnCleanLeftovers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCleanLeftovers.ForeColor = System.Drawing.Color.White;
            this.btnCleanLeftovers.Location = new System.Drawing.Point(240, 80);
            this.btnCleanLeftovers.Name = "btnCleanLeftovers";
            this.btnCleanLeftovers.Size = new System.Drawing.Size(200, 40);
            this.btnCleanLeftovers.TabIndex = 2;
            this.btnCleanLeftovers.Text = "Clean Leftovers";
            this.btnCleanLeftovers.Click += new System.EventHandler(this.btnCleanLeftovers_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Animated = true;
            this.btnUninstall.BorderRadius = 10;
            this.btnUninstall.FillColor = System.Drawing.Color.OrangeRed;
            this.btnUninstall.FillColor2 = System.Drawing.Color.DarkRed;
            this.btnUninstall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUninstall.ForeColor = System.Drawing.Color.White;
            this.btnUninstall.Location = new System.Drawing.Point(500, 428);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(200, 40);
            this.btnUninstall.TabIndex = 4;
            this.btnUninstall.Text = "Uninstall Selected";
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(230, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SAMS SMART CLEANUP";
            // 
            // borderlessForm
            // 
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.ResizeForm = false;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // listPrograms
            // 
            this.listPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPrograms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listPrograms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listPrograms.FullRowSelect = true;
            this.listPrograms.HideSelection = false;
            this.listPrograms.Location = new System.Drawing.Point(20, 140);
            this.listPrograms.Name = "listPrograms";
            this.listPrograms.Size = new System.Drawing.Size(680, 260);
            this.listPrograms.TabIndex = 3;
            this.listPrograms.UseCompatibleStateImageBehavior = false;
            this.listPrograms.View = System.Windows.Forms.View.List;
            this.listPrograms.SelectedIndexChanged += new System.EventHandler(this.listPrograms_SelectedIndexChanged);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.topPanel.Controls.Add(this.guna2ControlBox2);
            this.topPanel.Controls.Add(this.guna2ControlBox1);
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(720, 60);
            this.topPanel.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.topPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Visitor TT2 BRK", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "N/A";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(675, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(624, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btnCleanTemp);
            this.Controls.Add(this.btnCleanLeftovers);
            this.Controls.Add(this.listPrograms);
            this.Controls.Add(this.btnUninstall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAMS SMART CLEANUP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}
