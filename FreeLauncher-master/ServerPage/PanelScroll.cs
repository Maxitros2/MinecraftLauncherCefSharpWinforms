using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerPage
{
    public partial class PanelScroll : UserControl
    {
        public PanelScroll()
        {
            InitializeComponent();
            flowLayoutPanel1.MouseWheel += panel3_MouseDown;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
           
        }
        public int starty = 1;
       
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
           
            

            try
            {
               
                    starty = starty - e.Delta / 120;
                if(starty>= flowLayoutPanel1.VerticalScroll.Minimum&starty<= flowLayoutPanel1.VerticalScroll.Maximum)
                flowLayoutPanel1.VerticalScroll.Value = starty;
                if (starty < 0)
                    starty = 0;
                if (starty > flowLayoutPanel1.VerticalScroll.Maximum)
                    starty = flowLayoutPanel1.VerticalScroll.Maximum;
            }
            catch
            (Exception e2)
            {

            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show(e.Type.ToString());
        }
    }
}
