using dotMCLauncher.Versioning;
using Ionic.Zip;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeLauncher.Forge
{
    public partial class InstallationWindow
    {
       // private ModProvider _modProvider { get; }
        private string _mcDirectory { get; }
        private string _mcVersions { get; }
        private string _mcLibs { get; }
        private string _tempDir { get; set; }
        private McForgeVersion _mcForgeVersion { get; }
        private string _customVersionId { get; }
        private string _customProfileName { get; }
        private string _javaPath { get; }
        private readonly WebClient _webClient = new WebClient();
        private bool _allowQuit { get; set; }

        public InstallationWindow(string mcDirectory, McForgeVersion forgeVersion, string versionId, string profileName, string javaPath)
        {

            _mcDirectory = mcDirectory;
            _mcVersions = _mcDirectory + "/versions/";
            _mcLibs = _mcDirectory + "/libraries/";
            _mcForgeVersion = forgeVersion;
            _customVersionId = versionId;
            _customProfileName = profileName;
            _javaPath = javaPath;
            // foreach(string name in this.GetType().Assembly.GetManifestResourceNames())
            // MessageBox.Show(name);

        }

        public void Window_Loaded()
        {
            _tempDir = GetTempDirectory();
          //  jsinit.InstallBarProgress("Создание временной директории ", 10);
            //MessageBox.Show($"Created temp directory {_tempDir}.");
            this.BeginInstallation();
        }

        private delegate void MethodInvoker();

        private delegate void StringMethodInvoker(string arg);

        private delegate void BoolMethodInvoker(bool arg);

        private delegate void IntMethodInvoker(int arg);



        private void SetStatusLabel(string text)
        {

        }

        private void SetExitState(bool allow)
        {

        }

        private void SetProgressMax(int value)
        {

        }

        private void IncreaseProgressValue()
        {

        }

        private void BeginInstallation()
        {
            
                SetProgressMax(_mcForgeVersion.InstallationMethod == McForgeInstallationType.LEGACY ? 6 : 7);
                string mcVersions = _mcDirectory + "/versions/",
                    destDir = Path.Combine(mcVersions, _customVersionId + @"\"),
                   
                    originDir = Path.Combine(mcVersions, _mcForgeVersion.McVersion + @"\");
                string versionJar = Path.Combine(destDir, _customVersionId + ".jar"),
                    versionJson = Path.Combine(destDir, _customVersionId + ".json");
                DownloadVersion(_mcForgeVersion.McVersion.ToString());
                if (!Directory.Exists(destDir))
                {
                    Directory.CreateDirectory(destDir);
                }

                IncreaseProgressValue();
                if (_mcForgeVersion.InstallationMethod == McForgeInstallationType.INSTALLERV3)
                {
                Directory.CreateDirectory(_mcDirectory + "/versions/Nodus 1.8");
                File.Create(_mcDirectory + "/versions/Nodus 1.8/Nodus 1.8.json");
                versionJson = _mcDirectory + "/versions/Nodus 1.8/Nodus 1.8.json";
                //jsinit.InstallBarProgress("Загрузка инсталлера ", 10);
                new WebClient().DownloadFile(@"https://madlauncher.com/file/cheats/"+_customVersionId, Path.Combine(_tempDir, "installer.zip"));
                    JObject manifest = new JObject();

                    //jsinit.InstallBarProgress("Обработка инсталлера ", 15);
                    using (ZipFile zipInstaller = ZipFile.Read(Path.Combine(_tempDir, "installer.zip")))
                    {
                        using (IEnumerator<ZipEntry> enumerator = zipInstaller.GetEnumerator())
                        {
                            while (((IEnumerator)enumerator).MoveNext())
                            {
                                ZipEntry entry = enumerator.Current;
                                if (!(entry.FileName != "Nodus.json"))
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        entry.Extract((Stream)ms);
                                        ms.Position = 0L;
                                        StreamReader reader = new StreamReader((Stream)ms);
                                        manifest = JObject.Parse(reader.ReadToEnd());
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    using (ZipFile zipInstaller = ZipFile.Read(Path.Combine(_tempDir, "installer.zip")))
                    {
                        using (IEnumerator<ZipEntry> enumerator = zipInstaller.GetEnumerator())
                        {
                            while (((IEnumerator)enumerator).MoveNext())
                            {
                                ZipEntry entry = enumerator.Current;
                                if(entry.FileName.StartsWith("Nodus"))
                                    {
                                    entry.Extract(_mcVersions+"Nodus", ExtractExistingFileAction.OverwriteSilently);
                                }
                                if (entry.FileName.StartsWith("client"))
                                {
                                    entry.Extract(_mcLibs + @"net/minecraft/", ExtractExistingFileAction.OverwriteSilently);
                                }
                                if (entry.FileName.StartsWith("forge"))
                                {
                                    entry.Extract(_mcLibs + @"net\minecraftforge\forge\" + _customVersionId, ExtractExistingFileAction.OverwriteSilently);
                                }
                                entry = (ZipEntry)null;
                            }
                        }
                    }
                    manifest["versionInfo"]["id"] = _customVersionId;
                    manifest["versionInfo"]["type"] = "modified";
                    File.WriteAllText(versionJson, manifest["versionInfo"].ToString(Formatting.Indented));

                    manifest = (JObject)null;
                }

                if (_mcForgeVersion.InstallationMethod == McForgeInstallationType.INSTALLERV2)
                {
                    //jsinit.InstallBarProgress("Загрузка инсталлера ", 10);
                    new WebClient().DownloadFile(@"http://libraries.rulauncher.com/minecraftforge/forge/" + _customVersionId + "/forge-" + _customVersionId + "-installer.v2.jar", Path.Combine(_tempDir, "installer.zip"));
                    JObject manifest = new JObject();

                    //jsinit.InstallBarProgress("Обработка инсталлера ", 15);
                    using (ZipFile zipInstaller = ZipFile.Read(Path.Combine(_tempDir, "installer.zip")))
                    {
                        using (IEnumerator<ZipEntry> enumerator = zipInstaller.GetEnumerator())
                        {
                            while (((IEnumerator)enumerator).MoveNext())
                            {
                                ZipEntry entry = enumerator.Current;
                                if (!(entry.FileName != "install_profile.json"))
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        entry.Extract((Stream)ms);
                                        ms.Position = 0L;
                                        StreamReader reader = new StreamReader((Stream)ms);
                                        manifest = JObject.Parse(reader.ReadToEnd());
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    using (ZipFile zipInstaller = ZipFile.Read(Path.Combine(_tempDir, "installer.zip")))
                    {
                        using (IEnumerator<ZipEntry> enumerator = zipInstaller.GetEnumerator())
                        {
                            while (((IEnumerator)enumerator).MoveNext())
                            {
                                ZipEntry entry = enumerator.Current;

                                if (entry.FileName.StartsWith("client"))
                                {
                                    entry.Extract(_mcLibs + @"net/minecraft/", ExtractExistingFileAction.OverwriteSilently);
                                }
                                if (entry.FileName.StartsWith("forge"))
                                {
                                    entry.Extract(_mcLibs + @"net\minecraftforge\forge\" + _customVersionId, ExtractExistingFileAction.OverwriteSilently);
                                }
                                entry = (ZipEntry)null;
                            }
                        }
                    }
                    manifest["versionInfo"]["id"] = _customVersionId;
                    manifest["versionInfo"]["type"] = "modified";
                    File.WriteAllText(versionJson, manifest["versionInfo"].ToString(Formatting.Indented));

                    manifest = (JObject)null;
                }

                if (_mcForgeVersion.InstallationMethod == McForgeInstallationType.LEGACY)
                {
                    MessageBox.Show("Installing Forge for LEGACY version...");
                    MessageBox.Show("Downloading Forge...");

                    _webClient.DownloadFile("http://libraries.rulauncher.com/minecraftforge/forge/1.7.2-10.12.2.1132/forge-1.7.2-10.12.2.1132-installer.jar", Path.Combine(_tempDir, "temp.zip"));

                    MessageBox.Show($"Creating custom `{_customVersionId}` version from `{_mcForgeVersion.McVersion}`...");

                    if (File.Exists(versionJar))
                    {
                        File.Delete(versionJar);
                    }

                    MessageBox.Show(" Copying JAR...");

                    File.Copy(Path.Combine(originDir, _mcForgeVersion.McVersion + ".jar"), Path.Combine(destDir, _customVersionId + ".jar"));

                    if (File.Exists(versionJson))
                    {
                        File.Delete(versionJson);
                    }

                    MessageBox.Show(" Copying JSON...");

                    File.Copy(Path.Combine(originDir, _mcForgeVersion.McVersion + ".json"), Path.Combine(destDir, _customVersionId + ".json"));

                    IncreaseProgressValue();
                    MessageBox.Show("Patching JAR...");

                    using (ZipFile zip = ZipFile.Read(Path.Combine(_tempDir, "temp.zip")))
                    {
                        using (ZipFile zipVersion = ZipFile.Read(Path.Combine(destDir, _customVersionId + ".jar")))
                        {
                            foreach (ZipEntry entry in zip)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    entry.Extract(ms);
                                    ms.Position = 0;

                                    zipVersion.UpdateEntry(entry.FileName, ms);
                                    zipVersion.Save();
                                }
                            }

                            MessageBox.Show(" Removing META-INF...");
                            zipVersion.RemoveSelectedEntries("META-INF/*");
                            zipVersion.Save();
                        }
                    }

                    IncreaseProgressValue();
                    MessageBox.Show("Patching JSON...");

                    JObject jo = JObject.Parse(File.ReadAllText(Path.Combine(destDir, _customVersionId + ".json")));
                    jo["id"] = _customVersionId;
                    File.WriteAllText(Path.Combine(destDir, _customVersionId + ".json"), jo.ToString(Formatting.Indented));
                    IncreaseProgressValue();
                }

                if (_mcForgeVersion.InstallationMethod == McForgeInstallationType.INSTALLER)
                {
                    //jsinit.InstallBarProgress("Загрузка инсталлера...", 10);

                    _webClient.DownloadFile("http://libraries.rulauncher.com/minecraftforge/forge/" + _customVersionId + "/forge-" + _customVersionId + "-installer.jar", Path.Combine(_tempDir, "installer.zip"));
                    IncreaseProgressValue();
                    JObject jobject = new JObject();
                    //jsinit.InstallBarProgress("Обработка инсталлера...", 15);

                    using (ZipFile zipInstaller = ZipFile.Read(Path.Combine(_tempDir, "installer.zip")))
                    {
                        foreach (ZipEntry entry in zipInstaller)
                        {
                            if (entry.FileName == "install_profile.json")
                            {

                                using (MemoryStream ms = new MemoryStream())
                                {
                                    entry.Extract(ms);
                                    ms.Position = 0;
                                    StreamReader reader = new StreamReader(ms);
                                    jobject = JObject.Parse(reader.ReadToEnd());
                                }
                            }

                            if (entry.FileName.Contains(".jar"))
                            {
                                //MessageBox.Show(" Found Forge-universal.jar. Copying...");
                                entry.Extract(destDir, ExtractExistingFileAction.OverwriteSilently);
                            }
                        }
                    }

                    jobject["versionInfo"]["id"] = _customVersionId;
                    if (jobject["versionInfo"]["inheritsFrom"] == null)
                    {
                        //MessageBox.Show("Inheritable version not setted. Copying original JAR...");

                        if (File.Exists(versionJar))
                        {
                            File.Delete(versionJar);
                        }

                        File.Copy(Path.Combine(originDir, _mcForgeVersion.McVersion + ".jar"),
                            Path.Combine(destDir, _customVersionId + ".jar"));

                        using (ZipFile zipJar = ZipFile.Read(Path.Combine(destDir, _customVersionId + ".jar")))
                        {
                            //MessageBox.Show(" Removing META-INF...");
                            zipJar.RemoveSelectedEntries("META-INF/*");
                            zipJar.Save();
                        }


                        JObject jo = JObject.Parse(File.ReadAllText(Path.Combine(originDir, _mcForgeVersion.McVersion + ".json")));
                        foreach (JObject obj in jo["libraries"])
                        {
                            (jobject["versionInfo"]["libraries"] as JArray).Add(obj);
                        }
                    }

                    IncreaseProgressValue();

                    //jsinit.InstallBarProgress("Создание манифеста сборки...", 15);

                    File.WriteAllText(versionJson, jobject["versionInfo"].ToString(Formatting.Indented));

                    IncreaseProgressValue();
                    Lib forgeUniversal = new Lib
                    {
                        Name = jobject["install"]["path"].ToString()
                    };
                    if (!Directory.Exists(new FileInfo(_mcLibs + forgeUniversal.GetPath()).DirectoryName))
                    {
                        Directory.CreateDirectory(new FileInfo(_mcLibs + forgeUniversal.GetPath()).DirectoryName);
                    }

                    //jsinit.InstallBarProgress("Создание json...", 15);

                    File.Copy(Path.Combine(destDir, jobject["install"]["filePath"].ToString()),
                        _mcLibs + forgeUniversal.GetPath(), true);
                    File.Delete(Path.Combine(destDir, jobject["install"]["filePath"].ToString()));
                    IncreaseProgressValue();

                    string[] files = {
                        "xz-1.8.jar", "LibraryUnpacker.jar"
                    };
                    foreach (string filename in files)
                    {
                        using (Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"FreeLauncher.Fol.{filename}"))
                        {
                            Console.WriteLine(resource.ToString());
                            using (FileStream file = new FileStream(Path.Combine(_tempDir, filename), FileMode.Create, FileAccess.Write))
                            {
                                resource.CopyTo(file);
                            }
                        }
                    }

                    DownloadLibraries(_customVersionId.Split('-')[0]);



                }



                IncreaseProgressValue();
                //jsinit.InstallBarProgress("Обновление профилей...", 15);
                /*
                JObject profiles = JObject.Parse(File.ReadAllText(_mcDirectory + "/launcher_profiles.json"));
                profiles["selectedProfile"] = _customProfileName;
                if (profiles["profiles"][_customProfileName] != null)
                {
                    profiles["profiles"][_customProfileName]["lastVersionId"] = _customVersionId;
                }
                else
                {
                    (profiles["profiles"] as JObject).Add(_customProfileName, new JObject {
                        {"name", _customProfileName},
                        {"lastVersionId", _customVersionId}
                    });
                }

                File.WriteAllText(_mcDirectory + "/launcher_profiles.json", profiles.ToString(Formatting.Indented));
                */
                //jsinit.InstallBarProgress("Установка forge завершена", 15);

                IncreaseProgressValue();
                SetExitState(true);


            
            
        }

        private void DownloadVersion(string version)
        {
            string path = Path.Combine(_mcVersions, version + @"\");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //MessageBox.Show($"Validating files for Minecraft {version}...");


            if (!File.Exists($@"{path}\{version}.json"))
            {
                RawVersionListManifest versionList =
                    RawVersionListManifest.ParseList(_webClient.DownloadString(@"https://launchermeta.mojang.com/mc/game/version_manifest.json"));
                //MessageBox.Show(" Downloading JSON...");
                _webClient.DownloadFile(
                    new Uri(versionList.GetVersion(version)?.ManifestUrl ?? string.Format(
                                "https://s3.amazonaws.com/Minecraft.Download/versions/{0}/{0}.json", version)),
                    string.Format(@"{0}\{1}\{1}.json", _mcVersions, version));
            }

            VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                new DirectoryInfo(_mcVersions + @"\" + version), false);
            if ((!File.Exists($"{path}/{version}.jar")) && selectedVersionManifest.InheritsFrom == null)
            {
                MessageBox.Show(" Downloading JAR...");
                _webClient.DownloadFile(new Uri(selectedVersionManifest.DownloadInfo?.Client.Url
                                                ?? string.Format(
                                                    "https://s3.amazonaws.com/Minecraft.Download/versions/{0}/{0}.jar",
                                                    version)),
                    string.Format("{0}/{1}/{1}.jar", _mcVersions, version));
            }

            if (selectedVersionManifest.InheritsFrom != null)
            {
                DownloadVersion(selectedVersionManifest.InheritsFrom);
            }
        }

        private void DownloadLibraries(string version)
        {
            VersionManifest selectedVersionManifest = VersionManifest.ParseVersion(
                new DirectoryInfo(_mcVersions + @"\" + version));
            Dictionary<DownloadEntry, bool> libsToDownload = new Dictionary<DownloadEntry, bool>();
            //MessageBox.Show("Validating libraries...");

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

                foreach (DownloadEntry entry in a.DownloadInfo?.GetDownloadsEntries(dotMCLauncher.OperatingSystem.WINDOWS))
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

            foreach (DownloadEntry entry in libsToDownload.Keys)
            {
                if (File.Exists(_mcLibs + @"\" + entry.Path))
                {
                    continue;
                }
                //MessageBox.Show($"Processing {entry.Path}...");
                string directory = Path.GetDirectoryName(_mcLibs + @"\" + entry.Path);
                if (!File.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                try
                {
                    if (entry.Url != null && entry.Url.Contains("minecraftforge"))
                    {
                        //MessageBox.Show(" Downloading compressed library...");
                        try
                        {
                            _webClient.DownloadFile(entry.Url + ".pack.xz",
                                _mcLibs + @"\" + entry.Path + ".pack.xz");
                            MessageBox.Show(" Decompressing with external process...");
                            Process process = new Process
                            {
                                StartInfo = {
                                    RedirectStandardOutput = true,
                                    UseShellExecute = false,
                                    CreateNoWindow = true,
                                    WorkingDirectory = _tempDir,
                                    FileName = _javaPath,
                                    Arguments =
                                        "-cp \"xz-1.8.jar;LibraryUnpacker.jar\" ru.dedepete.forgefier.LibraryUnpacker " +
                                        $"\"{_mcLibs + @"\" + entry.Path + ".pack.xz"}\" \"{_mcLibs + @"\" + entry.Path}\""
                                }
                            };
                            process.Start();
                            string output = process.StandardOutput.ReadToEnd();
                            process.WaitForExit();
                            MessageBox.Show($"  Process exited with code {process.ExitCode}.");
                            if (process.ExitCode != 0)
                            {
                                MessageBox.Show($"  Output:\n{output}");
                            }

                            MessageBox.Show(" Removing .PACK.XZ...");
                            File.Delete(_mcLibs + @"\" + entry.Path + ".pack.xz");
                            continue;
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show($" Failed to download compressed library: {exception.Message}");
                        }
                    }

                    MessageBox.Show(" Downloading library...");
                    _webClient.DownloadFile(entry.Url ?? @"https://libraries.minecraft.net/" + entry.Path,
                        _mcLibs + @"\" + entry.Path);
                }
                catch (WebException exception)
                {
                    MessageBox.Show($" Failed to download library: {exception.Message}");
                    MessageBox.Show(" Removing corrupted file...");
                    File.Delete(_mcLibs + @"\" + entry.Path);
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_allowQuit)
            {
                e.Cancel = true;
            }

            Directory.Delete(_tempDir, true);
        }

        private static string GetTempDirectory()
        {
            string path = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName()));

            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }

            Directory.CreateDirectory(path);
            return path;
        }
    }
}


