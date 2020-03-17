using FreeLauncher.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeLauncher
{
    public class server
    {
        public string version, addres, image, name;
        //public int rating,score;
        public server(String version,String addres,String image,String name)

        {
            this.version = version;
            this.addres = addres;
            this.image = image;
            this.name = name;
           
        }
    }
    public static class ServHelper
    {
        public static List<server> ServerList= new List<server>();
        public static void getServs(MadForm form)
        {
          

            try
            {
                string MoodysWebstring = @"https://mc-monitoring.info/api/servers?page=" + 1;
                Uri MoodysWebAddress = new Uri(MoodysWebstring);
                HttpWebRequest request = WebRequest.Create(MoodysWebAddress) as HttpWebRequest;
                request.Method = "GET";

                string results = string.Empty;
                HttpWebResponse response;

                try
                {
                    using (response = request.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                        JObject jobj = new JObject();
                        jobj = JObject.Parse(reader.ReadToEnd());

                        foreach (JObject jobj2 in jobj["servers"]["data"])
                        {
                            if (!jobj2["launcher"].ToString().Equals("1")  & ServerList.Count<=21)
                            {
                                ServerList.Add(new server(jobj2["version"].ToString(), jobj2["addr"].ToString(), jobj2["icon_src"].ToString(), jobj2["name"].ToString()));

                            }
                        }
                    }
                               
                                
                }
                catch
                (Exception e2)
                { }
            }
            catch
            (Exception e)
            { }
        }
    }
}
