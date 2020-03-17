using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeLauncher
{
    public static class AllFilterButtons
    {
        
        public static List<FilterButton> allbut = new List<FilterButton>();
        public static void disable(FilterButton activated)
        {
            foreach (FilterButton versionButton in allbut)
            {
                if (versionButton != activated)
                {
                    versionButton.disable();
                }
            }
        }
    }
    public class FilterButton : Button
    {
        public bool clicked;
        public FilterButton(String name)
        {
            clicked = false;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Location = new System.Drawing.Point(88, 3);
            this.Name = name;
            this.Size = new System.Drawing.Size(41, 23);
            this.TabIndex = 1;
            this.Text = name;
            this.UseVisualStyleBackColor = false;
            this.Margin = new Padding(3, 7, 3, 3);
            this.Click += new System.EventHandler(this.button_Click);

        }
        public void disable()
        {
            this.clicked = false;
            this.BackColor = Color.FromArgb(0, 3, 152, 184);
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                AllFilterButtons.disable(this);
                this.BackColor = Color.FromArgb(255, 3, 152, 184);
                clicked = true;
            }
            else
            {
                this.BackColor = Color.FromArgb(0, 3, 152, 184);
                clicked = false;
            }
        }
    }
}
