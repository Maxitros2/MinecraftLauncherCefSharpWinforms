using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FreeLauncher.Forms
{
    public static class Filters
    {
        public static String version;
        public static String filtermain;
        public static String filtermini;
        public static String search;
        public static bool inFavorite = false;
        public static bool changing = false;
        public static List<String> Fav= new List<string>();
    }
     class servManager
    {
        static List<string> current=new List<string>();
        private ChromiumWebBrowser chromeBrowser;
        private BroLauncher broLauncher;
        private static List<String> versions = new List<String>();
        public static List<String> InitCommands = new List<String>();
        public static int page = 1;
        public int inFav(object k)
        {

            if (Filters.Fav.Contains(k.ToString()))
                return 1;
            return 0;
            
        }
        public servManager(ChromiumWebBrowser chromeBrowser, BroLauncher broLauncher)
        {
            this.chromeBrowser = chromeBrowser;
            this.broLauncher = broLauncher;
        }
        

        public void inFavorite(object k)
        {
            
                viewFavorite();

           
                    
            

                
        }
        static bool whritin = false;
        public void viewFavorite()
        {
            if(whritin==true)
            {
                whritin = false;
                DirectInput("$('#cnt-servers2').addClass(\"hidden\");");
                DirectInput("$('#cnt-servers').removeClass(\"hidden\");");
                DirectInput("alotserv();");
                DirectInput("blockServers.updateFav();");
                return;
            }
            whritin = true;

            
            try
            {
                DirectInput("$('#cnt-servers').addClass(\"hidden\");");
                DirectInput("$('#cnt-servers2').removeClass(\"hidden\");");
                whritin = true;
                Filters.inFavorite = true;

                DirectInput("blockServers2.clear();");

                
                var request = (HttpWebRequest)WebRequest.Create("https://mc-monitoring.info/api/servers_by_ids");
                bool first = true;
                string postData = "";
                foreach (String id in Filters.Fav)
                {
                    if (first)
                    {
                        postData = "ids[]=" + Uri.EscapeDataString(id);
                        first = false;
                    }
                    else
                    {
                        postData += "&ids[]=" + Uri.EscapeDataString(id);
                    }
                }



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
                string resp = reader.ReadToEnd();
                JObject jobj = new JObject();
                jobj = JObject.Parse(resp);
                servhere = false;
               

                foreach (String id in Filters.Fav)
                {
                    JToken jobj2 = jobj["servers"][id];
                    if (!jobj2["launcher"].Equals("1"))
                    {
                        servhere = true;
                        DirectInput("blockServers2.add([{ \"addr\":\"" + jobj2["addr"].ToString() + "\", " +
                                "\"buy_color_url\":" + "\"" + jobj2["buy_color_url"].ToString() + "\"" + ", \"buy_score_url\":" + "\"" + jobj2["buy_score_url"].ToString() + "\"" + ", \"color\":"
                                + "\"" + jobj2["color"].ToString() + "\"" + ", \"icon_src\":" + "\"" + jobj2["icon_src"].ToString() + "\"" + ", \"id\":" +
                                "\"" + jobj2["id"].ToString() + "\"" + ", \"name\":" + "\"" + jobj2["name"].ToString() + "\"" + ", \"now_online\":" + "\"" + jobj2["now_online"].ToString() + "\""
                                + ", \"online\":" + "\"" + jobj2["online"].ToString() + "\"" + ", \"rating\":" + "\"" + jobj2["rating"].ToString() + "\""
                                 + ", \"score\":" + "\"" + jobj2["score"].ToString() + "\"" + ", \"short_desc\":" + "\"" + jobj2["short_desc"].ToString() + "\""
                                  + ", \"site\":" + "\"" + jobj2["site"].ToString() + "\""
                                 + ", \"slots\":" + "\"" + jobj2["slots"].ToString() + "\"" + ", \"url\":" + "\"" + jobj2["url"].ToString() + "\""
                                 + ", \"version\":" + "\"" + jobj2["version"].ToString() + "\"" + ", \"vote_url\":" + "\"" + jobj2["vote_url"].ToString() + "\" }]); ");
                    }
                }
            }
            catch (Exception c) { }
            if (servhere)
            { yesserv(); }
            else { noserv(); }
        }
        
        public void addToFav(object ido)
        {
             
                int id = Convert.ToInt32(ido);
                if(Filters.Fav.Contains(id.ToString()))
                {
                    Filters.Fav.Remove(id.ToString());
               
                
                }
                else
                {
                    Filters.Fav.Add(id.ToString());
                }
            broLauncher.FavListSave();




        }
        public void DirectInput(String com)
        {

            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            chromeBrowser.ExecuteScriptAsync(com);


        }
        public int getPage()
        {
            return page;
        }
        public void serchServer(String text)
        {
            if (text.Length == 0)
            {
                Filters.search = "";
                acceptFilters();
            }
            if (text.Length>=5)
            {
                Filters.search = text;
                acceptFilters();
            }
        }
        public void openUrl(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
        bool servhere = false;
        public void getServerInfo()
        {
            if (broLauncher._configuration.Arguments.OfflineMode)
                return;
            
            string MoodysWebstring = @"https://mc-monitoring.info/api/servers?page=" + page;
            if (Filters.version != null && Filters.version != "")
                MoodysWebstring += "&version=" + Filters.version;
            if (Filters.filtermain != null && Filters.filtermain != "")
                MoodysWebstring += "&type=" + "\"" + Filters.filtermain + "\"";
            if (Filters.filtermini != null && Filters.filtermini != "")
                MoodysWebstring += "&minigame=" + "\"" + Filters.filtermini + "\"";
            if (Filters.search != null && Filters.search != "")
                MoodysWebstring += "&search="  + Filters.search ;

            
            Uri MoodysWebAddress = new Uri(MoodysWebstring);
            HttpWebRequest request = WebRequest.Create(MoodysWebAddress) as HttpWebRequest;
            request.Method = "GET";

            string  results = string.Empty;
            HttpWebResponse response;
            bool resp=true;
            while(resp)
            try
            {
                using (response = request.GetResponse() as HttpWebResponse)
                {
                        resp = false;
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    JObject jobj = new JObject();
                    jobj = JObject.Parse(reader.ReadToEnd());
                        if (jsinit.AlreadyInstalled)
                        {
                            DirectInput("$('#cnt-servers2').addClass(\"hidden\");");
                            DirectInput("$('#cnt-servers').removeClass(\"hidden\");");
                        }
                        foreach (JObject jobj2 in jobj["servers"]["data"])
                    {
                        if (!jobj2["launcher"].ToString().Equals("1"))
                        {
                                servhere = true;
                                if (!jsinit.AlreadyInstalled)
                            {

                                InitCommands.Add("blockServers.add([{ \"addr\":\"" + jobj2["addr"].ToString() + "\", " +
                                    "\"buy_color_url\":" + "\"" + jobj2["buy_color_url"].ToString() + "\"" + ", \"buy_score_url\":" + "\"" + jobj2["buy_score_url"].ToString() + "\"" + ", \"color\":"
                                    + "\"" + jobj2["color"].ToString() + "\"" + ", \"icon_src\":" + "\"" + jobj2["icon_src"].ToString() + "\"" + ", \"id\":" +
                                    "\"" + jobj2["id"].ToString() + "\"" + ", \"name\":" + "\"" + jobj2["name"].ToString() + "\"" + ", \"now_online\":" + "\"" + jobj2["now_online"].ToString() + "\""
                                    + ", \"online\":" + "\"" + jobj2["online"].ToString() + "\"" + ", \"rating\":" + "\"" + jobj2["rating"].ToString() + "\""
                                     + ", \"score\":" + "\"" + jobj2["score"].ToString() + "\"" + ", \"short_desc\":" + "\"" + jobj2["short_desc"].ToString() + "\""
                                      + ", \"site\":" + "\"" + jobj2["site"].ToString() + "\""
                                     + ", \"slots\":" + "\"" + jobj2["slots"].ToString() + "\"" + ", \"url\":" + "\"" + jobj2["url"].ToString() + "\""
                                     + ", \"version\":" + "\"" + jobj2["version"].ToString() + "\"" + ", \"vote_url\":" + "\"" + jobj2["vote_url"].ToString() + "\" }]); ");

                                    current.Add("blockServers.add([{ \"addr\":\"" + jobj2["addr"].ToString() + "\", " +
                                    "\"buy_color_url\":" + "\"" + jobj2["buy_color_url"].ToString() + "\"" + ", \"buy_score_url\":" + "\"" + jobj2["buy_score_url"].ToString() + "\"" + ", \"color\":"
                                    + "\"" + jobj2["color"].ToString() + "\"" + ", \"icon_src\":" + "\"" + jobj2["icon_src"].ToString() + "\"" + ", \"id\":" +
                                    "\"" + jobj2["id"].ToString() + "\"" + ", \"name\":" + "\"" + jobj2["name"].ToString() + "\"" + ", \"now_online\":" + "\"" + jobj2["now_online"].ToString() + "\""
                                    + ", \"online\":" + "\"" + jobj2["online"].ToString() + "\"" + ", \"rating\":" + "\"" + jobj2["rating"].ToString() + "\""
                                     + ", \"score\":" + "\"" + jobj2["score"].ToString() + "\"" + ", \"short_desc\":" + "\"" + jobj2["short_desc"].ToString() + "\""
                                      + ", \"site\":" + "\"" + jobj2["site"].ToString() + "\""
                                     + ", \"slots\":" + "\"" + jobj2["slots"].ToString() + "\"" + ", \"url\":" + "\"" + jobj2["url"].ToString() + "\""
                                     + ", \"version\":" + "\"" + jobj2["version"].ToString() + "\"" + ", \"vote_url\":" + "\"" + jobj2["vote_url"].ToString() + "\" }]); ");

                                    /*
                                blockServers.add([{ "addr": "mc.papa-craft.ru:25565", "buy_color_url": "https:\/\/mc-monitoring.info\/buy\/color?server_id=6510", 
                                    "buy_score_url": "https:\/\/mc-monitoring.info\/buy\/votes?server_id=6510", 
                                    "color": "", "icon_src": "https:\/\/mc-monitoring.info\/img\/icons\/0wHITRZYpf.png", "id": "6510", 
                                    "name": "Papa Craft", "now_online": "1", "online": "17", "rating": "7", 
                                    "score": "100", 
                                    "short_desc": "\u0411\u0438\u0442\u0432\u0430\u041A\u043B\u0430\u043D\u043E\u0432,\u0411\u0438\u043B\u0434\u0411\u0430\u0442\u043B,\u0421\u043A\u0430\u0439\u0431\u043B\u043E\u043A,\u041C\u043E\u0431\u0410\u0440\u0435\u043D\u0430,\u0421\u043A\u0430\u0439\u0412\u0430\u0440\u0441,\u041A\u0440\u0443\u0442\u043E\u0435 \u0412\u044B\u0436\u0438\u0432\u0430\u043D\u0438\u0435,\u041E\u0440\u0443\u0436\u0438\u0435,\u041F\u0438\u0442\u043E\u043C\u0446\u044B", "site": "http:\/\/papa-craft.ru", 
                                    "slots": "2018", "url": "https:\/\/mc-monitoring.info\/server\/6510", 
                                    "version": "1.12.2", "vote_url": "https:\/\/mc-monitoring.info\/server\/vote\/6510" }]);
                            */
                                }
                                else
                            {
                                DirectInput("blockServers.add([{ \"addr\":\"" + jobj2["addr"].ToString() + "\", " +
                                    "\"buy_color_url\":" + "\"" + jobj2["buy_color_url"].ToString() + "\"" + ", \"buy_score_url\":" + "\"" + jobj2["buy_score_url"].ToString() + "\"" + ", \"color\":"
                                    + "\"" + jobj2["color"].ToString() + "\"" + ", \"icon_src\":" + "\"" + jobj2["icon_src"].ToString() + "\"" + ", \"id\":" +
                                    "\"" + jobj2["id"].ToString() + "\"" + ", \"name\":" + "\"" + jobj2["name"].ToString() + "\"" + ", \"now_online\":" + "\"" + jobj2["now_online"].ToString() + "\""
                                    + ", \"online\":" + "\"" + jobj2["online"].ToString() + "\"" + ", \"rating\":" + "\"" + jobj2["rating"].ToString() + "\""
                                     + ", \"score\":" + "\"" + jobj2["score"].ToString() + "\"" + ", \"short_desc\":" + "\"" + jobj2["short_desc"].ToString() + "\""
                                      + ", \"site\":" + "\"" + jobj2["site"].ToString() + "\""
                                     + ", \"slots\":" + "\"" + jobj2["slots"].ToString() + "\"" + ", \"url\":" + "\"" + jobj2["url"].ToString() + "\""
                                     + ", \"version\":" + "\"" + jobj2["version"].ToString() + "\"" + ", \"vote_url\":" + "\"" + jobj2["vote_url"].ToString() + "\" }]); ");
                                    current.Add("blockServers.add([{ \"addr\":\"" + jobj2["addr"].ToString() + "\", " +
                                    "\"buy_color_url\":" + "\"" + jobj2["buy_color_url"].ToString() + "\"" + ", \"buy_score_url\":" + "\"" + jobj2["buy_score_url"].ToString() + "\"" + ", \"color\":"
                                    + "\"" + jobj2["color"].ToString() + "\"" + ", \"icon_src\":" + "\"" + jobj2["icon_src"].ToString() + "\"" + ", \"id\":" +
                                    "\"" + jobj2["id"].ToString() + "\"" + ", \"name\":" + "\"" + jobj2["name"].ToString() + "\"" + ", \"now_online\":" + "\"" + jobj2["now_online"].ToString() + "\""
                                    + ", \"online\":" + "\"" + jobj2["online"].ToString() + "\"" + ", \"rating\":" + "\"" + jobj2["rating"].ToString() + "\""
                                     + ", \"score\":" + "\"" + jobj2["score"].ToString() + "\"" + ", \"short_desc\":" + "\"" + jobj2["short_desc"].ToString() + "\""
                                      + ", \"site\":" + "\"" + jobj2["site"].ToString() + "\""
                                     + ", \"slots\":" + "\"" + jobj2["slots"].ToString() + "\"" + ", \"url\":" + "\"" + jobj2["url"].ToString() + "\""
                                     + ", \"version\":" + "\"" + jobj2["version"].ToString() + "\"" + ", \"vote_url\":" + "\"" + jobj2["vote_url"].ToString() + "\" }]); ");

                                }
                            }
                    }
                };
            }catch(Exception e)
                
            { Thread.Sleep(500); resp = true; }
            page++;
            if (page <= 4 && servhere)
            {
                getServerInfo();
            }
           
        }
       
        public void setmainfilter(string filter)
        {
            Filters.filtermain = filter;
            Filters.filtermini = "";
            acceptFilters();
        }
        public void setminifilter(string filter)
        {
            Filters.filtermini = filter;
            Filters.filtermain = "";
            
            acceptFilters();
        }
        public void openDir()
        {
            
            Process.Start(broLauncher._configuration.McDirectory);
        }
        public void acceptFilters()
        {
           if(current.Count>=1&jsinit.AlreadyInstalled)
            {
                DirectInput("blockServers.clear();");
                foreach (string st in current)
                {
                    DirectInput(st);
                }
                current.Clear();
            }
            servhere = false;
            Filters.inFavorite = false;
            page = 1;
            DirectInput("blockServers.clear();");
            getServerInfo();
            if (servhere)
            {
                yesserv();
            }
            else {
                
                noserv(); }
            //jsinit.hideLoad();
        }
        public void noserv()
        {
            if (!jsinit.AlreadyInstalled)
            {
                InitCommands.Add("noserv();");
            }
            else
            {
                DirectInput("noserv();");
            }
        }
        
        public void yesserv()
        {
            if (!jsinit.AlreadyInstalled)
            {
                InitCommands.Add("alotserv();");
            }
            else
            {
                DirectInput("alotserv();");
            }
        }

        public void setVersion(String ver)
        {
            //jsinit.showLoad();
            Filters.version = ver;
            acceptFilters();
           // jsinit.hideLoad();
        }
        public void getVersionsList()
        {
            string ret = "[";
            foreach(string ver in versions)
            {
                ret = ret + "'" + ver + "',";
            }
            ret = ret.TrimEnd(',') + "]";
            if (jsinit.AlreadyInstalled)
            {
                DirectInput("blockVersions.add(" + ret + ");");

                DirectInput("blockVersions.bind();");
            }
            else
            {
                InitCommands.Add("blockVersions.add(" + ret + ");");

                InitCommands.Add("blockVersions.bind();");
            }
        }
        public void init()
        {
            if (!broLauncher._configuration.Arguments.OfflineMode)
            {
                try
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

                        File.WriteAllText(broLauncher._configuration.McLauncher + "/serversData.json", reader.ReadToEnd());
                    };
                    JObject jobj = new JObject();
                    jobj = JObject.Parse(File.ReadAllText(broLauncher._configuration.McLauncher + "/serversData.json"));
                    versions = jobj["data"]["versions"].ToObject<List<String>>();
                    //MessageBox.Show(jobj["data"]["versions"].ToString());
                    List<string> versions2 = new List<string>();
                    versions2.AddRange(versions);
                    int last = Convert.ToInt32(broLauncher.GetLatestVersion(broLauncher._selectedProfile).Split('.')[1]);
                    foreach (string st in versions2)
                    {
                        if (Convert.ToInt32(st.Split('.')[1]) > last)
                        {

                            versions.Remove(st);
                        }
                    }
                    versions = new List<string> { versions[0], versions[1], versions[2], versions[3], versions[4], versions[5], versions[6], versions[7], versions[8], versions[9] };
                }
                catch (Exception e) { };
               
                //Console.WriteLine(jobj["data"]["versions"].First);
            }
        }
    }
}
