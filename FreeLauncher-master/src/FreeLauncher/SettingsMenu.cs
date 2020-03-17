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
    public partial class SettingsMenu : UserControl
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }
        public int selectedTab = 1;
       
        public void selectTab(Label label)
        {
            label1.Image = null;
            label2.Image = null;
            label3.Image = null;
            servPage11.Visible = false;
            servPage21.Visible = false;
            setPage31.Visible = false;
            selectedTab = Convert.ToInt32(label.Name.Last().ToString());
            label.Image= global::FreeLauncher.Properties.Resources.selectsettings2;
            switch(selectedTab)
            {
                case 1: servPage11.Visible = true; break;
                case 2: servPage21.Visible = true; break;
                case 3: setPage31.Visible = true; break;

            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            selectTab((Label)sender);
        }

        private void SettingsMenu_Paint(object sender, PaintEventArgs e)
        {
           
            using (Graphics g = this.CreateGraphics())
            {

            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Convert.ToInt32(((Label)sender).Name.Last().ToString())!=selectedTab)
            {
                ((Label)sender).BackColor=Color.FromArgb(84, 102, 155);
            }
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
