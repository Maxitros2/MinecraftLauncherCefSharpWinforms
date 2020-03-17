using dotMCLauncher.Networking;
using dotMCLauncher.Profiling;
using dotMCLauncher.Versioning;
using FreeLauncher.Forge;
using Microsoft.VisualBasic.Devices;
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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = dotMCLauncher.Versioning.Rule;
using OS = dotMCLauncher.OperatingSystem;
using Ionic.Zip;
using dotMCLauncher.Resourcing;

namespace FreeLauncher.Forms
{

    public partial class MadForm : Form
    {
       
        #region Variables

        private readonly Configuration _configuration;
        private ProfileManager _profileManager;
        public RawVersionListManifest _versionList;
        public Profile _selectedProfile;
        private UserManager _userManager;
        private User _selectedUser;
        private readonly Dictionary<string, Tuple<string, DateTime>> _nicknameDictionary;
        private readonly ApplicationConfiguration _cfg;
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

       

        private void SetStatusBarValue(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action<int>(SetStatusBarValue), value);
            }
            else
            {
                progressBar1.Value = value;
            }
        }

        private void SetStatusBarMaxValue(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action<int>(SetStatusBarMaxValue), value);
            }
            else
            {
                progressBar1.Maximum = value;
            }
        }

        private void SetStatusBarVisibility(bool visible)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action<bool>(SetStatusBarVisibility), visible);
            }
            else
            {
                progressBar1.Visible = visible;
            }
        }
        #endregion
        List<Label> tabsdown;
        int selectedtab = 1;
        public void DownloadVersion(string version)
        {
            MessageBox.Show(version);
            if(CheatPage.cheatInfo.Clients.Where(x=>x.name==version.Split(' ')[0]).Count()>=1)
            {
                string forgeversion = version;
                version = version.Split(' ')[0];
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
                //jsinit.InstallBarProgress("Проверка установленной верссии..", 10);
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
                        //jsinit.InstallBarProgress("Загрузка верссии..", 10);
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
                //jsinit.InstallBarProgress("Установка forge", 10);
                if (!File.Exists(_configuration.McVersions + "/" + forgeversion + "/" + forgeversion + ".json"))
                {
                    McForgeVersion CurForge = new McForgeVersion(forgeversion);
                    //InstallationWindow installationWindow = new InstallationWindow(_configuration.McDirectory, cur, "1.14.4-forge28.0.102-1.14.4", "Forge", Java.JavaInstallationPath);
                    InstallationWindow installation = new InstallationWindow(_configuration.McDirectory, CurForge, forgeversion, "Forge", Java.JavaInstallationPath);
                    installation.Window_Loaded();
                   
                    
                }

            }
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
                //jsinit.InstallBarProgress("Проверка установленной верссии..", 10);
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
                        //jsinit.InstallBarProgress("Загрузка верссии..", 10);
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
                //jsinit.InstallBarProgress("Установка forge", 10);
                if (!File.Exists(_configuration.McVersions + "/" + forgeversion + "/" + forgeversion + ".json"))
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
        private string DownloadLibraries()
        {
            StringBuilder libraries = new StringBuilder();
            VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                new DirectoryInfo(_configuration.McVersions + @"\" +
                    (_versionToLaunch ??
                        (_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)))));
            SetStatusBarVisibility(true);
            StatusBarValue = 0;
            //UpdateStatusBarText(_configuration.Localization.CheckingLibraries);
           // AppendLog("Preparing required libraries...");
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
                    if (a.DownloadInfo.Classifiers?.ContainsKey("natives-windows") ?? false)
                    {
                        entry.Path = a.DownloadInfo.Classifiers["natives-windows"].Path ?? a.GetPath();
                        entry.Url = a.DownloadInfo.Classifiers["natives-windows"].Url ?? a.GetUrl();
                    }
                    else
                    {
                        entry.Path = entry.Path ?? a.GetPath();
                        entry.Url = entry.Url ?? a.Url;
                    }
                    entry.Path = entry.Path ?? a.GetPath();
                    entry.Url = entry.Url ?? a.Url;
                    libsToDownload.Add(entry, entry.IsNative);
                }
            }
            SetStatusBarMaxValue(libsToDownload.Count + 1);
            foreach (DownloadEntry entry in libsToDownload.Keys)
            {
                StatusBarValue++;
                if (!File.Exists(_configuration.McLibs + @"\" + entry.Path) ||
                    _restoreVersion)
                {
                    if (!_configuration.Arguments.OfflineMode)
                    {
                        //UpdateStatusBarAndLog($"Downloading {entry.Path.Replace('/', '\\')}...");
                        string directory = Path.GetDirectoryName(_configuration.McLibs + @"\" + entry.Path);
                        //AppendDebug("Url: " + (entry.Url ?? @"https://libraries.minecraft.net/" + entry.Path));
                       // AppendDebug("DownloadDir: " + directory);
                        //AppendDebug("LibPath: " + entry.Path.Replace('/', '\\'));
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
                            AppendException("Downloading failed: " + ex.Message);
                            File.Delete(_configuration.McLibs + @"\" + entry.Path);
                            continue;
                        }
                        catch (Exception ex)
                        {
                            AppendException("Downloading failed: " + ex.Message);
                            continue;
                        }
                    }
                    else
                    {
                        AppendException($"Unable to download {entry.Path}: offline-mode enabled.");
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
                                AppendException(ex.Message);
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
           // AppendLog("Finished checking libraries.");
            return libraries.ToString();
        }

        private void DownloadAssets()
        {
          //  UpdateStatusBarAndLog("Checking game assets...");
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
                    new WebClient().DownloadFile(@"http://resources.download.minecraft.net/" + asset.Hash.GetFullPath(),
                        _configuration.McDirectory + @"\assets\objects\" + asset.Hash.GetFullPath());
                }
                catch (Exception ex)
                {
                    AppendException(ex.ToString());
                }
                StatusBarValue++;
            }
           // AppendLog("Finished checking game assets.");
            if (selectedVersionManifest.AssetsIndex == null || selectedVersionManifest.AssetsIndex == "legacy")
            {
                StatusBarValue = 0;
                SetStatusBarMaxValue(manifest.Objects.Select(pair => pair.Value.AssociatedName)
                    .Count(
                        filename =>
                            !File.Exists(_configuration.McDirectory + @"\assets\virtual\legacy\" +
                                filename) || _restoreVersion) + 1);
              //  UpdateStatusBarAndLog("Converting assets...");
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
                      //  AppendDebug(
                         //   $"Converting '{asset.Hash.GetFullPath()}' to '{asset.AssociatedName}'");
                        File.Copy(_configuration.McDirectory + @"\assets\objects\" + asset.Hash.GetFullPath(),
                            filename);
                    }
                    catch (Exception ex)
                    {
                       // AppendLog(ex.ToString());
                    }
                    StatusBarValue++;
                }
               // AppendLog("Finished converting assets.");
            }
            SetStatusBarVisibility(false);
        }

        private void LaunchButton_Click()
        {
           
            
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += delegate {
                DownloadVersion(_versionToLaunch ?? (_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)));
                UpdateVersionListView();
            };
            bgw.RunWorkerCompleted += delegate {
                string libraries = string.Empty;
                BackgroundWorker bgw1 = new BackgroundWorker();
                bgw1.DoWork += delegate {
                    libraries = DownloadLibraries();
                };
                bgw1.RunWorkerCompleted += delegate {
                    BackgroundWorker bgw2 = new BackgroundWorker();
                    bgw2.DoWork += delegate {
                        
                            DownloadAssets();
                       
                        SetStatusBarVisibility(false);
                    };
                    bgw2.RunWorkerCompleted += delegate {
                        if (_restoreVersion)
                        {
                            //AppendLog($@"Successfully restored ""{_versionToLaunch}"" version.");
                            _restoreVersion = false;
                           // SetControlBlockState(false);
                            UpdateVersionListView();
                            _versionToLaunch = null;
                            return;
                        }
                        if (!_userManager.Accounts.ContainsKey(userControl11.label1.Text))
                        {
                            User user = new User
                            {
                                Username = userControl11.label1.Text,
                                Type = "offline"
                            };
                            _userManager.Accounts.Add(user.Username, user);
                            _selectedUser = user;
                        }
                        else
                        {
                            _selectedUser = _userManager.Accounts[userControl11.label1.Text];
                            if (_selectedUser.Type != "offline")
                            {
                                AuthManager am = new AuthManager
                                {
                                    ClientToken = _selectedUser.ClientToken,
                                    AccessToken = _selectedUser.AccessToken,
                                    Uuid = _selectedUser.Uuid
                                };
                                bool check = am.Validate();
                                if (!check)
                                {
                                    
                                    User user = new User
                                    {
                                        Username = userControl11.label1.Text,
                                        Type = "offline"
                                    };
                                    _selectedUser = user;
                                }
                                else
                                {
                                    Refresh refresh = new Refresh(_selectedUser.AccessToken, _selectedUser.ClientToken);
                                    refresh = (Refresh)refresh.DoPost();
                                    _selectedUser.UserProperties = (JArray)refresh.User?["properties"];
                                    _selectedUser.AccessToken = refresh.AccessToken;
                                    _userManager.Accounts[userControl11.label1.Text] = _selectedUser;
                                }
                            }
                        }
                        _userManager.SelectedUsername = _selectedUser.Username;
                        SaveUsers();
                        UpdateUserList();
                        VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                            new DirectoryInfo(Path.Combine(_configuration.McVersions, _versionToLaunch ?? (
                                _selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)))));
                        JObject properties = new JObject {
                            new JProperty("freelauncher", new JArray("cheeki_breeki_iv_damke"))
                        };
                        if (_selectedProfile.ConnectionSettigs != null)
                        {
                            selectedVersionManifest.ArgCollection.Add("server",
                                _selectedProfile.ConnectionSettigs.ServerIp);
                            selectedVersionManifest.ArgCollection.Add("port",
                                _selectedProfile.ConnectionSettigs.ServerPort.ToString());
                        }
                        string javaArguments = _selectedProfile.JavaArguments == null
                            ? string.Empty
                            : _selectedProfile.JavaArguments + " ";
                        if (_selectedProfile.WorkingDirectory != null &&
                            !Directory.Exists(_selectedProfile.WorkingDirectory))
                        {
                            Directory.CreateDirectory(_selectedProfile.WorkingDirectory);
                        }
                        string username;
                        if (_selectedUser.Type != "offline")
                        {
                            while (true)
                            {
                                try
                                {
                                    if (_nicknameDictionary.ContainsKey(_selectedUser.Uuid) && _nicknameDictionary[_selectedUser.Uuid].Item2 > DateTime.Now)
                                    {
                                        username = _nicknameDictionary[_selectedUser.Uuid].Item1;
                                        break;
                                    }
                                    if (_nicknameDictionary.ContainsKey(_selectedUser.Uuid) && _nicknameDictionary[_selectedUser.Uuid].Item2 <= DateTime.Now)
                                    {
                                        _nicknameDictionary.Remove(_selectedUser.Uuid);
                                    }
                                    _nicknameDictionary.Add(_selectedUser.Uuid, new Tuple<string, DateTime>(
                                        new Username
                                        {
                                            Uuid = _selectedUser.Uuid
                                        }.GetUsernameByUuid(),
                                        DateTime.Now.AddMinutes(30)));
                                    username = _nicknameDictionary[_selectedUser.Uuid].Item1;
                                    break;
                                }
                                catch (WebException ex)
                                {
                                    if ((int)((HttpWebResponse)ex.Response).StatusCode != 429)
                                    {
                                        AppendException($"An unhandled exception has occured while getting username by UUID:{Environment.NewLine}{ex}");
                                        username = userControl11.label1.Text;
                                        break;
                                    }
                                    Thread.Sleep(10000);
                                }
                            }
                        }
                        else
                        {
                            username = userControl11.label1.Text;
                        }
                        Dictionary<string, string> gameArgumentDictionary = new Dictionary<string, string> {
                            {
                                "auth_player_name", username
                            }, {
                                "version_name", _selectedProfile.ProfileName
                            }, {
                                "game_directory",
                                _selectedProfile.WorkingDirectory ?? _configuration.McDirectory
                            }, {
                                "assets_root", Path.Combine(_configuration.McDirectory, "assets")
                            }, {
                                "game_assets", Path.Combine(_configuration.McDirectory, "assets", "virtual", "legacy")
                            }, {
                                "assets_index_name", selectedVersionManifest.GetAssetsIndex()
                            }, {
                                "version_type", selectedVersionManifest.ReleaseType
                            }, {
                                "auth_session", $"token:{_selectedUser.ClientToken}:{_selectedUser.Uuid}" ?? "token:sample_token:sample_token"
                            }, {
                                "auth_access_token", _selectedUser.AccessToken ?? "sample_token"
                            }, {
                                "auth_uuid", _selectedUser.Uuid ?? "sample_token"
                            }, {
                                "user_properties",
                                _selectedUser.UserProperties?.ToString(Formatting.None) ??
                                properties.ToString(Formatting.None)
                            }, {
                                "user_type", _selectedUser.Type
                            }
                        };
                        Dictionary<string, string> jvmArgumentDictionary = new Dictionary<string, string> {
                            {
                                "natives_directory", Path.Combine(_configuration.McDirectory, "natives")
                            }, {
                                "launcher_name", Application.ProductName
                            }, {
                                "launcher_version", Application.ProductVersion
                            }, {
                                "classpath", libraries.Contains(' ') ? $"\"{libraries}\"" : libraries
                            }
                        };
                        string gameArguments, jvmArguments;
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
                            if (_selectedProfile.WindowInfo != null && (_selectedProfile.WindowInfo.Width != 854 || _selectedProfile.WindowInfo.Height != 480))
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
                                    _selectedProfile.WindowInfo?.Width.ToString());
                                gameArgumentDictionary.Add("resolution_height",
                                    _selectedProfile.WindowInfo?.Height.ToString());
                            }
                            gameArguments =
                                selectedVersionManifest.BuildArgumentsByGroup(ArgumentsGroupType.GAME, gameArgumentDictionary, requiredRules.ToArray());
                            jvmArguments = selectedVersionManifest.BuildArgumentsByGroup(ArgumentsGroupType.JVM, jvmArgumentDictionary, requiredRules.ToArray());
                        }
                        else
                        {
                            string nativesPath = Path.Combine(_configuration.McDirectory, "natives");
                            nativesPath = nativesPath.Contains(' ') ? $@"""{nativesPath}""" : nativesPath;
                            gameArguments = selectedVersionManifest.ArgCollection.ToString(gameArgumentDictionary);
                            jvmArguments = javaArguments +
                                $"-Djava.library.path={nativesPath} -cp {(libraries.Contains(' ') ? $@"""{libraries}""" : libraries)}";
                        }
                        ProcessStartInfo proc = new ProcessStartInfo
                        {
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                            FileName = _selectedProfile.JavaExecutable ?? Java.JavaExecutable,
                            StandardErrorEncoding = Encoding.UTF8,
                            WorkingDirectory = _selectedProfile.WorkingDirectory ?? _configuration.McDirectory,
                            Arguments =
                                $"{jvmArguments} {selectedVersionManifest.MainClass} {gameArguments}"
                        };
                        //AppendLog($"Command line executed: \"{proc.FileName}\" {proc.Arguments}");
                        new MinecraftProcess(new Process
                        {
                            StartInfo = proc,
                            EnableRaisingEvents = true
                        }, this,
                            _selectedProfile).Launch();
                        //AppendLog($"Version {selectedVersionManifest.VersionId} successfuly executed.");
                       // SetControlBlockState(false);
                        UpdateVersionListView();
                        _versionToLaunch = null;
                    };
                    bgw2.RunWorkerAsync();
                };
                bgw1.RunWorkerAsync();
            };
            bgw.RunWorkerAsync();
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
        private void UpdateProfileList()
        {
            
            string profilesPath = _configuration.McDirectory + @"\launcher_profiles.json";
            try
            {
                _profileManager =
                    ProfileManager.ParseProfile(profilesPath);
                if (!_profileManager.Profiles.Any())
                {
                    throw new FileLoadException("File is corrupted or contains no profiles.");
                }
            }
            catch (Exception ex)
            {
                //AppendException($"An exception has occurred while processing profiles:\n{ex.Message}\nA new profile list will be created.");
                if (File.Exists(profilesPath))
                {
                    string fileName = $"launcher_profiles-{LinuxTimeStamp}.bak.json";
                   // AppendLog("A copy of old profile list has been created: " + fileName);
                    File.Move(profilesPath,
                        Path.Combine(_configuration.McDirectory, fileName));
                }
                File.WriteAllText(profilesPath, new JObject {
                    {
                        "profiles", new JObject {
                            {
                                "Mad", new JObject {
                                    {
                                        "name", "Mad"
                                    }, {
                                        "allowedReleaseTypes", new JArray {
                                            "other"
                                        }
                                    }, {
                                        "launcherVisibilityOnGameClose", "keep the launcher open"
                                    }
                                }
                            }
                        }
                    }, {
                        "selectedProfile", "Mad"
                    }
                }.ToString());
                _profileManager = ProfileManager.ParseProfile(profilesPath);
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
                //profilesListView.Items.Add(keyValuePair.Key, profile.ProfileName, profile.SelectedVersion ?? "latest", allowedReleaseTypes, profile.LauncherVisibilityOnGameClose);
            }
        }
        private void TabClick (object sender, EventArgs o)
        {
            if (selectedtab != tabs1.selectedtab)
            {
                selectedtab = tabs1.selectedtab;
                switch (selectedtab)
                {
                    case 1:
                        cheatPage1.Visible = false;
                        serverPanel1.Visible = true;
                        break;
                    case 2:
                        cheatPage1.Visible = true;
                        serverPanel1.Visible = false;
                        break;
                }
            }
        }
        private void SaveProfiles()
        {
            File.WriteAllText(_configuration.McDirectory + @"\launcher_profiles.json", _profileManager.ToJson());
        }
        public MadForm(Configuration configuration)
        {
            _configuration = configuration;
            _nicknameDictionary = new Dictionary<string, Tuple<string, DateTime>>();
            InitializeComponent();
           
            _cfg = _configuration.ApplicationConfiguration;

            this.settingsMenu1.setPage31.madForm = this;
            

            if (!_configuration.Arguments.OfflineMode)
            {
                _configuration.Arguments.OfflineMode = !CheckForInternetConnection();
            }

            if (!Directory.Exists(_configuration.McDirectory))
            {
                Directory.CreateDirectory(_configuration.McDirectory);
            }
            if (!Directory.Exists(_configuration.McLauncher))
            {
                Directory.CreateDirectory(_configuration.McLauncher);
            }
            if(!_configuration.Arguments.OfflineMode)
            {
                ServHelper.getServs(this);
                ServerControl(1);
                this.cheatPage1.init();
                ForgeVersions.init();
              

            }
            settingsMenu1.setPage31._configuration = _configuration;
          
            UpdateVersions();

            UpdateProfileList();
            addNick("huy");
            settingsMenu1.setPage31.getMad(this);
            UpdateVersionListView();
            UpdateUserList();
            Focus();
            tabs1.tab1.Click += TabClick;
            tabs1.tab2.Click += TabClick;
            tabs1.tab3.Click += TabClick;
            _selectedProfile = _profileManager.Profiles.First().Value;
            settingsMenu1.VisibleChanged += (o, e2) =>
            {
                if (settingsMenu1.setPage31.selectedvesion != null)
                    _selectedProfile.SelectedVersion = settingsMenu1.setPage31.selectedvesion;
            };
            userControl11.panel9.Click += (o, e2) =>
            {
                settingsMenu1.Visible = true;

            };
                userControl11.panel8.Click += (o, e2) =>
              {
                  LaunchButton_Click();
              };
            userControl11.NicknamePanel2.Click += NicknamePanel2_Click;
            userControl11.BuildPanel2.Click += accPanel2_Click;
            userControl11.NicknamePanel2.MouseMove += buttonHover;
            userControl11.BuildPanel2.MouseMove += buttonHover;
            userControl11.NicknamePanel2.MouseLeave += TransBack;
            userControl11.BuildPanel2.MouseLeave += TransBack;
            serverPanel1.button1.Click += button1_Click;
            serverPanel1.roundedButton4.Click += roundedButton4_Click;
            serverPanel1.roundedButton1.Click += roundedButton1_Click;
            serverPanel1.roundedButton2.Click += roundedButton1_Click;
            serverPanel1.roundedButton3
                .Click += roundedButton1_Click;
            cheatPage1.Visible = false;
            settingsMenu1.Location = new Point(0, 0);
            TabClick(tabs1.tab1, new EventArgs());
            settingsMenu1.setPage31.getVersions();
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
        private void UpdateUserList()
        {
            bool flag = true;
            
           while (flag)
            {
                if (flowLayoutPanel1.Controls.Count == 1)
                    flag = false;
                if (flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1].Name != "panel11")
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                
            }

            
            try
            {
                _userManager = File.Exists(_configuration.McLauncher + @"\users.json")
                    ? JsonConvert.DeserializeObject<UserManager>(
                        File.ReadAllText(_configuration.McLauncher + @"\users.json"))
                    : new UserManager();
            }
            catch (Exception ex)
            {
                AppendException("Reading user list: an exception has occurred\n" + ex.Message);
                _userManager = new UserManager();
                SaveUsers();
            }
         

            if(_userManager.SelectedUsername==null)
            {
                
                Random r = new Random();
                _userManager.SelectedUsername="MadLauncher"+ r.Next(9) + r.Next(9) + (char)r.Next(97, 122) + (char)r.Next(97, 122);
                User user = new User
                {
                    Username = _userManager.SelectedUsername
                };
                _userManager.Accounts.Add(_userManager.SelectedUsername, user);
                SaveUsers();
            }
            foreach (String nick in _userManager.Accounts.Keys)
                addNick(nick);
           
            userControl11.label1.Text = _userManager.SelectedUsername;
        }

        private void AppendException(string v)
        {
            throw new NotImplementedException();
        }

        private void TransBack(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.Transparent;
        }
        private void buttonHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(55,72,124);
        }
        private void ServerControl(int page)
        {
           
            if (ServHelper.ServerList.Count <= 14)
            {
               serverPanel1.roundedButton3.Enabled = false;

            }
            serverPanel1.button1.Enabled = false;
           
            serverindex = page;
            if (serverindex >= 2)
            {
                serverPanel1.button1.Enabled = true;
            }
            else
            {
                serverPanel1.button1.Enabled = false;
            }
            if (serverindex <= 2)
            {
                serverPanel1.roundedButton4.Enabled = true;
            }
            else
            {
                serverPanel1.roundedButton4.Enabled = false;
            }
            if (serverindex == 2 & ServHelper.ServerList.Count <= 14)
            {
                serverPanel1.roundedButton3.Enabled = false;
            }

            this.serverPanel1.ServPanel.Controls.Clear();
            generateSrevers(page);
            
        }
        public void addNick(String nick)
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
            label.Name = "label2" + nick;
            label.Size = new System.Drawing.Size(67, 19);
            label.TabIndex = 2;
            label.Text = nick;
            this.flowLayoutPanel1.Controls.Add(panel);
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
            label.Name =  nick;
            label.Size = new System.Drawing.Size(67, 19);
            label.TabIndex = 2;
            label.Text = "Версия " + nick;
            panel.Click += (o, e) =>
                 {
                     userControl11.SelectedVersion.Text = label.Text;
                     this._selectedProfile.SelectedVersion = label.Name;
                 };
            this.flowLayoutPanel2.Controls.Add(panel);
        }
        private string GetLatestVersion(Profile profile)
        {
            return profile.AllowedReleaseTypes != null
                ? profile.AllowedReleaseTypes.Contains("snapshot")
                    ? _versionList.LatestVersions.Snapshot
                    : _versionList.LatestVersions.Release
                : _versionList.LatestVersions.Release;
        }
        private void UpdateVersionListView()
        {
          
            
               flowLayoutPanel2.Controls.Clear();
                foreach (
                    VersionManifest version in
                    Directory.GetDirectories(_configuration.McVersions)
                        .Select(versionDir => new DirectoryInfo(versionDir))
                        .Where(VersionManifest.IsValid)
                        .Select(info => VersionManifest.ParseVersion(info, false)))
                {
               addAcc(version.VersionId);
                }
                _selectedProfile = _profileManager.GetProfile("Mad");
                string path = Path.Combine(_configuration.McVersions,
                    _selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile));
                string state = _configuration.Localization.ReadyToLaunch;
                
                if (!File.Exists(Path.Combine(path, $"{_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)}.json")))
                {
                    state = _configuration.Localization.ReadyToDownload;
                    if (_configuration.Arguments.OfflineMode)
                    {
                        
                    }
                    userControl11.SelectedVersion.Text = "Версия " + string.Format(_selectedProfile.SelectedVersion ??
                        GetLatestVersion(_selectedProfile));
                    return;
                }
                if (!File.Exists(Path.Combine(path, $"{_selectedProfile.SelectedVersion ?? GetLatestVersion(_selectedProfile)}.jar")) && VersionManifest.ParseVersion(new DirectoryInfo(path)).InheritsFrom == null)
                {
                    state = _configuration.Localization.ReadyToDownload;
                    if (_configuration.Arguments.OfflineMode)
                    {
                        
                    }
                }
            userControl11.SelectedVersion.Text = "Версия " +string.Format(_selectedProfile.SelectedVersion??
                    GetLatestVersion(_selectedProfile));
         
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ServerControl(--serverindex);
        }
        int oldx;
        int oldY;
        private void MadForm_MouseMove(object sender, MouseEventArgs e)
        {

            

        }

        private void MadForm_DragDrop(object sender, DragEventArgs e)
        {
            this.Location =new Point(e.X,e.Y);

        }
        private void MadForm_MouseMove2(object o, MouseEventArgs e2)
        {
            this.MouseDown -= MadForm_MouseDown;
            if (e2.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X - oldx + e2.X, this.Location.Y-oldY+e2.Y);

            }
        }
        private void MadForm_MouseDown(object sender, MouseEventArgs e)
        {
           
            oldx = e.X;
             oldY = e.Y;

           
            this.MouseMove += MadForm_MouseMove2;
        }

        private void MadForm_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= MadForm_MouseMove2;
            this.MouseDown += MadForm_MouseDown;
        }
       
        

       

        private void MainPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MadForm_Shown(object sender, EventArgs e)
        {
            
            
            
        }

       

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
        bool nickshown = false;
        bool accShovn = false;
        private void NicknamePanel2_Click(object sender, EventArgs e)
        {
            nickshown = !nickshown;
           
                this.NickList.Visible = nickshown;
            
        }
        private void accPanel2_Click(object sender, EventArgs e)
        {
            accShovn = !accShovn;

            this.AccList.Visible = accShovn;

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void generateSrevers(int page)
        {if (_configuration.Arguments.OfflineMode)
                return;
            for(int i = (page-1)*7;i<page*7; i++)
            {
                if (i >= ServHelper.ServerList.Count)
                    return;
               // MessageBox.Show(i + " ");
                Panel serva = new Panel();
                Label ServNamea = new Label();
                PictureBox ServImagea = new PictureBox();
                Label ServVersiona = new Label();
                RoundedButton ServPlaya = new RoundedButton();
                ServPlaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
                ServPlaya.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
                ServPlaya.FlatAppearance.BorderSize = 0;
                ServPlaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                ServPlaya.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                ServPlaya.Location = new System.Drawing.Point(656+94-75, 3);
                ServPlaya.Name = ServHelper.ServerList.ElementAt(i).addres;
                ServPlaya.Size = new System.Drawing.Size(75, 38);
                ServPlaya.TabIndex = 13;
                ServPlaya.Text = "Играть";
                ServPlaya.UseVisualStyleBackColor = false;
                ServVersiona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                ServVersiona.AutoSize = true;
                ServVersiona.BackColor = System.Drawing.Color.Transparent;
                ServVersiona.Font = new System.Drawing.Font("PF BeauSans Pro", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                ServVersiona.Location = new System.Drawing.Point(60, 17);
                ServVersiona.Name = "ServVersion"+i;
                ServVersiona.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                ServVersiona.Size = new System.Drawing.Size(141, 19);
                ServVersiona.TabIndex = 15;
                ServVersiona.Text = ServHelper.ServerList.ElementAt(i).version;
                ServVersiona.TextAlign = System.Drawing.ContentAlignment.TopRight;
                ServImagea.BackColor = System.Drawing.Color.Transparent;
                ServImagea.Location = new System.Drawing.Point(3, 3);
                ServImagea.Name = "ServImage"+i;
                ServImagea.Size = new System.Drawing.Size(38, 38);
                ServImagea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                ServImagea.TabIndex = 14;
                ServImagea.TabStop = false;
                ServImagea.ImageLocation = ServHelper.ServerList.ElementAt(i).image.Replace(@"\", String.Empty);
                ServNamea.AutoSize = true;
                ServNamea.BackColor = System.Drawing.Color.Transparent;
                ServNamea.Font = new System.Drawing.Font("PF BeauSans Pro", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                ServNamea.Location = new System.Drawing.Point(47, 17);
                ServNamea.Name = "ServName"+i;
                ServNamea.Size = new System.Drawing.Size(141, 19);
                ServNamea.TabIndex = 2;
                ServNamea.Text = ServHelper.ServerList.ElementAt(i).name;
                serva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
                serva.Controls.Add(ServNamea);
                serva.Controls.Add(ServImagea);
                serva.Controls.Add(ServVersiona);
                serva.Controls.Add(ServPlaya);
                serva.Location = new System.Drawing.Point(0, 0);
                serva.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
                serva.Name = "serv1"+i;
                serva.Size = new System.Drawing.Size(753, 44);
                serva.TabIndex = 5;
                serva.Paint += new System.Windows.Forms.PaintEventHandler(this.serv1_Paint);
                this.serverPanel1.ServPanel.Controls.Add(serva);
            }
        }
        private void serv1_Paint(object sender, PaintEventArgs e)
        {

        }

        int serverindex = 1;
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Name.Last().ToString());
            
            ServerControl(index);
           

        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            ServerControl(++serverindex);
        }

        private void MadForm_Load(object sender, EventArgs e)
        {

        }

        

        private void tabs1_Load(object sender, EventArgs e)
        {

        }

        private void serverPanel1_Click(object sender, EventArgs e)
        {
            serverPanel1.Visible = true;
            serverPanel1.Enabled = true;
        }
    }
}
