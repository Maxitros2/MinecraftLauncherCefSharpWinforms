using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotMCLauncher.Versioning;
using FreeLauncher.Forms;
using dotMCLauncher.Profiling;
using Newtonsoft.Json.Linq;
using System.IO;

namespace FreeLauncher
{
   
    
    public partial class SetPage3 : UserControl
    {

        List<RoundedButton2> buttons;
        VersionList versionListMojang = new VersionList("Mojang");
        VersionList versionListForge = new VersionList("Forge");
        VersionList versionListCheats = new VersionList("Читы");

        public Configuration _configuration;
        public MadForm madForm;
        public Profile Profile { get; }
        public string selectedvesion;
        
        public SetPage3()
        {
            InitializeComponent();
           
            buttons = new List<RoundedButton2>();
            foreach (Control control in panel12.Controls)
                buttons.Add((RoundedButton2)control);
            

        }
       
        public void ClearVersions()
        {
            versionListMojang= new VersionList("Mojang");
            versionListForge = new VersionList("Forge");
            versionListCheats = new VersionList("Читы");
        }
        private bool IsVersionInstalled(string id)
        {
            return File.Exists(string.Format(@"{0}\{1}\{1}.json", _configuration.McVersions,
                new DirectoryInfo(id).Name)) && File.Exists(string.Format(@"{0}\{1}\{1}.jar", _configuration.McVersions,
                new DirectoryInfo(id).Name));
        }
        public void getVersions()
        {
            ClearVersions();

            // versionsDropDownList.Items.Add(_configuration.Localization.UseLatestVersion);
            List<string> list = new List<string>();
            JObject json = JObject.Parse(File.ReadAllText(_configuration.McVersions + @"\versions.json"));
            foreach (JObject ver in json["versions"])
            {
                string id = ver["id"].ToString(),
                       type = ver["type"].ToString(),
                       text = $"{type} {id}";
                list.Add(string.Format("{0} {1}", type, id));






                switch (type)
                {

                    case "snapshot":
                        if (_configuration.ApplicationConfiguration.SnapEnable == false)
                        {
                            {
                                VersionToShow versionToShow = new VersionToShow();
                                versionToShow.type = text.Split(' ')[0];
                                versionToShow.id = id;
                                versionToShow.fullid = text;
                                versionToShow.installed = IsVersionInstalled(id);
                                versionListMojang.versions.Add(versionToShow);
                            }

                        }
                        break;
                    case "old_beta":

                        break;
                    case "old_alpha":

                        break;

                    case "release":
                        {
                            VersionToShow versionToShow = new VersionToShow();
                            versionToShow.type = text.Split(' ')[0];
                            versionToShow.id = id;
                            versionToShow.fullid = text;
                            versionListMojang.versions.Add(versionToShow);
                            versionToShow.installed = IsVersionInstalled(id);
                        }
                        break;
                    default:

                       // jsinit.AddVersions(text, id, IsVersionInstalled(id));

                        break;
                }
            }

            foreach (String version in ForgeVersions.versions)
            {

                {
                    VersionToShow versionToShow = new VersionToShow();
                    versionToShow.type = "Forge";
                    versionToShow.id = version;
                    versionToShow.fullid = "Forge "+version;
                    versionListForge.versions.Add(versionToShow);
                }
               

            }
           foreach (CheatClient version in CheatPage.cheatInfo.Clients)
            {
                foreach(CheatVer ver in version.Versions)
                {
                    {
                        VersionToShow versionToShow = new VersionToShow();
                        versionToShow.type = version.name;
                        versionToShow.id = version.name + " " + ver.VerId;
                        versionToShow.fullid = version.name+" " + ver.VerId;
                        versionListCheats.versions.Add(versionToShow);
                    }

                }
            }


                /*
                foreach (VersionManifest version in from b in Directory.GetDirectories(_configuration.McVersions)
                                                    where File.Exists(string.Format(@"{0}\{1}\{1}.json", _configuration.McVersions,
                                                        new DirectoryInfo(b).Name))
                                                    let add = list.All(a => !a.Contains(new DirectoryInfo(b).Name))
                                                    where add
                                                    where VersionManifest.IsValid(new DirectoryInfo(string.Format(@"{0}\{1}\", _configuration.McVersions,
                                                        new DirectoryInfo(b).Name)))
                                                    select
                                                    VersionManifest.ParseVersion(
                                                        new DirectoryInfo(string.Format(@"{0}\{1}\", _configuration.McVersions,
                                                            new DirectoryInfo(b).Name)), false))
                {
                    jsinit.AddVersions("Модификация", version.VersionId, true);
                }
                */

            }
        public int SelectedSource = 1;
        public string SelectedSourceName = "Mojang";
        public void SelectClientSource(object ob)
        {
            RoundedButton2 rb = (RoundedButton2)ob;
            foreach (RoundedButton2 rbs in buttons)
                rbs.BackColor = Color.FromArgb(30, 42, 80);
            rb.BackColor = Color.FromArgb(151, 53, 129);
            SelectedSourceName = rb.Text;
            
            switch (rb.Text)
            {
                case "Mojang":
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel2.Controls.Clear();
                    foreach (VersionToShow version in versionListMojang.versions)
                        AddInstalledAcc(version);
                    SelectedSource = 1; break;
                case "Forge":
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel2.Controls.Clear();
                    foreach (VersionToShow version in versionListForge.versions)
                        AddInstalledAcc(version);
                    SelectedSource = 2; break;
                case "Optifine":
                    SelectedSource = 3; break;
                case "Читы":
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel2.Controls.Clear();
                    foreach (VersionToShow version in versionListCheats.versions)
                        AddInstalledAcc(version);
                    SelectedSource = 4; break;

            }
        }
        public void getMad(MadForm madForm)
        {
            this.madForm = madForm;
        }
        public void AddInstalledAcc(VersionToShow version)
        {
            Panel panel = new Panel();
            PictureBox pictureBox = new PictureBox();

            Label labelv = new Label();
            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));

