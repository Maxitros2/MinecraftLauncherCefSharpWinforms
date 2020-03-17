namespace DownPane_l
{
    partial class UserControl1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.BuildPanel = new System.Windows.Forms.Panel();
            this.SelectedVersion = new System.Windows.Forms.Label();
            this.NicknamePanel = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BuildPanel2 = new System.Windows.Forms.Panel();
            this.NicknamePanel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.TextBox();
            this.BuildPanel.SuspendLayout();
            this.NicknamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildPanel
            // 
            this.BuildPanel.BackColor = System.Drawing.Color.Transparent;
            this.BuildPanel.Controls.Add(this.SelectedVersion);
            this.BuildPanel.Controls.Add(this.BuildPanel2);
            this.BuildPanel.Location = new System.Drawing.Point(253, 13);
            this.BuildPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BuildPanel.Name = "BuildPanel";
            this.BuildPanel.Size = new System.Drawing.Size(210, 40);
            this.BuildPanel.TabIndex = 21;
            // 
            // SelectedVersion
            // 
            this.SelectedVersion.AutoSize = true;
            this.SelectedVersion.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedVersion.ForeColor = System.Drawing.Color.White;
            this.SelectedVersion.Location = new System.Drawing.Point(3, 11);
            this.SelectedVersion.Name = "SelectedVersion";
            this.SelectedVersion.Size = new System.Drawing.Size(141, 19);
            this.SelectedVersion.TabIndex = 1;
            this.SelectedVersion.Text = "MadLauncher1234";
            // 
            // NicknamePanel
            // 
            this.NicknamePanel.BackColor = System.Drawing.Color.Transparent;
            this.NicknamePanel.Controls.Add(this.label1);
            this.NicknamePanel.Controls.Add(this.NicknamePanel2);
            this.NicknamePanel.Location = new System.Drawing.Point(23, 13);
            this.NicknamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.NicknamePanel.Name = "NicknamePanel";
            this.NicknamePanel.Size = new System.Drawing.Size(210, 40);
            this.NicknamePanel.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = global::DownPane_l.Properties.Resources.folder;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(733, 18);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(41, 30);
            this.panel10.TabIndex = 24;
            this.panel10.MouseLeave += new System.EventHandler(this.panel9_MouseLeave);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseMove);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::DownPane_l.Properties.Resources.settings;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(690, 18);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(40, 30);
            this.panel9.TabIndex = 23;
            this.panel9.MouseLeave += new System.EventHandler(this.panel9_MouseLeave);
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseMove);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel8.Location = new System.Drawing.Point(484, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 60);
            this.panel8.TabIndex = 22;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // BuildPanel2
            // 
            this.BuildPanel2.BackgroundImage = global::DownPane_l.Properties.Resources.strelochka;
            this.BuildPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildPanel2.Location = new System.Drawing.Point(170, 0);
            this.BuildPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.BuildPanel2.Name = "BuildPanel2";
            this.BuildPanel2.Size = new System.Drawing.Size(40, 40);
            this.BuildPanel2.TabIndex = 0;
            // 
            // NicknamePanel2
            // 
            this.NicknamePanel2.BackgroundImage = global::DownPane_l.Properties.Resources.strelochka;
            this.NicknamePanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NicknamePanel2.Location = new System.Drawing.Point(170, 0);
            this.NicknamePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.NicknamePanel2.Name = "NicknamePanel2";
            this.NicknamePanel2.Size = new System.Drawing.Size(40, 40);
            this.NicknamePanel2.TabIndex = 0;
            this.NicknamePanel2.Click += new System.EventHandler(this.NicknamePanel2_Click);
            this.NicknamePanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.NicknamePanel2_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label1.Font = new System.Drawing.Font("PF BeauSans Pro", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 8;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.BuildPanel);
            this.Controls.Add(this.NicknamePanel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 69);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.BuildPanel.ResumeLayout(false);
            this.BuildPanel.PerformLayout();
            this.NicknamePanel.ResumeLayout(false);
            this.NicknamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel NicknamePanel2;
        public System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Panel BuildPanel2;
        public System.Windows.Forms.Panel NicknamePanel;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel BuildPanel;
        public System.Windows.Forms.Label SelectedVersion;
        public System.Windows.Forms.TextBox label1;
    }
}
