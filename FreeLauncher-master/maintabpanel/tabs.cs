using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintabpanel
{
    public partial class tabs: UserControl
    {
        List<Label> tabsdown;
        public int selectedtab = 1;
        public tabs()
        {
            InitializeComponent();
            tabsdown = new List<Label>() { tab1, tab2, tab3 };
        }
        private void label1_Click(object sender, EventArgs e)
        {

            selectItem(Convert.ToInt32(((Label)sender).Name.Last().ToString()), (Label)sender);
        }
        private void selectItem(int k, Label label)
        {


            using (Graphics g = this.CreateGraphics())
            {
                using (Pen pen = new Pen(Color.FromArgb(125, 9, 9, 11), 2))
                {



                    tab1.ForeColor = Color.FromArgb(72, 88, 137);
                    tab2.ForeColor = Color.FromArgb(72, 88, 137);
                    tab3.ForeColor = Color.FromArgb(72, 88, 137);
                    tab1.Image = null;
                    tab2.Image = null;
                    tab3.Image = null;
                    selectedtab = k;
                    tabsdown.ElementAt(k - 1).ForeColor = Color.White;
                    tabsdown.ElementAt(k - 1).Image = global::maintabpanel.Properties.Resources.choose;
                    g.DrawLine(new Pen(Color.FromArgb(57, 74, 127)), 0, 31, 800, 31);

                }
            }

        }
        private void tab1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void tab1_MouseLeave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((Label)sender).Name.Last().ToString()) != selectedtab)
            {
                ((Label)sender).ForeColor = Color.FromArgb(72, 88, 137);
            }
        }

        private void tabs_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawLine(new Pen(Color.FromArgb(57, 74, 127)), 0, 30, 800, 30);
            }

            }
    }
}
