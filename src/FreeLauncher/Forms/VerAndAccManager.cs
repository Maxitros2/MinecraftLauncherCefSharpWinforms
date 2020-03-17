// Decompiled with JetBrains decompiler
// Type: FreeLauncher.Forms.VerAndAccManager
// Assembly: FreeLauncher, Version=1.0.0.919, Culture=neutral, PublicKeyToken=null
// MVID: F174AA51-3F28-4563-B521-955E7735BDEB
// Assembly location: C:\Users\Maxim\source\FreeLauncher-master\src\FreeLauncher\bin\Debug\FreeLauncher.exe

using CefSharp.WinForms;
using dotMCLauncher.Versioning;
using dotMCLauncher.Profiling;
using dotMCLauncher.Networking;
using dotMCLauncher.Resourcing;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static FreeLauncher.Forms.BroLauncher;
using System.Drawing;

namespace FreeLauncher.Forms
{
  internal class VerAndAccManager
  {
    private ChromiumWebBrowser chromeBrowser;
    private BroLauncher broLauncher;

    public VerAndAccManager(ChromiumWebBrowser chromeBrowser, BroLauncher broLauncher)
    {
      this.chromeBrowser = chromeBrowser;
      this.broLauncher = broLauncher;
    }
        public string abortver = "";
        public void finger(string text)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://mc-monitoring.info/api/analytics");
               
                string postData = "";
                
