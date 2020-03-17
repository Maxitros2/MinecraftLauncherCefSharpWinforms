namespace FreeLauncher.Forms
{
    partial class MadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MadForm));
            this.NickList = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabs1 = new maintabpanel.tabs();
            this.serverPanel1 = new ServerPage.ServerPanel();
            this.cheatPage1 = new FreeLauncher.CheatPage();
            this.settingsMenu1 = new FreeLauncher.SettingsMenu();
            this.AccList = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl11 = new DownPane_l.UserControl1();
            this.NickList.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.AccList.SuspendLayout();
            this.SuspendLayout();
            // 
            // NickList
            // 
            this.NickList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NickList.AutoSize = true;
            this.NickList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.NickList.Controls.Add(this.flowLayoutPanel1);
            this.NickList.Location = new System.Drawing.Point(22, 439);
            this.NickList.Margin = new System.Windows.Forms.Padding(0);
            this.NickList.Name = "NickList";
            this.NickList.Size = new System.Drawing.Size(210, 54);
            this.NickList.TabIndex = 21;
            this.NickList.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Location = new System.Drawing.Point(0, 3);
            this.panel11.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(210, 51);
            this.panel11.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добавить аккаунт";
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::FreeLauncher.Properties.Resources.plus;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel12.Location = new System.Drawing.Point(22, 22);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(14, 14);
            this.panel12.TabIndex = 3;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // tabs1
            // 
            this.tabs1.BackColor = System.Drawing.Color.Transparent;
            this.tabs1.Location = new System.Drawing.Point(0, 447);
            this.tabs1.Name = "tabs1";
            this.tabs1.Size = new System.Drawing.Size(800, 31);
            this.tabs1.TabIndex = 14;
            this.tabs1.Load += new System.EventHandler(this.tabs1_Load);
            // 
            // serverPanel1
            // 
            this.serverPanel1.BackColor = System.Drawing.Color.Transparent;
            this.serverPanel1.Location = new System.Drawing.Point(22, 73);
            this.serverPanel1.Name = "serverPanel1";
            this.serverPanel1.Size = new System.Drawing.Size(753, 368);
            this.serverPanel1.TabIndex = 22;
            this.serverPanel1.Click += new System.EventHandler(this.serverPanel1_Click);
            // 
            // cheatPage1
            // 
            this.cheatPage1.BackColor = System.Drawing.Color.Transparent;
            this.cheatPage1.Location = new System.Drawing.Point(0, 0);
            this.cheatPage1.Name = "cheatPage1";
            this.cheatPage1.Size = new System.Drawing.Size(800, 441);
            this.cheatPage1.TabIndex = 23;
            // 
            // settingsMenu1
            // 
            this.settingsMenu1.BackColor = System.Drawing.Color.Transparent;
            this.settingsMenu1.Location = new System.Drawing.Point(0, 2);
            this.settingsMenu1.Name = "settingsMenu1";
            this.settingsMenu1.Size = new System.Drawing.Size(800, 545);
            this.settingsMenu1.TabIndex = 24;
            this.settingsMenu1.Visible = false;
            // 
            // AccList
            // 
            this.AccList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AccList.AutoSize = true;
            this.AccList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.AccList.Controls.Add(this.flowLayoutPanel2);
            this.AccList.Location = new System.Drawing.Point(253, 483);
            this.AccList.Margin = new System.Windows.Forms.Padding(0);
            this.AccList.Name = "AccList";
            this.AccList.Size = new System.Drawing.Size(210, 10);
            this.AccList.TabIndex = 25;
            this.AccList.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(210, 10);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.Location = new System.Drawing.Point(-1, 478);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(801, 69);
            this.userControl11.TabIndex = 14;
            // 
            // MadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FreeLauncher.Properties.Resources.main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.NickList);
            this.Controls.Add(this.AccList);
            this.Controls.Add(this.settingsMenu1);
            this.Controls.Add(this.cheatPage1);
            this.Controls.Add(this.serverPanel1);
            this.Controls.Add(this.tabs1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MadForm";
            this.Text = "MadForm";
            this.TransparencyKey = System.Drawing.Color.SeaGreen;
            this.Load += new System.EventHandler(this.MadForm_Load);
            this.Shown += new System.EventHandler(this.MadForm_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MadForm_DragDrop);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MadForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MadForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MadForm_MouseUp);
            this.NickList.ResumeLayout(false);
            this.NickList.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.AccList.ResumeLayout(false);
            this.AccList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel NickList;
        private DownPane_l.UserControl1 userControl11;
        private maintabpanel.tabs tabs1;
        private ServerPage.ServerPanel serverPanel1;
        private CheatPage cheatPage1;
        private SettingsMenu settingsMenu1;
        private System.Windows.Forms.Panel AccList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}