using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownPane_l
{
    public partial class UserControl1: UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g2 = NicknamePanel.CreateGraphics();
            g2.DrawRectangle(new Pen(Color.FromArgb(57, 74, 127)), 0, 0, NicknamePanel.Width, NicknamePanel.Height - 1);
            Graphics g3 = NicknamePanel2.CreateGraphics();

            g3.DrawRectangle(new Pen(Color.FromArgb(57, 74, 127)), 0, 0, NicknamePanel2.Width - 1, NicknamePanel2.Height - 1);

            Graphics g5 = BuildPanel.CreateGraphics();
            g5.DrawRectangle(new Pen(Color.FromArgb(57, 74, 127)), 0, 0, NicknamePanel.Width, NicknamePanel.Height - 1);
            Graphics g4 = BuildPanel2.CreateGraphics();
            g4.DrawRectangle(new Pen(Color.FromArgb(57, 74, 127)), 0, 0, NicknamePanel2.Width - 1, NicknamePanel2.Height - 1);
        }

        private void NicknamePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool nickflip = false;
        private void NicknamePanel2_Click(object sender, EventArgs e)
        {
            Image image = global::DownPane_l.Properties.Resources.strelochka;
            
            if (!nickflip)
            
            image.RotateFlip(RotateFlipType.Rotate180FlipX);

            NicknamePanel2.BackgroundImage = image;
            nickflip = !nickflip;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {

        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.Gray;

        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.Transparent;
        }
    }
}
