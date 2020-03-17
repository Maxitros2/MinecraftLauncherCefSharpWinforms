namespace maintabpanel
{
    partial class tabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabs));
            this.tab3 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.Label();
            this.tab1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tab3
            // 
            this.tab3.BackColor = System.Drawing.Color.Transparent;
            this.tab3.Font = new System.Drawing.Font("PF BeauSans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            this.tab3.Location = new System.Drawing.Point(382, 0);
            this.tab3.Margin = new System.Windows.Forms.Padding(0);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(180, 30);
            this.tab3.TabIndex = 18;
            this.tab3.Text = "Установщик сборок";
            this.tab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tab3.Click += new System.EventHandler(this.label1_Click);
            this.tab3.MouseLeave += new System.EventHandler(this.tab1_MouseLeave);
            this.tab3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tab1_MouseMove);
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.Transparent;
            this.tab2.Font = new System.Drawing.Font("PF BeauSans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            this.tab2.Location = new System.Drawing.Point(202, 0);
            this.tab2.Margin = new System.Windows.Forms.Padding(0);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(180, 30);
            this.tab2.TabIndex = 17;
            this.tab2.Text = "Читы";
            this.tab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tab2.Click += new System.EventHandler(this.label1_Click);
            this.tab2.MouseLeave += new System.EventHandler(this.tab1_MouseLeave);
            this.tab2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tab1_MouseMove);
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.Color.Transparent;
            this.tab1.Font = new System.Drawing.Font("PF BeauSans Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab1.ForeColor = System.Drawing.Color.White;
            this.tab1.Image = ((System.Drawing.Image)(resources.GetObject("tab1.Image")));
            this.tab1.Location = new System.Drawing.Point(22, 0);
            this.tab1.Margin = new System.Windows.Forms.Padding(0);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(180, 30);
            this.tab1.TabIndex = 16;
            this.tab1.Text = "Сервера";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tab1.Click += new System.EventHandler(this.label1_Click);
            this.tab1.MouseLeave += new System.EventHandler(this.tab1_MouseLeave);
            this.tab1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tab1_MouseMove);
            // 
            // tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab3);
            this.Controls.Add(this.tab2);
            this.Controls.Add(this.tab1);
            this.Name = "tabs";
            this.Size = new System.Drawing.Size(800, 31);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.tabs_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label tab3;
        public System.Windows.Forms.Label tab2;
        public System.Windows.Forms.Label tab1;
    }
}
