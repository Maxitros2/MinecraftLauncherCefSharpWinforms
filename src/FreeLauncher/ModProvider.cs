using Forgefier;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using dotMCLauncher.Versioning;
namespace FreeLauncher
{
    public class ModProvider
    {
        [JsonProperty("disabledProviders")]
        private List<string> _disabledProviders { get; set; }

        [JsonProperty("promos")]
        private Dictionary<string, Dictionary<string, string>> _promoVersions { get; set; }

        [JsonProperty("liteloader")]
        public Dictionary<string, List<string>> LiteLoaderVersions { get; set; }

        [JsonProperty("optifine")]
        public Dictionary<string, List<string>> OptifineVersions { get; set; }

        [JsonProperty("ely")]
        public Dictionary<string, Lib> ElyLibs { get; set; }

        public Dictionary<string, List<McForgeVersion>> ForgeVersions { get; private set; }

    

        public bool TryGetPromoVersion(
          ModProvider.SupportedMods modification,
          string minecraftVersion,
          out string promoVersion)
        {
            try
            {
                string key;
                switch (modification)
                {
                    case ModProvider.SupportedMods.FORGE:
                        key = "forge";
                        break;
                    case ModProvider.SupportedMods.OPTIFINE:
                        key = "optifine";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(modification), (object)modification, (string)null);
                }
                if (this._promoVersions.ContainsKey(key) && this._promoVersions[key].ContainsKey(minecraftVersion))
                {
                    promoVersion = this._promoVersions[key][minecraftVersion];
                    return true;
                }
            }
            catch
            {
            }
            promoVersion = (string)null;
            return false;
        }

        public static Lib GetOptifineLib(string oprifineVersion)
        {
            Lib library = new Lib();
            library.Url="http://libraries.rulauncher.com/";
            library.Name="optifine:OptiFine:" + oprifineVersion;
            return library;
        }

        public enum SupportedMods
        {
            FORGE,
            OPTIFINE,
        }
    }
}