                        postData = "fingerprint=" + Uri.EscapeDataString(text);
              


                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                try
                {
                    abortver = broLauncher._selectedProfile.SelectedVersion;
                }
                catch (Exception e) { };
            }
            catch(Exception e)
            {

            }
        }
        public void setSettings(object xo, object yo, object zo)
        {
            string x = xo.ToString();
            string y = yo.ToString();
            string z = zo.ToString();
            if ((x != "854" || y != "480") && x != string.Empty &&
                            y != string.Empty)
            {
                WindowInfo winInfo = new WindowInfo
                {
              
                    Width = Convert.ToInt32(x),
                    Height = Convert.ToInt32(y)
                };
               ;
                broLauncher._selectedProfile.WindowInfo = winInfo;
            }
            else
            {
                broLauncher._selectedProfile.WindowInfo = null;
            }
            if (z != "-Xmx1024M" &&
                z != string.Empty)
            {
                broLauncher._selectedProfile.JavaArguments = "-Xmx"+ Convert.ToInt32(z)+"M";
            }
            else
            {
                broLauncher._selectedProfile.JavaArguments = null;
            }
            //broLauncher.SaveProfiles();
        }
        public bool issnaps()
        {
            if (broLauncher._configuration.ApplicationConfiguration.SnapEnable)
                return true;
            else
                return false;
        }

        public int isInstalled(string ver)
        {
            if (jsinit.VersionList.Where(x => x.Instaled==true&& x.VersionData.Equals(ver.Split(',')[1])).Count() > 0)
            {
                return 1;
            }
            return 0;
        }
        public void selectver2(string id,string name,bool download)
        {

            this.broLauncher._selectedProfile.SelectedVersion = id;
            
            this.launch(name, download);
        }
        public void selectver(string id)
    {

            broLauncher._selectedProfile.SelectedVersion=id;
            broLauncher.SaveProfiles();


        }
       
        public void enableReg(bool id)
        {
           
           // safecfg();
        }
        public void enableFull(bool id)
        {
            try
            {
                if (id)
                {
                    if (!File.Exists(broLauncher._configuration.McDirectory + @"\options.txt"))
                     File.Create(broLauncher._configuration.McDirectory + @"\options.txt");
                
                    
                    broLauncher._configuration.ApplicationConfiguration.FullSceen = true;
                        string str = string.Empty;
                        using (System.IO.StreamReader reader = System.IO.File.OpenText(broLauncher._configuration.McDirectory + @"\options.txt"))
                        {
                            str = reader.ReadToEnd();
                        }
                    if (!str.Contains("fullscreen"))
                    {
                        
                        File.AppendAllText(broLauncher._configuration.McDirectory + @"\options.txt", "\r\n" + "fullscreen:true");
                        return;
                    }
                       str = str.Replace("fullscreen:false", "fullscreen:true");

                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(broLauncher._configuration.McDirectory + @"\options.txt"))
                        {
                            file.Write(str);
                        }
                    
                   
                }
                else
                { broLauncher._configuration.ApplicationConfiguration.FullSceen = false;
                    string str = string.Empty;
                    using (System.IO.StreamReader reader = System.IO.File.OpenText(broLauncher._configuration.McDirectory + @"\options.txt"))
                    {
                        str = reader.ReadToEnd();
                    }
                    str = str.Replace("fullscreen:true", "fullscreen:false");

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(broLauncher._configuration.McDirectory + @"\options.txt"))
                    {
                        file.Write(str);
                    }
                }
            }
            catch (Exception e)
            { }
            //safecfg();
        }    
        public void safecfg()
        {
           broLauncher._configuration.SaveConfiguration();
        }
        public void enableSnap(bool id)
        {
            
            if (id)
            {
                broLauncher._configuration.ApplicationConfiguration.SnapEnable = true;

                
                this.broLauncher.UpdateVersionListView();
            }
            else
            {
               
                broLauncher._configuration.ApplicationConfiguration.SnapEnable = false;
                List<VersionListed> sas = jsinit.VersionList.Where(x => x.VersionName == "snapshot").ToList();
                foreach (VersionListed vr in sas)
                {
                    jsinit.VersionList.Remove(vr);
                }

                    jsinit.updateVersions();
                this.broLauncher.UpdateVersionListView();
            }
            
            safecfg();
            
        }
        public void deletenormver(string ver)
        {
            try
            {
                Directory.Delete(Path.Combine(this.broLauncher._configuration.McVersions, ver), true);
                this.broLauncher.UpdateVersionListView();
                jsinit.VersionList.Where<VersionListed>((Func<VersionListed, bool>)(x => x.VersionData.Equals(ver))).First<VersionListed>().Instaled = false;
                this.broLauncher.UpdateVersionListView();
                jsinit.updateVersions();
            }
            catch (Exception ex)
            {
            }
        }
        public void deletever(string ver)
    {
      try
      {
        Directory.Delete(Path.Combine(this.broLauncher._configuration.McVersions, ver.Split(',')[1]), true);
        this.broLauncher.UpdateVersionListView();
        jsinit.VersionList.Where<VersionListed>((Func<VersionListed, bool>) (x => x.VersionData.Equals(ver.Split(',')[1]))).First<VersionListed>().Instaled = false;
                this.broLauncher.UpdateVersionListView();
                jsinit.updateVersions();
                   jsinit.SelectVersion(jsinit.VersionList.Where(x => x.Instaled == true).First().VersionName + "," +
                 jsinit.VersionList.Where(x => x.Instaled == true).First().VersionData);
      }
      catch (Exception ex)
      {
      }
    }
        public void canceldown()
        {
            try
            {
                foreach (Thread thread in threads)
                {
                    if (thread != null)
                        thread.Abort();


                }
                deletenormver(broLauncher._selectedProfile.SelectedVersion);

                
                this.broLauncher._selectedProfile.SelectedVersion = abortver.Split(',')[1];
                broLauncher.UpdateVersionListView();

                launched = false;
            }catch
            (Exception e)
            {

            }
          
        }
        Thread[] threads = new Thread[3];
        public void aborted(Object o)
        {
            string ver = (string)o;
            abortver = ver;

        }
        public void setServer(string ip)
        {
            if (ip != null && ip != "")
            {
                //MessageBox.Show(ip);
                broLauncher._selectedProfile.ConnectionSettigs = new ServerInfo
                {
                    ServerIp = ip.Split(':')[0],
                    ServerPort = Convert.ToUInt32(ip.Split(':')[1])
                };
            }
        }
        public static bool launched = false;
       
        public void launch(string nick,bool download)
    {
            

            if (!launched)
            {
                launched = true;
                
            }
           else
            {
                
                return;
            }
            jsinit.InstallBar(true);
            jsinit.InstallBarProgress("Подготовка...", 0);
            if(broLauncher._selectedProfile.SelectedVersion.Split('-').Length>1)
            {
                if (!File.Exists(broLauncher._configuration.McVersions + "/" + broLauncher._selectedProfile.SelectedVersion.Split('-')[0] + "/" + broLauncher._selectedProfile.SelectedVersion.Split('-')[0] + ".json"))
                {
                    MessageBox.Show("Для работы Forge необходимо сначала установить версию " + broLauncher._selectedProfile.SelectedVersion.Split('-')[0]+"!");
                    jsinit.InstallBar(false);
                    
                    launched = false;
                    return;
                }
            }
            threads = new Thread[3];
            BackgroundWorker bgw = new BackgroundWorker();
        BackgroundWorker bgw1 = new BackgroundWorker();
         BackgroundWorker bgw2 = new BackgroundWorker();

        bgw.WorkerSupportsCancellation = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw2.WorkerSupportsCancellation = true;
            
            bgw.DoWork += (o, e) =>
            {
                try
                {
                    threads[0] = Thread.CurrentThread;

                    // Do your work...
                }
                catch (ThreadAbortException)
                {
                    // Do your clean up here.
                }

                broLauncher.DownloadVersion(broLauncher._versionToLaunch ?? (broLauncher._selectedProfile.SelectedVersion ?? broLauncher.GetLatestVersion(broLauncher._selectedProfile)));
                    broLauncher.UpdateVersionListView();
                
                };
            bgw.RunWorkerCompleted += delegate
            {
                string libraries = string.Empty;
               
                bgw1.DoWork += (o, e) =>
                {
                    try
                    {
                        threads[1] = Thread.CurrentThread;

                        // Do your work...
                    }
                    catch (ThreadAbortException)
                    {
                        // Do your clean up here.
                    }

                    libraries = broLauncher.DownloadLibraries();
                    
                };
                bgw1.RunWorkerCompleted += delegate
                {
                    
                    bgw2.DoWork += (o, e) =>
                    {

                        try
                        {
                            threads[2] = Thread.CurrentThread;

                            // Do your work...
                        }
                        catch (ThreadAbortException)
                        {
                            // Do your clean up here.
                        }
                        broLauncher.DownloadAssets();
                        
                       
                    };
                    bgw2.RunWorkerCompleted += delegate
                    {
                        if (broLauncher._restoreVersion)
                        {
                            
                            broLauncher.UpdateVersionListView();
                            broLauncher._versionToLaunch = null;
                            return;
                        }
                        if (!broLauncher._userManager.Accounts.ContainsKey(nick))
                        {
                            User user = new User
                            {
                                Username = nick,
                                Type = "offline"
                            };
                            broLauncher._userManager.Accounts.Add(user.Username, user);
                            broLauncher._selectedUser = user;
                        }
                        else
                        {
                            broLauncher._selectedUser = broLauncher._userManager.Accounts[nick];
                            if (broLauncher._selectedUser.Type != "offline")
                            {
                                AuthManager am = new AuthManager
                                {
                                    ClientToken = broLauncher._selectedUser.ClientToken,
                                    AccessToken = broLauncher._selectedUser.AccessToken,
                                    Uuid = broLauncher._selectedUser.Uuid
                                };
                                bool check = am.Validate();
                                if (!check)
                                {
                                    
                                    User user = new User
                                    {
                                        Username = nick,
                                        Type = "offline"
                                    };
                                    broLauncher._selectedUser = user;
                                }
                                else
                                {
                                    Refresh refresh = new Refresh(broLauncher._selectedUser.AccessToken, broLauncher._selectedUser.ClientToken);
                                    refresh = (Refresh)refresh.DoPost();
                                    broLauncher._selectedUser.UserProperties = (JArray)refresh.User?["properties"];
                                    broLauncher._selectedUser.AccessToken = refresh.AccessToken;
                                    broLauncher._userManager.Accounts[nick] = broLauncher._selectedUser;
                                }
                            }
                        }
                        broLauncher._userManager.SelectedUsername = broLauncher._selectedUser.Username;
                        SaveUsers();
                        broLauncher.UpdateUserList();
                        VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                            new DirectoryInfo(broLauncher._configuration.McVersions + @"\" +  (
                                broLauncher._selectedProfile.SelectedVersion ?? broLauncher.GetLatestVersion(broLauncher._selectedProfile))));
                        JObject properties = new JObject {
                            new JProperty("freelauncher", new JArray("cheeki_breeki_iv_damke"))
                        };
                        string gameArguments="";
                        if (broLauncher._selectedProfile.ConnectionSettigs != null)
                        {
                            try
                            {
                                selectedVersionManifest.ArgCollection.Add("server",
                                    broLauncher._selectedProfile.ConnectionSettigs.ServerIp);
                                selectedVersionManifest.ArgCollection.Add("port",
                                    broLauncher._selectedProfile.ConnectionSettigs.ServerPort.ToString());
                            }catch
                            (Exception e)
                            {

                                gameArguments += "--server " + broLauncher._selectedProfile.ConnectionSettigs.ServerIp + " --port " + broLauncher._selectedProfile.ConnectionSettigs.ServerPort.ToString() + " ";
                            }
                            }
                        string javaArguments = broLauncher._selectedProfile.JavaArguments == null
                            ? string.Empty
                            : broLauncher._selectedProfile.JavaArguments + " ";
                        if (broLauncher._selectedProfile.WorkingDirectory != null &&
                            !Directory.Exists(broLauncher._selectedProfile.WorkingDirectory))
                        {
                            Directory.CreateDirectory(broLauncher._selectedProfile.WorkingDirectory);
                        }
                        string username;
                        if (broLauncher._selectedUser.Type != "offline")
                        {
                            while (true)
                            {
                                try
                                {
                                    if (broLauncher._nicknameDictionary.ContainsKey(broLauncher._selectedUser.Uuid) && broLauncher._nicknameDictionary[broLauncher._selectedUser.Uuid].Item2 > DateTime.Now)
                                    {
                                        username = broLauncher._nicknameDictionary[broLauncher._selectedUser.Uuid].Item1;
                                        break;
                                    }
                                    if (broLauncher._nicknameDictionary.ContainsKey(broLauncher._selectedUser.Uuid) && broLauncher._nicknameDictionary[broLauncher._selectedUser.Uuid].Item2 <= DateTime.Now)
                                    {
                                        broLauncher._nicknameDictionary.Remove(broLauncher._selectedUser.Uuid);
                                    }
                                    broLauncher._nicknameDictionary.Add(broLauncher._selectedUser.Uuid, new Tuple<string, DateTime>(
                                        new Username
                                        {
                                            Uuid = broLauncher._selectedUser.Uuid
                                        }.GetUsernameByUuid(),
                                        DateTime.Now.AddMinutes(30)));
                                    username = broLauncher._nicknameDictionary[broLauncher._selectedUser.Uuid].Item1;
                                    break;
                                }
                                catch (WebException ex)
                                {
                                    if ((int)((HttpWebResponse)ex.Response).StatusCode != 429)
                                    {
                                       // AppendException($"An unhandled exception has occured while getting username by UUID:{Environment.NewLine}{ex}");
                                        username = nick;
                                        break;
                                    }
                                    Thread.Sleep(10000);

                                }
                            }
                        }
                        else
                        {
                            username = nick;
                        }
                        Dictionary<string, string> gameArgumentDictionary = new Dictionary<string, string> {
                            {
                                "auth_player_name", username
                            }, {
                                "version_name", broLauncher._selectedProfile.ProfileName
                            }, {
                                "game_directory",
                                broLauncher._selectedProfile.WorkingDirectory ?? broLauncher._configuration.McDirectory + @"\"
                            }, {
                                "assets_root", broLauncher._configuration.McDirectory + @"\assets\"
                            }, {
                                "game_assets", broLauncher._configuration.McDirectory + @"\assets\virtual\legacy\"
                            }, {
                                "assets_index_name", selectedVersionManifest.GetAssetsIndex()
                            }, {
                                "version_type", selectedVersionManifest.ReleaseType
                            }, {
                                "auth_session", $"token:{broLauncher._selectedUser.ClientToken}:{broLauncher._selectedUser.Uuid}" ?? "token:sample_token:sample_token"
                            }, {
                                "auth_access_token", broLauncher._selectedUser.AccessToken ?? "sample_token"
                            }, {
                                "auth_uuid", broLauncher._selectedUser.Uuid ?? "sample_token"
                            }, {
                                "user_properties",
                               broLauncher._selectedUser.UserProperties?.ToString(Formatting.None) ??
                                properties.ToString(Formatting.None)
                            }, {
                                "user_type", broLauncher._selectedUser.Type
                            }
                        };
                        Dictionary<string, string> jvmArgumentDictionary = new Dictionary<string, string> {
                            {
                                "natives_directory", broLauncher._configuration.McDirectory + @"\natives\"
                            }, {
                                "launcher_name", Application.ProductName
                            }, {
                                "launcher_version", Application.ProductVersion
                            }, {
                                "classpath", libraries.Contains(' ') ? $"\"{libraries}\"" : libraries
                            }
                        };
                        string  jvmArguments;
                        if (selectedVersionManifest.Type == VersionManifestType.V2)
                        {
                            List<Rule> requiredRules = new List<Rule> {
                                new Rule {
                                    Action = "allow",
                                    Os = new Os {
                                        Name = "windows"
                                    }
                                }
                            };
                            if (new ComputerInfo().OSFullName.ToUpperInvariant().Contains("WINDOWS 10"))
                            {
                                requiredRules.Add(new Rule
                                {
                                    Action = "allow",
                                    Os = new Os
                                    {
                                        Name = "windows",
                                        Version = "^10\\."
                                    }
                                });
                            }
                            if (broLauncher._selectedProfile.WindowInfo != null && (broLauncher._selectedProfile.WindowInfo.Width != 854 || broLauncher._selectedProfile.WindowInfo.Height != 480))
                            {
                                requiredRules.Add(new Rule
                                {
                                    Action = "allow",
                                    Features = new Features
                                    {
                                        IsForCustomResolution = true
                                    }
                                });
                                
                                gameArgumentDictionary.Add("resolution_width",
                                    broLauncher._selectedProfile.WindowInfo?.Width.ToString());
                               gameArgumentDictionary.Add("resolution_height",
                                   broLauncher._selectedProfile.WindowInfo?.Height.ToString());
                            }
                            gameArguments +=
                                selectedVersionManifest.BuildArgumentsByGroup(ArgumentsGroupType.GAME, gameArgumentDictionary, requiredRules.ToArray());
                            jvmArguments = selectedVersionManifest.BuildArgumentsByGroup(ArgumentsGroupType.JVM, jvmArgumentDictionary, requiredRules.ToArray());
                        }
                        else
                        {
                            string nativesPath = broLauncher._configuration.McDirectory + @"\natives\";
                            nativesPath = nativesPath.Contains(' ') ? $@"""{nativesPath}""" : nativesPath;
                            gameArguments += selectedVersionManifest.ArgCollection.ToString(gameArgumentDictionary);
                            jvmArguments = javaArguments +
                                $"-Djava.library.path={nativesPath} -cp {(libraries.Contains(' ') ? $@"""{libraries}""" : libraries)}";
                        }
                        //MessageBox.Show(gameArguments);
                        if (!download)
                        {
                            ProcessStartInfo proc = new ProcessStartInfo
                            {
                                UseShellExecute = false,
                                RedirectStandardOutput = true,
                                RedirectStandardError = true,
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = broLauncher._selectedProfile.JavaExecutable ?? Java.JavaExecutable,
                                StandardErrorEncoding = Encoding.UTF8,
                                WorkingDirectory = broLauncher._selectedProfile.WorkingDirectory ?? broLauncher._configuration.McDirectory + @"\",
                                Arguments =
                                    $"{jvmArguments} {selectedVersionManifest.MainClass} {gameArguments}"
                            };
                            jsinit.InstallBarProgress("Подготовка к запуску...", 90);
                            new MinecraftProcess(new Process
                            {
                                StartInfo = proc,
                                EnableRaisingEvents = true
                            }, broLauncher,
                                broLauncher._selectedProfile).Launch();
                            
                            jsinit.InstallBarProgress("Приятной игры!", 100);
                            Thread.Sleep(2000);
                            jsinit.InstallBar(false);
                            //SetControlBlockState(false);
                            broLauncher.UpdateVersionListView();
                            broLauncher._versionToLaunch = null;
                            broLauncher._selectedProfile.ConnectionSettigs = null;

                            broLauncher.hideform();
                           
                            launched = false;
                        }
                        else
                        {

                            string ver = broLauncher._selectedProfile.SelectedVersion;
                            this.broLauncher.UpdateVersionListView();
                            jsinit.VersionList.Where<VersionListed>((Func<VersionListed, bool>)(x => x.VersionData.Equals(ver))).First<VersionListed>().Instaled = true;
                            jsinit.updateVersions();
                           
                            jsinit.InstallBar(false);
                            launched = false;
                        }
                    };
                    bgw2.RunWorkerAsync();
                };
                bgw1.RunWorkerAsync();
            };
            bgw.RunWorkerAsync();
        }
        public void showform()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork+=(o1,o2)=>
            {
                Thread.Sleep(500);
                broLauncher.Invoke(new Action(() => {

                    broLauncher.loading = false;
                    broLauncher.Width = 1190;
                    broLauncher.Height = 700;
                    broLauncher.MinimumSize = new Size(1190, 700);
                    // this.Show();

                    broLauncher.WindowState = FormWindowState.Normal;
                    // broLauncher.ShowInTaskbar = true;
                }));
            };
            bw.RunWorkerAsync();
        }
        public void deleteUser(string text)
    {
      this.broLauncher._userManager.Accounts.Remove(text);
      this.SaveUsers();
      try
      {
        jsinit.SelectUser(this.broLauncher._userManager.Accounts.Keys.ToList<string>().First<string>());
      }
      catch (Exception ex)
      {
        Random random = new Random();
        object[] objArray = new object[5]
        {
          (object) "BroLauncher",
          (object) random.Next(9),
          (object) random.Next(9),
          null,
          null
        };
        char ch = (char) random.Next(97, 122);
        objArray[3] = (object) ch.ToString();
        ch = (char) random.Next(97, 122);
        objArray[4] = (object) ch.ToString();
        this.addAccount(string.Concat(objArray));
      }
    }

      
           
    public void selectVersion(string ver)
    {

            
            this.broLauncher._selectedProfile.SelectedVersion = ver.Split(',')[1];
           
            broLauncher.SaveProfiles();
    }

    private void SaveUsers()
    {
      try
      {
        string path = this.broLauncher._configuration.McLauncher + "\\users.json";
        UserManager userManager = this.broLauncher._userManager;
                File.WriteAllText(broLauncher._configuration.McLauncher + @"\users.json",
                          JsonConvert.SerializeObject(broLauncher._userManager, Formatting.Indented,
                              new JsonSerializerSettings
                              {
                                  NullValueHandling = NullValueHandling.Ignore
                              }));
              
        jsinit.initUsers(this.broLauncher._userManager.Accounts);
      }
      catch (Exception ex)
      {
      }
    }

    public void addAccount(string text)
    {
      User user = new User() { Username = text };
      user.Type = "offline";
      if (this.broLauncher._userManager.Accounts.ContainsKey(user.Username))
        this.broLauncher._userManager.Accounts[user.Username] = user;
      else
        this.broLauncher._userManager.Accounts.Add(user.Username, user);
      this.broLauncher._userManager.SelectedUsername = user.Username;
      this.SaveUsers();
      jsinit.SelectUser(user.Username);
    }

    public void selectAccount(string text)
    {
      //int num = (int) MessageBox.Show(jsinit.SelectedUser.Username);
      this.broLauncher._userManager.SelectedUsername = text;
      this.broLauncher._selectedUser = jsinit.SelectedUser;
    }
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   