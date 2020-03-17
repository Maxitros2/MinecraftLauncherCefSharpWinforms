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
    public partial class ServerPanel: UserControl
    {
        public ServerPanel()
        {
            InitializeComponent();
        }
        private void button1_EnabledChanged(object sender, EventArgs e)
        {

            ((Button)sender).ForeColor = ((Button)sender).Enabled == true ? Color.White : Color.Gray;


        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            string text = "";

            dynamic btn = (Button)sender;
            switch (((Button)sender).Name)

            {
                case "button1": text = "Назад"; break;
                case "roundedButton1": text = "1"; break;
                case "roundedButton2": text = "2"; break;
                case "roundedButton3": text = "3"; break;
                case "roundedButton4": text = "Вперед"; break;
            }

            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            ((Button)sender).Text = string.Empty;
            e.Graphics.DrawString(text, btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();


        }
    }
}
