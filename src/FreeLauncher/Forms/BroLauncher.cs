using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using dotMCLauncher.Profiling;
using dotMCLauncher.Resourcing;
using dotMCLauncher.Versioning;
using Forgefier;
using Ionic.Zip;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS = dotMCLauncher.OperatingSystem;

namespace FreeLauncher.Forms
{
    public class UserManager
    {
        [JsonProperty("selectedUsername")]
        public string SelectedUsername { get; set; }

        [JsonProperty("users")]
        public Dictionary<string, User> Accounts { get; set; } = new Dictionary<string, User>();
    }

    public class User
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("sessionToken")]
        public string ClientToken { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("properties")]
        public JArray UserProperties { get; set; }
    }
    public partial class BroLauncher : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        #region Variables


        public readonly Configuration _configuration;
        public ProfileManager _profileManager;
        public RawVersionListManifest _versionList;
        public Profile _selectedProfile;
        public UserManager _userManager;
        public User _selectedUser;
        public readonly Dictionary<string, Tuple<string, DateTime>> _nicknameDictionary;
        public ApplicationConfiguration _cfg;
        public string _versionToLaunch;
        public bool _restoreVersion;

        private static int LinuxTimeStamp => (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        private int StatusBarValue
        {
            get
            {
                return progressBar1.Value;
            }
            set
            {
                SetStatusBarValue(value);
            }
        }

        private void SetControlBlockState(bool block)
        {

            
        }

        private void SetStatusBarValue(int value)
        {
           
          
            {
               // progressBar1.Value = value;
            }
        }

        private void SetStatusBarMaxValue(int value)
        {
            
            
            {
                //progressBar1.Maximum = value;
            }
        }

        private void SetStatusBarVisibility(bool visible)
        {
            
            
            {
                //progressBar1.Visible = visible;
            }
        }
        public void FavListInit()
        {

            if (!File.Exists(_configuration.McDirectory + "/serversFav.txt"))
            {
                File.Create(_configuration.McDirectory + "/serversFav.txt");
                return;
            }
            string ids = File.ReadAllText(_configuration.McDirectory + "/serversFav.txt");
            if (ids != "")
            {
                ids = ids.TrimEnd(',');
                Filters.Fav = ids.Split(',').ToList();
            }
        }
        public void FavListSave()
        {
            String sw = "";
                foreach(String id in Filters.Fav)
                {
                    sw+=id + ",";
                }
            File.WriteAllText(_configuration.McDirectory + "/serversFav.txt", sw);
        }
#endregion Variables
public void SaveProfiles()
        {
            File.WriteAllText(_configuration.McDirectory + @"\launcher_profiles.json", _profileManager.ToJson());
        }
        public string GetLatestVersion(Profile profile)
        {
            return profile.AllowedReleaseTypes != null
                ? profile.AllowedReleaseTypes.Contains("snapshot")
                    ? _versionList.LatestVersions.Snapshot
                    : _versionList.LatestVersions.Release
                : _versionList.LatestVersions.Release;
        }
        private void SaveUsers()
        {

            File.WriteAllText(_configuration.McLauncher + @"\users.json",
                JsonConvert.SerializeObject(_userManager, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }));

        }
        private bool IsVersionInstalled(string id)
        {
            return File.Exists(string.Format(@"{0}\{1}\{1}.json", _configuration.McVersions,
                new DirectoryInfo(id).Name)) && File.Exists(string.Format(@"{0}\{1}\{1}.jar", _configuration.McVersions,
                new DirectoryInfo(id).Name));
        }
        public void GetVersions()
        {
            jsinit.ClearVersions();
            
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
                        if (_configuration.ApplicationConfiguration.SnapEnable == true)
                        {
                            
                            jsinit.AddVersions(text.Split(' ')[0], id, IsVersionInstalled(id));
                     
                        }
                        break;
                    case "old_beta":
                       
                        break;
                    case "old_alpha":
                        
                        break;
               
                    case "release":
                        jsinit.AddVersions(text.Split(' ')[0], id, IsVersionInstalled(id));
                        break;
                    default:
                       
                              jsinit.AddVersions(text, id, IsVersionInstalled(id));
                        
                        break;
                }
            }
            
                foreach (String version in ForgeVersions.versions)
                {

                    jsinit.AddVersions("Forge", version, IsVersionInstalled(version));
                   
                }



                
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
                
               if(jsinit.AlreadyInstalled)
            {
                jsinit.updateVersions();
            }
                
            }
        internal class MinecraftProcess
        {
            private readonly BroLauncher _launcherForm;
            private readonly Profile _profile;
            private readonly Process _minecraftProcess;
            //private LauncherFormOutput _output;
            private readonly StringBuilder _outputInfoBuilder;
            private readonly StringBuilder _outputErrorBuilder;

            public MinecraftProcess(Process minecraftProcess, BroLauncher launcherForm, Profile profile)
            {
                _launcherForm = launcherForm;
                _profile = profile;
                _minecraftProcess = minecraftProcess;
                _outputInfoBuilder = new StringBuilder();
                _outputErrorBuilder = new StringBuilder();
                
            }

            public void Launch()
            {
                if (_profile.LauncherVisibilityOnGameClose != Profile.LauncherVisibility.CLOSED)
                {
                    //_output = _launcherForm.AddOutputPage();
                    //_output.KillButton.Click += KillProcessButton_Click;
                    _minecraftProcess.Exited += MinecraftProcess_Exited;
                   
                    _minecraftProcess.ErrorDataReceived +=
                        (sender, args) =>
                        {
                            lock (this)
                            {
                                _outputErrorBuilder.Append(
                                    $"{(_outputErrorBuilder.Length == 0 ? string.Empty : Environment.NewLine)}[E] {args.Data}");
                            }
                        };
                }
                _minecraftProcess.Start();
                if (_profile.LauncherVisibilityOnGameClose == Profile.LauncherVisibility.CLOSED)
                {
                   
                    return;
                }
                _minecraftProcess.BeginOutputReadLine();
                _minecraftProcess.BeginErrorReadLine();
               
                if (_profile.LauncherVisibilityOnGameClose == Profile.LauncherVisibility.HIDDEN)
                {
                    
                }
            }

            private void KillProcessButton_Click(object sender, EventArgs e)
            {
                _minecraftProcess.Kill();
            }

            private void MinecraftProcess_Exited(object sender, EventArgs e)
            {

                jsinit.SelectVersion(jsinit.VersionList.Where(x => x.VersionData == _launcherForm._selectedProfile.SelectedVersion).First().VersionName + "," +
                    jsinit.VersionList.Where(x => x.VersionData == _launcherForm._selectedProfile.SelectedVersion).First().VersionData);
                    _launcherForm.Invoke((MethodInvoker)(() => _launcherForm.Show()));
                _launcherForm.Invoke((MethodInvoker)(() => _launcherForm.BringToFront()));

            }

            
        }

        public void UpdateUserList()
        {
            jsinit.ClearAccs();
            try
            {
                _userManager = File.Exists(_configuration.McLauncher + @"\users.json")
                    ? JsonConvert.DeserializeObject<UserManager>(
                        File.ReadAllText(_configuration.McLauncher + @"\users.json"))
                    : new UserManager();
                if (_userManager.Accounts.Count == 0)
                {
                    Random r = new Random();
                    User user = new User
                    {
                        Username = "BroLauncher" + r.Next(9) + r.Next(9) + (char)r.Next(97, 122) + (char)r.Next(97, 122),
                        Type = "offline"
                    };
                    _userManager.Accounts.Add(user.Username, user);
                    _selectedUser = user;
                    _userManager.SelectedUsername = user.Username;
                    SaveUsers();
                }
                jsinit.initUsers(_userManager.Accounts);
                jsinit.SelectUser(_userManager.SelectedUsername);
                
               
            }
            catch (Exception ex)
            {
               
                _userManager = new UserManager();
                SaveUsers();
            }
        }
            public void UpdateVersionListView()
        {
           
                jsinit.ClearVersions();
                GetVersions();
                //MessageBox.Show("herre");
                foreach (
                        VersionManifest version in
                        Directory.GetDirectories(_configuration.McVersions)
                            .Select(versionDir => new DirectoryInfo(versionDir))
                            .Where(VersionManifest.IsValid)
                            .Select(info => VersionManifest.ParseVersion(info, false)))
                    {
                   jsinit.AddVersions(version.ReleaseType,version.VersionId, true);
                       //versionsListView.Items.Add(version.VersionId, version.ReleaseType, version.ReleaseTime, version.LastUpdateTime,
                       //  version.AssetsIndex ?? "null", version.InheritsFrom ?? _configuration.Localization.Independent);
                }
                    string 
                        path = Path.Combine(_configuration.McVersions,
                            _selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile) + @"\");
                    
                    string state = _configuration.Localization.ReadyToLaunch;
                   // LaunchButton.Enabled = true;
                    if (!File.Exists(string.Format(@"{0}\{1}.json", path, _selectedProfile.SelectedVersion ??
                        GetLatestVersion(_selectedProfile))))
                    {
                        state = _configuration.Localization.ReadyToDownload;
                        if (_configuration.Arguments.OfflineMode)
                        {
                         //   LaunchButton.Enabled = false;
                        }
                if (jsinit.VersionList.Where(x => x.VersionData == _selectedProfile.SelectedVersion).Count() >= 1&& jsinit.VersionList.Where(x => x.Instaled==true).Count()>=1)
                {
                    jsinit.SelectVersion(jsinit.VersionList.Where(x => x.VersionData == _selectedProfile.SelectedVersion).First().VersionName + "," +
                    jsinit.VersionList.Where(x => x.VersionData == _selectedProfile.SelectedVersion).First().VersionData);
                }
                //   SelectedVersion.Text = string.Format(state, _selectedProfile.SelectedVersion ??
                //     GetLatestVersion(_selectedProfile));
                return;
                    }
                    if (!File.Exists(string.Format(@"{0}\{1}.jar", path, _selectedProfile.SelectedVersion ??
                        GetLatestVersion(_selectedProfile))) && VersionManifest.ParseVersion(new DirectoryInfo(path)).InheritsFrom == null)
                    {
                        state = _configuration.Localization.ReadyToDownload;
                        if (_configuration.Arguments.OfflineMode)
                        {
                          //  LaunchButton.Enabled = false;
                        }
                    }
            if (jsinit.VersionList.Where(x => x.VersionData == _selectedProfile.SelectedVersion).Count() >= 1 && jsinit.VersionList.Where(x => x.Instaled == true).Count() >= 1)
            {
                jsinit.SelectVersion(jsinit.VersionList.Where(x => x.VersionData == _selectedProfile.SelectedVersion).First().VersionName + "," +
                 jsinit.VersionList.Where(x => x.VersionData == _selectedProfile.SelectedVersion).First().VersionData);
            }


        }
        
        private void UpdateProfileList()
        {
            
            try
            {
                _profileManager =
                    ProfileManager.ParseProfile(_configuration.McDirectory + @"\launcher_profiles.json");
                if (!_profileManager.Profiles.Any())
                {
                    throw new FileLoadException("File is corrupted or contains no profiles.");
                }
            }
            catch (Exception ex)
            {

               
                if (File.Exists(_configuration.McDirectory + @"\launcher_profiles.json"))
                {
                    string fileName = $"launcher_profiles-{LinuxTimeStamp}.bak.json";
                  
                    File.Move(_configuration.McDirectory + @"\launcher_profiles.json",
                        _configuration.McDirectory + @"\" + fileName);
                }
                File.WriteAllText(_configuration.McDirectory + @"\launcher_profiles.json", new JObject {
                    {
                        "profiles", new JObject {
                            {
                                "Brolauncher", new JObject {
                                    {
                                        "name", "Brolauncher"
                                    }, {
                                        "allowedReleaseTypes", new JArray {
                                            "other"
                                        }
                                    }, {
                                        "launcherVisibilityOnGameClose", "keep the launcher open"
                                    }
                                }
                            },  
                        }
                    }, {
                        "selectedProfile", "Brolauncher"
                    }
                }.ToString());
                _profileManager = ProfileManager.ParseProfile(_configuration.McDirectory + @"\launcher_profiles.json");
                SaveProfiles();
            }
            
            foreach (KeyValuePair<string, Profile> keyValuePair in _profileManager.Profiles)
            {
                Profile profile = keyValuePair.Value;
                string allowedReleaseTypes = "release";
                if (profile.AllowedReleaseTypes != null)
                {
                    allowedReleaseTypes = profile.AllowedReleaseTypes.Aggregate(allowedReleaseTypes, (current, type) => current + $", {type}");
                }
                
            }
        }
        
        private void UpdateVersions()
        {
            if (_configuration.Arguments.OfflineMode)
            {
                
                if (File.Exists(_configuration.McVersions + @"\versions.json"))
                {
                    _versionList = RawVersionListManifest.ParseList(File.ReadAllText(_configuration.McVersions + @"\versions.json"));
                    return;
                }
                MessageBox.Show(_configuration.Localization.SomeFilesMissingMessage);
                Environment.Exit(0);
            }

            RawVersionListManifest remoteManifest = RawVersionListManifest.ParseList(new WebClient().DownloadString(
               new Uri("https://launchermeta.mojang.com/mc/game/version_manifest.json")));
            if (!Directory.Exists(_configuration.McVersions))
            {
                Directory.CreateDirectory(_configuration.McVersions);
            }
            if (!File.Exists(_configuration.McVersions + @"\versions.json"))
            {
                File.WriteAllText(_configuration.McVersions + @"\versions.json", remoteManifest.ToString());
                _versionList = remoteManifest;
                return;
            }
            
            RawVersionListManifest localManifest =
                RawVersionListManifest.ParseList(File.ReadAllText(_configuration.McVersions + @"\versions.json"));
           
            if (remoteManifest.Versions.Count == localManifest.Versions.Count &&
                remoteManifest.LatestVersions.Release == localManifest.LatestVersions.Release &&
                remoteManifest.LatestVersions.Snapshot == localManifest.LatestVersions.Snapshot)
            {
                _versionList = localManifest;
                
                return;
            }
            
            File.WriteAllText(_configuration.McVersions + @"\versions.json", remoteManifest.ToString());
            _versionList = remoteManifest;
        }
        private static bool CheckForInternetConnection()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("https://mc-monitoring.info/brolauncher/launcher/TestInet.html"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
              
                return false;
            }
        }
        public static DirectoryInfo GetExecutingDirectory()
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            return new FileInfo(location.AbsolutePath).Directory;
        }
        public static string GetExecutingDirectoryName()
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            return new FileInfo(location.AbsolutePath).Directory.FullName;
        }
        private void doubleclick(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)(() => this.Show()));
            notifyIcon1.Visible = false;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)(() => this.Show()));
            notifyIcon1.Visible = false;
            
        }
        bool userclose = true;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
                userclose = false;
                Close();
            
        }
       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing & userclose)
            {
                e.Cancel = true;
                notifyIcon1.Visible = true;
                Hide();
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }
        public void updateSettings()
        {
            jsinit.setCfg(_cfg.SnapEnable,_cfg.Hkey,_cfg.FullSceen);
        }
        public void trytorec()
        {
            Process pr = Process.GetCurrentProcess();
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (o, e) => 
            {
                bool kk = true;
                while(kk)
                {
                    Thread.Sleep(3000);
                    try
                    {
                        using (WebClient client = new WebClient())
                        {
                            using (client.OpenRead("https://mc-monitoring.info/brolauncher/launcher/TestInet.html"))
                            {
                                MessageBox.Show("Интернет соединение было установлено, перезапуск лаунчера");
                                Process.Start(_configuration.McLauncher+ "/brolauncher/BroLauncher2.exe");
                                pr.Kill();
                            }
                        }
                    }
                    catch
                    {
                        
                       
                    }
                }
            };
            bw.RunWorkerAsync();
                    
        }
        public BroLauncher(Configuration configuration)
        {
            
            this.Icon = Icon.ExtractAssociatedIcon(GetExecutingDirectoryName() + @"\1.ico");
            //this.notifyIcon1.Icon = new System.Drawing.Icon.ExtractAssociatedIcon(GetExecutingDirectoryName() + @"\1.ico");
            //this.notifyIcon1.Icon =Icon.ExtractAssociatedIcon(GetExecutingDirectoryName() + @"\1.ico");
            _configuration = configuration;
            _nicknameDictionary = new Dictionary<string, Tuple<string, DateTime>>();
            InitializeComponent();
           
            //this.Visible = false;
            _cfg = _configuration.ApplicationConfiguration;
            /*
           CheckUpdatesCheckBox.Checked = _cfg.CheckLauncherUpdates;
           DownloadAssetsBox.Checked = _cfg.SkipAssetsDownload;
           EnableMinecraftLogging.Checked = _cfg.EnableGameLogging;
           CloseGameOutput.Checked = _cfg.CloseTabAfterSuccessfulExitCode;
           */
            /*
            Text = $"{ProductName} {ProductVersion}";
            AboutVersion.Text = ProductVersion;
            AppendLog($"Application: {ProductName}");
            AppendLog($"Version: {ProductVersion}");
            AppendLog($"Loaded language: {_configuration.Localization.Name}({_configuration.Localization.LanguageTag})");
            AppendLog(new string('=', 12));
            AppendLog("System info:");
            AppendLog($"{new string(' ', 2)}Operating system:");
            AppendLog($"{new string(' ', 4)}OSFullName: {new ComputerInfo().OSFullName}");
            AppendLog($"{new string(' ', 4)}Build: {Environment.OSVersion.Version.Build}");
            AppendLog($"{new string(' ', 4)}Is64BitOperatingSystem: {Environment.Is64BitOperatingSystem}");
            AppendLog($"{new string(' ', 2)}Java path: '{Java.JavaInstallationPath}' ({Java.JavaBitInstallation}-bit)");
            AppendLog(new string('=', 12));
            */


            if (!_configuration.Arguments.OfflineMode)
            {
                _configuration.Arguments.OfflineMode = !CheckForInternetConnection();
            }
            if (_configuration.Arguments.OfflineMode)
                trytorec();

            if (!Directory.Exists(_configuration.McDirectory))
            {
                Directory.CreateDirectory(_configuration.McDirectory);
            }
            if (!Directory.Exists(_configuration.McLauncher))
            {
                Directory.CreateDirectory(_configuration.McLauncher);
            }
            updateSettings();

            this.notifyIcon1.DoubleClick += doubleclick;

            UpdateVersions();
            if (!_configuration.Arguments.OfflineMode)
            {

                ForgeVersions.init();
            }
            UpdateProfileList();
            _selectedProfile = _profileManager.GetProfile("Brolauncher");           
            UpdateVersionListView();
            UpdateUserList();
            GetVersions();
            
            try
            {
                jsinit.SelectVersion(_versionList.GetVersion(_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)).ReleaseType + "," + _versionList.GetVersion(_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)).VersionId);
            }catch(Exception e)
            {
                jsinit.SelectVersion("Forge," + _selectedProfile.SelectedVersion);
            }
          
            _profileManager.LastUsedProfile = "Brolauncher";
            SaveProfiles();
            FavListInit();
            _selectedProfile.ConnectionSettigs = null;


            
            //this.WindowState = FormWindowState.Minimized;
            
            InitializeChromium();
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            CefSharpSettings.FocusedNodeChangedEnabled = true;
            Cef.EnableHighDPISupport();
            
            chromeBrowser.RegisterJsObject("verAndAccManager", new VerAndAccManager(chromeBrowser, this));
            chromeBrowser.RegisterJsObject("servManager", new servManager(chromeBrowser, this));
            
            this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
        }
        public bool loading =true;
        protected override void OnClientSizeChanged(EventArgs e)
        {
            if (loading)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                base.OnClientSizeChanged(e);
            }
        }


        private void BroLauncher_Load(object sender, EventArgs e)
        {

        }
        public void FullWindow() { }
        
        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            
            // Note that if you get an error or a white screen, you may be doing something wrong !
            // Try to load a local file that you're sure that exists and give the complete path instead to test
            // for example, replace page with a direct path instead :
            // String page = @"C:\Users\SDkCarlos\Desktop\afolder\index.html";


            //String page = @"C:\Users\SDkCarlos\Desktop\artyom-HOMEPAGE\index.html";
            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "localfolder",
                DomainName = "cefsharp",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
            rootFolder: GetExecutingDirectoryName() + @"\site",
            hostName: "cefsharp",
            defaultPage: "index.html" // will default to index.html
        )
            });
            //settings.CefCommandLineArgs.Add("disable-direct-write","1");
            settings.CefCommandLineArgs.Add("disable-gpu", "1");
            //settings.WindowlessRenderingEnabled = true;

            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("localfolder://cefsharp/");
            chromeBrowser.RenderProcessMessageHandler = new RenderProcessMessageHandler();
            //chromeBrowser.CreateGraphics().InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            
            chromeBrowser.Dock = DockStyle.Fill;

            // Allow the use of local resources in the browser
            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.FileAccessFromFileUrls = CefState.Enabled;
            browserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            chromeBrowser.BrowserSettings = browserSettings;
            jsinit.chromium = chromeBrowser;
           
            Form form = this;
           
            chromeBrowser.FrameLoadEnd += (sender, args) =>
            {
                //Wait for the MainFrame to finish loading
                if (args.Frame.IsMain)
                {
                    //args.Frame.ExecuteJavaScriptAsync("alert('MainFrame finished loading');");
                    foreach (string command in jsinit.InitCommands)
                    {
                        //MessageBox.Show(command);
                        var script = command;
                        args.Frame.ExecuteJavaScriptAsync(command);

                    }
                    foreach (string command in servManager.InitCommands)
                    {
                        //MessageBox.Show(command);
                        var script = command;
                        args.Frame.ExecuteJavaScriptAsync(command);

                    }
                    
                    args.Frame.ExecuteJavaScriptAsync(jsinit.GenerateVersions());
                  
                    jsinit.AlreadyInstalled = true;
                    

                }
            };
            
        }
       public void hideform()
        {
            Invoke(new Action(() => { notifyIcon1.Visible = true; }));
           
            Invoke(new Action(() => { this.Hide(); }));
        }
       public void DirectInput(String text)
        {
            chromeBrowser.ExecuteScriptAsync(text);
        }
        private void BroLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveUsers();
            FavListSave();
            Cef.Shutdown();
        }
        public void DownloadVersion(string version)
        {
            if (ForgeVersions.versions.Contains(version))
            {
                string forgeversion = version;
                version = version.Split('-')[0];
                string filename;
                WebClient downloader = new WebClient();
                downloader.DownloadProgressChanged += (_, e) =>
                {
                    StatusBarValue = e.ProgressPercentage;
                };
                SetStatusBarVisibility(true);
                SetStatusBarMaxValue(100);
                StatusBarValue = 0;
                //UpdateStatusBarText(string.Format(_configuration.Localization.CheckingVersionAvailability, version));
                jsinit.InstallBarProgress("Проверка установленной верссии..", 10);
                string path = Path.Combine(_configuration.McVersions, version + @"\");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                if (!File.Exists($@"{path}\{version}.json") || _restoreVersion)
                {
                    if (!_configuration.Arguments.OfflineMode)
                    {
                        filename = version + ".json";
                        jsinit.InstallBarProgress("Загрузка верссии..", 10);
                        downloader.DownloadFileTaskAsync(
                            new Uri(_versionList.GetVersion(version)?.ManifestUrl ?? string.Format(
                                "https://s3.amazonaws.com/Minecraft.Download/versions/{0}/{0}.json", version)),
                            string.Format(@"{0}\{1}\{1}.json", _configuration.McVersions, version)).Wait();
                    }
                    else
                    {
                       // AppendException($"Unable to download version {version}: offline-mode enabled.");
                        return;
                    }
                }
                StatusBarValue = 0;
                VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                    new DirectoryInfo(_configuration.McVersions + @"\" + version), false);
                if ((!File.Exists($"{path}/{version}.jar") || _restoreVersion) &&
                    selectedVersionManifest.InheritsFrom == null)
                {
                    if (!_configuration.Arguments.OfflineMode)
                    {
                        filename = version + ".jar";
                       // UpdateStatusBarAndLog($"Downloading {filename}...", new StackFrame().GetMethod().Name);
                        downloader.DownloadFileTaskAsync(new Uri(selectedVersionManifest.DownloadInfo?.Client.Url
                                ??
                                string.Format(
                                    "https://s3.amazonaws.com/Minecraft.Download/versions/{0}/{0}.jar",
                                    version)),
                            string.Format("{0}/{1}/{1}.jar", _configuration.McVersions, version)).Wait();
                    }
                    else
                    {
                       // AppendException($"Unable to download version {version}: offline-mode enabled.");
                        return;
                    }
                }
                if (selectedVersionManifest.InheritsFrom != null)
                {
                    DownloadVersion(selectedVersionManifest.InheritsFrom);
                }
                jsinit.InstallBarProgress("Установка forge", 10);
                if (!File.Exists(_configuration.McVersions + "/" + forgeversion + "/"+ forgeversion + ".json"))
                {
                    McForgeVersion CurForge = new McForgeVersion(forgeversion);
                    //InstallationWindow installationWindow = new InstallationWindow(_configuration.McDirectory, cur, "1.14.4-forge28.0.102-1.14.4", "Forge", Java.JavaInstallationPath);
                    InstallationWindow installation = new InstallationWindow(_configuration.McDirectory, CurForge, forgeversion, "Forge", Java.JavaInstallationPath);
                    installation.Window_Loaded();
                }

            }
            else
            {
                string filename;
                WebClient downloader = new WebClient();
                downloader.DownloadProgressChanged += (_, e) =>
                {
                    StatusBarValue = e.ProgressPercentage;
                };
                SetStatusBarVisibility(true);
                SetStatusBarMaxValue(100);
                StatusBarValue = 0;
               // UpdateStatusBarText(string.Format(_configuration.Localization.CheckingVersionAvailability, version));
               // AppendLog($"Checking '{version}' version availability...");
                string path = Path.Combine(_configuration.McVersions, version + @"\");
                
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                if (!File.Exists($@"{path}\{version}.json") || _restoreVersion)
                {
                    if (!_configuration.Arguments.OfflineMode)
                    {
                        filename = version + ".json";
                       // UpdateStatusBarAndLog($"Downloading {filename}...", new StackFrame().GetMethod().Name);
                        downloader.DownloadFileTaskAsync(
                            new Uri(_versionList.GetVersion(version)?.ManifestUrl ?? string.Format(
                                "https://s3.amazonaws.com/Minecraft.Download/versions/{0}/{0}.json", version)),
                            string.Format(@"{0}\{1}\{1}.json", _configuration.McVersions, version)).Wait();
                    }
                    else
                    {
                       // AppendException($"Unable to download version {version}: offline-mode enabled.");
                        return;
                    }
                }
                StatusBarValue = 0;
                VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                    new DirectoryInfo(_configuration.McVersions + @"\" + version), false);
                if ((!File.Exists($"{path}/{version}.jar") || _restoreVersion) &&
                    selectedVersionManifest.InheritsFrom == null)
                {
                    if (!_configuration.Arguments.OfflineMode)
                    {
                        filename = version + ".jar";
                        //UpdateStatusBarAndLog($"Downloading {filename}...", new StackFrame().GetMethod().Name);
                        downloader.DownloadFileTaskAsync(new Uri(selectedVersionManifest.DownloadInfo?.Client.Url
                                ??
                                string.Format(
                                    "https://s3.amazonaws.com/Minecraft.Download/versions/{0}/{0}.jar",
                                    version)),
                            string.Format("{0}/{1}/{1}.jar", _configuration.McVersions, version)).Wait();
                    }
                    else
                    {
                      //  AppendException($"Unable to download version {version}: offline-mode enabled.");
                        return;
                    }
                }
                if (selectedVersionManifest.InheritsFrom != null)
                {
                    DownloadVersion(selectedVersionManifest.InheritsFrom);
                }
               // AppendLog($@"Finished checking {version} version avalability.");
            }
        }

        public string DownloadLibraries()
        {
            StringBuilder libraries = new StringBuilder();
            VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                new DirectoryInfo(_configuration.McVersions + @"\" +
                (_versionToLaunch ??
                    (_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)))));
            //MessageBox.Show(_versionToLaunch);
            SetStatusBarVisibility(true);
            StatusBarValue = 0;
            jsinit.InstallBarProgress("Проверка библиотек...",20);
            //UpdateStatusBarText(_configuration.Localization.CheckingLibraries);
            //AppendLog("Preparing required libraries...");
            Dictionary<DownloadEntry, bool> libsToDownload = new Dictionary<DownloadEntry, bool>();
            foreach (Lib a in selectedVersionManifest.Libs)
            {
                if (!a.IsForWindows())
                {
                    continue;
                }
                if (a.DownloadInfo == null)
                {
                    libsToDownload.Add(new DownloadEntry
                    {
                        Path = a.GetPath(),
                        Url = a.GetUrl()
                    }, false);
                    continue;
                }
                foreach (DownloadEntry entry in a.DownloadInfo?.GetDownloadsEntries(OS.WINDOWS))
                {
                    if (entry == null)
                    {
                        continue;
                    }
                    entry.Path = entry.Path ?? a.GetPath();
                    entry.Url = entry.Url ?? a.Url;
                    libsToDownload.Add(entry, entry.IsNative);
                }
            }
            SetStatusBarMaxValue(libsToDownload.Count + 1);
            int maxlen = libsToDownload.Keys.Count;
            //MessageBox.Show(maxlen.ToString());
            int step = 0;
            foreach (DownloadEntry entry in libsToDownload.Keys)
            {
                StatusBarValue++;
                if (!File.Exists(_configuration.McLibs + @"\" + entry.Path) ||
                    _restoreVersion)
                {
                    if (!_configuration.Arguments.OfflineMode)
                    {
                     //   UpdateStatusBarAndLog($"Downloading {entry.Path.Replace('/', '\\')}...");
                        string directory = Path.GetDirectoryName(_configuration.McLibs + @"\" + entry.Path);
                        step++;
                         int stepf = Convert.ToInt32(Math.Truncate(step* (20F /(float) maxlen)));
                        jsinit.InstallBarProgress("Загрузка библиотеки "+ entry.Url, 20+ stepf);
                        // AppendDebug("Url: " + (entry.Url ?? @"https://libraries.minecraft.net/" + entry.Path));
                        //  AppendDebug("DownloadDir: " + directory);
                        //  AppendDebug("LibPath: " + entry.Path.Replace('/', '\\'));
                        if (!File.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }
                        try
                        {
                            new WebClient().DownloadFile(entry.Url ?? @"https://libraries.minecraft.net/" + entry.Path,
                                _configuration.McLibs + @"\" + entry.Path);
                        }
                        catch (WebException ex)
                        {
                          //  AppendException("Downloading failed: " + ex.Message);
                            File.Delete(_configuration.McLibs + @"\" + entry.Path);
                            continue;
                        }
                        catch (Exception ex)
                        {
                          //  AppendException("Downloading failed: " + ex.Message);
                            continue;
                        }
                    }
                    else
                    {
                       // AppendException($"Unable to download {entry.Path}: offline-mode enabled.");
                    }
                }
                if (entry.IsNative)
                {
                  //  UpdateStatusBarAndLog($"Unpacking {entry.Path.Replace('/', '\\')}...");
                    using (ZipFile zip = ZipFile.Read(_configuration.McLibs + @"\" + entry.Path))
                    {
                        foreach (ZipEntry zipEntry in zip.Where(zipEntry => zipEntry.FileName.EndsWith(".dll")))
                        {
                            //AppendDebug($"Unzipping {zipEntry.FileName}");
                            try
                            {
                                zipEntry.Extract(_configuration.McDirectory + @"\natives\",
                                    ExtractExistingFileAction.OverwriteSilently);
                            }
                            catch (Exception ex)
                            {
                                //AppendException(ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    libraries.Append(_configuration.McLibs + @"\" + entry.Path.Replace('/', '\\') + ";");
                }
                //UpdateStatusBarText(_configuration.Localization.CheckingLibraries);
            }
            libraries.Append(string.Format(@"{0}\{1}\{1}.jar", _configuration.McVersions,
                selectedVersionManifest.GetBaseJar()));
            jsinit.InstallBarProgress("Проверка библиотек завершена", 40);
            return libraries.ToString();
        }

        public void DownloadAssets()
        {
            // UpdateStatusBarAndLog("Checking game assets...");
            jsinit.InstallBarProgress("Проверка ресурсов...", 40);
            VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                new DirectoryInfo(_configuration.McVersions + @"\" +
                    (_versionToLaunch ??
                        (_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)))));
            if (selectedVersionManifest.InheritsFrom != null)
            {
                selectedVersionManifest = selectedVersionManifest.InheritableVersionManifest;
            }
            string file = string.Format(@"{0}\assets\indexes\{1}.json", _configuration.McDirectory,
                selectedVersionManifest.AssetsIndex ?? "legacy");
            if (!File.Exists(file))
            {
                if (!Directory.Exists(Path.GetDirectoryName(file)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(file));
                }
                new WebClient().DownloadFile(selectedVersionManifest.GetAssetIndexDownloadUrl(), file);
            }
            AssetsManifest manifest = AssetsManifest.Parse(file);
            StatusBarValue = 0;
            SetStatusBarMaxValue(manifest.Objects.Select(pair => pair.Value.Hash.GetFullPath()).Count(filename => !File.Exists(_configuration.McDirectory + @"\assets\objects\" +
                filename) || _restoreVersion) + 1);
            int maxlen =manifest.Objects.Select(pair => pair.Value).Where(asset => !File.Exists(_configuration.McDirectory + @"\assets\objects\" +
                asset.Hash.GetFullPath())).Count();
            //MessageBox.Show(maxlen.ToString());
            int step = 0;
            foreach (Asset asset in manifest.Objects.Select(pair => pair.Value).Where(asset => !File.Exists(_configuration.McDirectory + @"\assets\objects\" +
                asset.Hash.GetFullPath()) || _restoreVersion))
            {
                string directory = _configuration.McDirectory + @"\assets\objects\" + asset.Hash.GetDirectoryName();
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                try
                {

                    // AppendDebug($"Downloading {asset.Hash}...");
                    step++;
                    int stepf = Convert.ToInt32(Math.Truncate(step* (50F /(float) maxlen)));
                    jsinit.InstallBarProgress("Загрузка ресурса "+ asset.AssociatedName, 40+ stepf);
                    new WebClient().DownloadFile(@"http://resources.download.minecraft.net/" + asset.Hash.GetFullPath(),
                        _configuration.McDirectory + @"\assets\objects\" + asset.Hash.GetFullPath());
                }
                catch (Exception ex)
                {
                  //  AppendException(ex.ToString());
                }
                StatusBarValue++;
            }
            jsinit.InstallBarProgress("Проверка ресурсов завершена", 90);
            if (selectedVersionManifest.AssetsIndex == null || selectedVersionManifest.AssetsIndex == "legacy")
            {
                StatusBarValue = 0;
                SetStatusBarMaxValue(manifest.Objects.Select(pair => pair.Value.AssociatedName)
                    .Count(
                        filename =>
                            !File.Exists(_configuration.McDirectory + @"\assets\virtual\legacy\" +
                                filename) || _restoreVersion) + 1);
                jsinit.InstallBarProgress("Конвертация ресурсов...", 90);
                foreach (Asset asset in manifest.Objects.Select(pair => pair.Value)
                    .Where(asset =>
                        !File.Exists(_configuration.McDirectory + @"\assets\virtual\legacy\" +
                            asset.AssociatedName) || _restoreVersion))
                {
                    string filename = _configuration.McDirectory + @"\assets\virtual\legacy\" + asset.AssociatedName;
                    try
                    {
                        if (!Directory.Exists(new FileInfo(filename).DirectoryName))
                        {
                            Directory.CreateDirectory(new FileInfo(filename).DirectoryName);
                        }
                      
                        File.Copy(_configuration.McDirectory + @"\assets\objects\" + asset.Hash.GetFullPath(),
                            filename);
                    }
                    catch (Exception ex)
                    {
                      //  AppendLog(ex.ToString());
                    }
                    StatusBarValue++;
                }
                jsinit.InstallBarProgress("Конвертация ресурсов завершена", 60);
            }
            SetStatusBarVisibility(false);
        }

       
    }
}
