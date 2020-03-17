using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLauncher
{
    public class CheatVer
    {
        public string VerId;
        public string DownloadURL;
        public CheatVer(String VerId, String download)
        {
            this.VerId = VerId;
            this.DownloadURL = download;
        }
    }
    public class CheatClient
    {
        public string name;
        public string Desc;
        public List<CheatVer> Versions = new List<CheatVer>();
        public CheatClient(String name, List<CheatVer> vers, String desc)
        {
            this.name = name;
            this.Versions = vers;
            this.Desc = desc;
        }

    }
    public class CheatInfo
    {
        public List<CheatClient> Clients = new List<CheatClient>();
    }
}
