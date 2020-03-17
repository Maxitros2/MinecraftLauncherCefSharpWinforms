using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeLauncher
{
    public partial class AccMenu : UserControl
    {
        public AccMenu()
        {
            InitializeComponent();
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
        }
        
        public void addAcc(string acc)
        {
            
                Panel panel = new Panel();

                Label label = new Label();
                panel.SuspendLayout();
                label.SuspendLayout();
                panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
                panel.Controls.Add(label);
                panel.Location = new System.Drawing.Point(0, 3);
                panel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
                panel.Name = "panel2" + acc;
                panel.Size = new System.Drawing.Size(210, 40);
                panel.TabIndex = 1;
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label.Location = new System.Drawing.Point(3, 11);
                label.Name = "label2" + acc;
                label.Size = new System.Drawing.Size(67, 19);
                label.TabIndex = 2;
                label.Text = acc;
                this.flowLayoutPanel1.Controls.Add(panel);
            
        }
    }
}
