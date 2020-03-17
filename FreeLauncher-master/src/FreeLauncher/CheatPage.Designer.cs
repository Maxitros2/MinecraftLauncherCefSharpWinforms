using System.Drawing;

namespace FreeLauncher
{
    partial class CheatPage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BigName = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NickList = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.NickList.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MainPanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 94);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(708, 310);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Description);
            this.MainPanel.Controls.Add(this.BigName);
            this.MainPanel.Controls.Add(this.Download);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(708, 100);
            this.MainPanel.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Font = new System.Drawing.Font("PF BeauSans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(100, 0);
            this.Description.Name = "Description";
            this.Description.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Description.Size = new System.Drawing.Size(563, 100);
            this.Description.TabIndex = 1;
            this.Description.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(754, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(46, 100);
            this.panel5.TabIndex = 1;
            // 
            // BigName
            // 
            this.BigName.Dock = System.Windows.Forms.DockStyle.Left;
            this.BigName.Font = new System.Drawing.Font("PF BeauSans Pro", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigName.Image = global::FreeLauncher.Properties.Resources.ramka;
            this.BigName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BigName.Location = new System.Drawing.Point(0, 0);
            this.BigName.Margin = new System.Windows.Forms.Padding(0);
            this.BigName.Name = "BigName";
            this.BigName.Size = new System.Drawing.Size(100, 100);
            this.BigName.TabIndex = 3;
            this.BigName.Text = "N";
            this.BigName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BigName.UseCompatibleTextRendering = true;
            // 
            // Download
            // 
            this.Download.BackgroundImage = global::FreeLauncher.Properties.Resources.DownloadCheat;
            this.Download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Download.Dock = System.Windows.Forms.DockStyle.Right;
            this.Download.Location = new System.Drawing.Point(663, 0);
            this.Download.Margin = new System.Windows.Forms.Padding(0);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(45, 100);
            this.Download.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FreeLauncher.Properties.Resources.CheatStrelka;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 100);
            this.panel1.TabIndex = 0;
            // 
            // NickList
            // 
            this.NickList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NickList.AutoSize = true;
            this.NickList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.NickList.Controls.Add(this.flowLayoutPanel2);
            this.NickList.Location = new System.Drawing.Point(295, 66);
            this.NickList.Margin = new System.Windows.Forms.Padding(0);
            this.NickList.Name = "NickList";
            this.NickList.Size = new System.Drawing.Size(210, 163);
            this.NickList.TabIndex = 22;
            this.NickList.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.flowLayoutPanel2.Controls.Add(this.panel11);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(210, 163);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Visible = false;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.panel11.Controls.Add(this.label3);
            this.panel11.Location = new System.Drawing.Point(0, 112);
            this.panel11.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(210, 51);
            this.panel11.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Закрыть";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NickList);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "CheatPage";
            this.Size = new System.Drawing.Size(800, 404);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CheatPage_Paint);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.NickList.ResumeLayout(false);
            this.NickList.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel Download;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label BigName;
        private System.Windows.Forms.Panel NickList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
    }
}
