using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FreeLauncher
{
    public static class ForgeVersions
    {
        public static List<String> versions = new List<String>();
        public static void init()
        {
            XmlTextReader reader = new XmlTextReader("http://libraries.rulauncher.com/minecraftforge/metadata.xml");
            while (reader.Read())
            {
                if (reader.Value != null | !reader.Value.Contains("-"))
                    versions.Add(reader.Value);
            }
            versions.Reverse();
            List<String> versionsFixed = new List<String>();
            foreach (String version in versions)
            {
                bool flag = true;
                foreach (String versionf in versionsFixed)
                {
                    if (version.Split('-')[0] == versionf.Split('-')[0])
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag & version.Contains("-"))
                {
                    versionsFixed.Add(version);


                }
            }
            versions = versionsFixed;
        }
    }
}
