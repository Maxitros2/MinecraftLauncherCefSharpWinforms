using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace FreeLauncher
{
    
    public partial class CheatPage : UserControl
    {
        public CheatPage()
        {
            InitializeComponent();
            Image image = global::FreeLauncher.Properties.Resources.CheatStrelka;
            image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.panel5.BackgroundImage = image;
           
        }
        public static CheatInfo cheatInfo;
        private void CheatPage_Paint(object sender, PaintEventArgs e)
        {
           
        } 
        public void addCheat(CheatClient cheatClient)
        {
            Panel MainPanela = new Panel();
            Label BigNamea = new Label();
            Label Descriptiona = new Label();
            Panel Downloada = new Panel();
            MainPanela.BackColor = Color.FromArgb(125, 9, 9,11);
            MainPanela.Controls.Add(Descriptiona);
           MainPanela.Controls.Add(BigNamea);
           MainPanela.Controls.Add(Downloada);
           MainPanela.Location = new System.Drawing.Point(0, 0);
           MainPanela.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
           MainPanela.Name = "MainPanel "+ cheatClient.name;
           MainPanela.Size = new System.Drawing.Size(708, 100);
           MainPanela.TabIndex = 1;
            BigNamea.ForeColor = Color.White;
            BigNamea.UseCompatibleTextRendering = true;
           BigNamea.Dock = System.Windows.Forms.DockStyle.Left;
           BigNamea.Font = new System.Drawing.Font("PF BeauSans Pro", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
           BigNamea.Image = global::FreeLauncher.Properties.Resources.ramka;
           BigNamea.Location = new System.Drawing.Point(0, 0);
           BigNamea.Margin = new System.Windows.Forms.Padding(0);
           BigNamea.Name = "BigName " + cheatClient.name;
           BigNamea.Size = new System.Drawing.Size(100, 100);
           BigNamea.TabIndex = 3;
           BigNamea.Text = cheatClient.name.First().ToString();
           BigNamea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           Descriptiona.Dock = System.Windows.Forms.DockStyle.Fill;
           Descriptiona.Font = new System.Drawing.Font("PF BeauSans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
           Descriptiona.Location = new System.Drawing.Point(100, 0);
           Descriptiona.Name = "Description";
           Descriptiona.Size = new System.Drawing.Size(563, 100);
           Descriptiona.TabIndex = 1;
           Descriptiona.Text = cheatClient.Desc;
            Descriptiona.ForeColor = Color.White;
            Descriptiona.Padding = new Padding(0, 8, 0, 0);
            Downloada.BackgroundImage = global::FreeLauncher.Properties.Resources.DownloadCheat;
            Downloada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Downloada.Dock = System.Windows.Forms.DockStyle.Right;
            Downloada.Location = new System.Drawing.Point(663, 0);
            Downloada.Margin = new System.Windows.Forms.Padding(0);
            Downloada.Name = cheatClient.name;
            Downloada.Size = new System.Drawing.Size(45, 100);
            Downloada.TabIndex = 2;

            this.flowLayoutPanel1.Controls.Add(MainPanela);


        }
        public void addAcc(String nick)
        {
            Panel panel = new Panel();

            Label label = new Label();
            panel.SuspendLayout();
            label.SuspendLayout();
            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            panel.Controls.Add(label);
            panel.Location = new System.Drawing.Point(0, 3);
            panel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            panel.Name = "panel2" + nick;
            panel.Size = new System.Drawing.Size(210, 40);
            panel.TabIndex = 1;
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.Location = new System.Drawing.Point(3, 11);
            label.Name = nick;
            label.Size = new System.Drawing.Size(67, 19);
            label.TabIndex = 2;
            label.Text = "Версия " + nick;
            panel.Click += (o, e) =>
            {
               
              
            };
            this.flowLayoutPanel2.Controls.Add(panel);
        }
        public void init()
        {
            cheatInfo = Newtonsoft.Json.JsonConvert.DeserializeObject <CheatInfo> (new WebClient().DownloadString(@"https://madlauncher.com/file/cheats/Versions.json"));
          
            foreach (CheatClient cc in cheatInfo.Clients)
                addCheat(cc);
        }
    }
}
