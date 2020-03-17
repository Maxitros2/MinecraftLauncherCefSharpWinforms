namespace FreeLauncher
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setPage31 = new FreeLauncher.SetPage3();
            this.servPage21 = new FreeLauncher.ServPage2();
            this.servPage11 = new FreeLauncher.ServPage1();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("PF BeauSans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Клиенты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("PF BeauSans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Аккаунты";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FreeLauncher.Properties.Resources.closeSet;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(762, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // setPage31
            // 
            this.setPage31.BackColor = System.Drawing.Color.Transparent;
            this.setPage31.BackgroundImage = global::FreeLauncher.Properties.Resources.selectsettings3_2;
            this.setPage31.Location = new System.Drawing.Point(192, 0);
            this.setPage31.Name = "setPage31";
            this.setPage31.Size = new System.Drawing.Size(608, 545);
            this.setPage31.TabIndex = 5;
            // 
            // servPage21
            // 
            this.servPage21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servPage21.BackgroundImage")));
            this.servPage21.Location = new System.Drawing.Point(192, 0);
            this.servPage21.Name = "servPage21";
            this.servPage21.Size = new System.Drawing.Size(608, 545);
            this.servPage21.TabIndex = 4;
            this.servPage21.Visible = false;
            // 
            // servPage11
            // 
            this.servPage11.BackColor = System.Drawing.Color.Transparent;
            this.servPage11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servPage11.BackgroundImage")));
            this.servPage11.Location = new System.Drawing.Point(192, 0);
            this.servPage11.Name = "servPage11";
            this.servPage11.Size = new System.Drawing.Size(608, 545);
            this.servPage11.TabIndex = 3;
            this.servPage11.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PF BeauSans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::FreeLauncher.Properties.Resources.selectsettings2;
            this.label1.Location = new System.Drawing.Point(0, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Основное";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setPage31);
            this.Controls.Add(this.servPage21);
            this.Controls.Add(this.servPage11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(800, 545);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsMenu_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ServPage1 servPage11;
        private ServPage2 servPage21;
        public SetPage3 setPage31;
        private System.Windows.Forms.Panel panel1;
    }
}
