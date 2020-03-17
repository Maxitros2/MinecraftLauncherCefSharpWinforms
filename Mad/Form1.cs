using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.CHILLER.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.CHILLER;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
            label1.Font = new Font(pfc.Families[0], label1.Font.Size);
            label1.Text = "MAD";
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ComboBox flattenCombo = new ComboBox();
            flattenCombo.Location = new Point(100, 100);
            flattenCombo.Size = new Size(100, 20);
            flattenCombo.FormattingEnabled = true;

            flattenCombo.Name = "comboBox12";
            flattenCombo.Size = new System.Drawing.Size(121, 21);
            flattenCombo.TabIndex = 2;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
         

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