            panel.Controls.Add(labelv);
            panel.Controls.Add(pictureBox);
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "MainPanel";
            panel.Size = new System.Drawing.Size(517, 46);
            panel.TabIndex = 3;
            if (version.installed)
            {
                pictureBox.Image = global::FreeLauncher.Properties.Resources.xmark;

            }
            else
            {
                pictureBox.Image = global::FreeLauncher.Properties.Resources.DownloadCheat;
                pictureBox.Click += (o, e2) =>
                  {
                      this.selectedvesion = version.id;
                  };

            }
           // pictureBox.Image = global::FreeLauncher.Properties.Resources.xmark;
            pictureBox.Location = new System.Drawing.Point(486, 12);
            pictureBox.Name = "PictureButton";
            pictureBox.Size = new System.Drawing.Size(20, 20);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            labelv.AutoSize = true;
            labelv.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelv.ForeColor = System.Drawing.Color.White;
            labelv.Location = new System.Drawing.Point(3, 14);
            labelv.Name = "MainName";
            labelv.Size = new System.Drawing.Size(52, 19);
            labelv.TabIndex = 1;
            labelv.Text = version.fullid;
            labelv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            if (version.installed)
            {
                this.flowLayoutPanel1.Controls.Add(panel);

            }
            else
            {
                this.flowLayoutPanel2.Controls.Add(panel);
            }
        }
       

        private void roundedButton24_MouseMove(object sender, MouseEventArgs e)
        {
         ((RoundedButton2)sender).BackColor = Color.FromArgb(151, 53, 129);
        }

        private void roundedButton24_MouseLeave(object sender, EventArgs e)
        {
            if (((RoundedButton2)sender).Text!=SelectedSourceName)
                ((RoundedButton2)sender).BackColor = Color.FromArgb(30, 42, 80);
        }

        private void roundedButton24_Click_1(object sender, EventArgs e)
        {
            SelectClientSource(sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class VersionToShow
    {
        public string fullid, id, type;
        public bool installed;
    }
    public class VersionList
    {
        public string Tittle;
        public List<VersionToShow> versions;
        public VersionList(String name)
        {
            this.Tittle = name;
            this.versions = new List<VersionToShow>();
        }

    }
}
