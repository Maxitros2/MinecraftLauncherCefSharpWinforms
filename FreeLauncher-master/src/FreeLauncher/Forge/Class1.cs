﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLauncher.Forge
{
    public class McForgeVersion : IComparable<McForgeVersion>, IEquatable<McForgeVersion>
    {
        public McVersion McVersion { get; }
        public Version Version { get; }
        public string Tag { get; }

        public JObject JObjectBuild
        {
            get { return _jObjectBuild; }
            set
            {
                _jObjectBuild = value;
                foreach (JToken strings in JObjectBuild["files"])
                {
                    switch (strings.Values<string>().ToArray()[1])
                    {
                        case "installer":
                            InstallationMethod = McForgeInstallationType.INSTALLER;
                            DownloadUrl = $"https://files.minecraftforge.net/maven/net/minecraftforge/forge/{FullVersion}/forge-{FullVersion}-installer.{strings.Values<string>().ToArray()[0]}";
                            return;
                        case "universal":
                        case "client":
                            InstallationMethod = McForgeInstallationType.LEGACY;
                            DownloadUrl = $"https://files.minecraftforge.net/maven/net/minecraftforge/forge/{FullVersion}/forge-{FullVersion}-{strings.Values<string>().ToArray()[1]}.{strings.Values<string>().ToArray()[0]}";
                            break;
                        default:

                            continue;
                    }
                }
            }
        }
        private JObject _jObjectBuild { get; set; }

        public McForgeInstallationType InstallationMethod { get; set; }
        public string DownloadUrl { get; private set; }

        public string ChangelogUrl =>
            $"https://files.minecraftforge.net/maven/net/minecraftforge/forge/{FullVersion}/forge-{FullVersion}-changelog.txt";

        public string VersionWithTag => Version + (Tag == null ? string.Empty : "-" + Tag);

        public string FullVersion => $"{McVersion}-{VersionWithTag}";

        public McForgeVersion(string version)
        {
            if(version.Contains("Nodus"))
            {
                this.InstallationMethod = McForgeInstallationType.INSTALLERV3;
            }

            string[] splittedVersion = version.Split('-');
            McVersion = new McVersion(splittedVersion[0]);
            Version = Version.Parse(splittedVersion[1]);
            string versnum = McVersion.Version.ToString().Replace(".", string.Empty);
            if (Convert.ToInt32(McVersion.Version.ToString().Split('.')[1]) >= 13)
            {
                this.InstallationMethod = McForgeInstallationType.INSTALLERV2;
            }
            if (Convert.ToInt32(McVersion.Version.ToString().Split('.')[1]) < 13)
            {
                this.InstallationMethod = McForgeInstallationType.INSTALLER;
            }
            if (splittedVersion.Length >= 3)
            {
                Tag = splittedVersion[2];
                this.DownloadUrl =
                    $"https://files.minecraftforge.net/maven/net/minecraftforge/forge/1.14.3-27.0.60/forge-1.14.3-27.0.60-installer.jar";
            }
        }

        public int CompareTo(McForgeVersion other)
        {
            int toReturn = McVersion.CompareTo(other.McVersion);

            if (toReturn == 0)
            {
                toReturn = Version.CompareTo(other.Version);
            }

            return toReturn;
        }

        public bool Equals(McForgeVersion other)
        {
            return CompareTo(other) == 0;
        }

        public override string ToString()
        {
            return FullVersion;
        }

        public override int GetHashCode()
        {
            return McVersion.GetHashCode() ^ Version.GetHashCode() ^ (Tag?.GetHashCode() ?? 1);
        }
    }

}
