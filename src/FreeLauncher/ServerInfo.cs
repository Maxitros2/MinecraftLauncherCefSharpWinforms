using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FreeLauncher
{
    static class ServerInfos
    {
        public static List<String> versions = new List<String>();
        public static Dictionary<String,String> Filters = new Dictionary<String,String>();
        public static void update(String path)
        {
            string MoodysWebstring = @"https://mc-monitoring.info/api/filters";
            Uri MoodysWebAddress = new Uri(MoodysWebstring);
            HttpWebRequest request = WebRequest.Create(MoodysWebAddress) as HttpWebRequest;
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;

            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

                File.WriteAllText(path + @"\serversinfo.json", reader.ReadToEnd());
            };
            JObject jobj = new JObject();
            jobj = JObject.Parse(File.ReadAllText(path + @"\serversinfo.json"));

            versions = jobj["data"]["versions"].ToObject<List<String>>();
           

        }
    }
}
