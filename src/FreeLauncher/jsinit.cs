
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotMCLauncher.Versioning;
using dotMCLauncher.Profiling;
using dotMCLauncher.Networking;
using dotMCLauncher.Resourcing;
using FreeLauncher.Forms;
using CefSharp.WinForms;
using System.Windows.Forms;
using CefSharp;

namespace FreeLauncher
{
    public class VersionListed
    {
        public VersionListed(String VersionName, String VersionData, bool Instaled)
        {
            this.VersionName = VersionName;
            this.VersionData = VersionData;
            this.Instaled = Instaled;
           
        }
        public String VersionName;
        public String VersionData;
        public bool Instaled;

    }
        class jsinit
    {
        public static ChromiumWebBrowser chromium = null;
        public static List<String> InitCommands = new List<String>();
        public static List<VersionListed> VersionList = new List<VersionListed>();
        public static Dictionary<String, User> users = new Dictionary<string, User>();
        public static bool AlreadyInstalled=false;
        public static User SelectedUser = new User();
        public static void DirectInput(String com)
        {

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            chromium.ExecuteScriptAsync(com);


        }
        public static void setCfg(bool snaps, bool reg, bool fullscreen)
        {
            if (!AlreadyInstalled)
            {
                if (snaps)
                {

                    InitCommands.Add("$(\".js-ms_setmanager_fullscreen\").prop('checked', true);");
                   // InitCommands.Add(" verAndAccManager.enableSnap(settingsManager.getSnap());");
                }
                if (fullscreen)
                {
                    InitCommands.Add("$(\".js-ms_setmanager_fullscreen2\").prop('checked', true);");
                   // InitCommands.Add("verAndAccManager.enableFull(settingsManager.getFull());");
                }
                if (reg)
                {
                    InitCommands.Add("$(\".js-ms_setmanager_fullscreen3\").prop('checked', true);");
                    //InitCommands.Add("verAndAccManager.enableReg(settingsManager.getReg());");
                }
            }
        }
        public static void InstallBar(bool enable)
        {
            if(enable)
            {
                DirectInput("blockInstallProgress.show();");
            }
            else
            {
                DirectInput("blockInstallProgress.hide();");
            }
        }
        public static void InstallBarProgress(string text,int per)
        {
            DirectInput("blockInstallProgress.set(\""+text+"\","+per+");");
        }
        public static void DeleteUser(String text)
        {
           
        }
        public static void initUsers(Dictionary<String, User> keys)
        {
            
            if (!AlreadyInstalled)
            {
                users = keys;
                foreach (String nick in users.Keys)
                {

                    InitCommands.Add("accManager.add(\"" + nick + "\");");
                }
            }
            else
            {
                DirectInput("accManager.clear();");
                foreach (String nick in users.Keys)
                {

                    DirectInput("accManager.add(\"" + nick + "\");");
                }
            }
        }
        public static void SelectUser(String nick)
        {
            SelectedUser = users.Where(x => x.Key.Equals(nick)).First().Value;
            if (AlreadyInstalled)
            {
                DirectInput("accManager.setAccount(\"" + nick + "\")");
            }
            else
            {
                InitCommands.Add("accManager.setAccount(\"" + nick + "\")");
            }
               
            
        }
        public static void showLoad()
        {
            if (!AlreadyInstalled)
            {
                InitCommands.Add("uiLoader.show();");
            }
            else
            {
                DirectInput("uiLoader.show();");
            }
        }
        public static void hideLoad()
        {
            if (!AlreadyInstalled)
            {
                InitCommands.Add("uiLoader.hide();");
            }
            else
            {
                DirectInput("uiLoader.hide();");
            }
        }
        public static void ClearAccs()
        {
            InitCommands.Add("accManager.clear();"); 
        }
        public static void AddAcc(String nick)
        {
            DirectInput("accManager.add(\"" + nick + "\");");
        }
        public static void SelectVersion(String id)
        {
            if (AlreadyInstalled)
            {
                DirectInput("verManager.setVersion(\"" + id + "\");");
            }
            else
            {
                InitCommands.Add("verManager.setVersion(\"" + id + "\");");
            }

        }
        public string lastabot = "";
        public static String GenerateVersions()
        {
            
            String st = "";
            List<VersionListed> SnapVer = new List<VersionListed>();
            List<VersionListed> sas = VersionList.ToList();
            foreach (VersionListed vr in sas)
            {
                if (vr.VersionName == "snapshot")
                {
                    
                    VersionList.Remove(vr);
                    
                    SnapVer.Add(vr);
                    st = st + vr.VersionData + " ";
            }
                        }
            //MessageBox.Show(st);
            VersionList=VersionList.OrderBy(x => Convert.ToInt32(x.VersionData.Split('-')[0].Split('.')[1])*10+((x.VersionData.Split('-')[0].Split('.').Length>=3)?Convert.ToInt32(x.VersionData.Split('-')[0].Split('.')[2]):0)).ToList();
            SnapVer.Reverse();
            VersionList = SnapVer.Concat(VersionList).ToList();
            String com = "verManager.set({ installed: [";
            foreach(VersionListed ver in VersionList)
            {
                if(ver.Instaled)
                {
                    com = com + "[\"" + ver.VersionName + "\", \"" + ver.VersionData + "\"],";
                }
            }
            com = com.TrimEnd(',') + "], notinstalled: [";
            VersionList.Reverse();
            foreach (VersionListed ver in VersionList)
            {
                if (!ver.Instaled)
                {
                    //MessageBox.Show(ver.VersionName);
                    com = com + "[\"" + ver.VersionName + "\", \"" + ver.VersionData + "\"],";
                }
            }
            com = com.TrimEnd(',') + "] });";
           
            return com;
        }


        public static void AddVersions(String tag, String id,bool installed)
        {
            if (AlreadyInstalled)
            {
                if (VersionList.Where(x => x.VersionData.Equals(id)).Count() == 0)
                {
                    VersionList.Add(new VersionListed(tag, id, installed));
                }
                else
                {

                    VersionList.Where(x => x.VersionData.Equals(id)).First().Instaled = installed;
                }
            }
            else
            {
                if (VersionList.Where(x => x.VersionData.Equals(id)).Count() == 0)
                {
                    VersionList.Add(new VersionListed(tag, id, installed));
                }
                else
                {
                    
                    VersionList.Where(x => x.VersionData.Equals(id)).First().Instaled = installed;
                }
               // InitCommands.Add("verManager.set({ installed: [[\""+id+ "\", \""+id+"\"]], notinstalled: [[\"title2\", \"value2\"]] });");
            }

        }
        public static void ClearVersions()
        {
            if (AlreadyInstalled)
            {
                DirectInput("verManager.clear();");
            }
            else
            {
                InitCommands.Add("verManager.clear();");
            }
        }

        internal static void updateVersions()
        {
           
            DirectInput(GenerateVersions());
        }
    }
}
