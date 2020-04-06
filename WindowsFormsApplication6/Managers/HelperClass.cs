using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6.Managers
{
    class HelperClass
    {

        //RustIO 
        string RustIOServer = "playrust.io";
        

        public Models.server.Items LoadItems(string ServerName, string ServerPort, string sid)
        {

            // Get JSON
            string ItemsJSON = GetFile(RustIOServer, "80", "/map/itemnames.json", sid);

            // Load JSON world object list
            Models.server.Items Items = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.server.Items>(ItemsJSON);

            return Items;
        }

        public List<Models.server.Languages> LoadLanguages(string sid)
        {

            // Get JSON
            string LangJSON = GetFile(RustIOServer, "80", "/map/languages.json", sid);

            File.WriteAllText("languages.json", LangJSON);

            // Load JSON world object list
            List<Models.server.Languages> Languages = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.server.Languages>>(LangJSON);

            return Languages;
        }

        public Models.server.Status LoadStatus(string ServerName, string ServerPort, string sid)
        {

            // Get JSON
            string StatusJSON = GetFile(ServerName, ServerPort, "status.json", sid);

            // Load JSON world object list
            Models.server.Status Status = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.server.Status>(StatusJSON);

            return Status;
        }


        public Models.server.Config LoadConfig(string ServerName, string ServerPort, string sid)
        {

            // Get JSON
            string ConfigJSON = GetFile(ServerName, ServerPort, "config.json", sid);

            // Load JSON world object list
            Models.server.Config ConfigLst = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.server.Config>(ConfigJSON);

            return ConfigLst;
        }

        public List<Models.server.Recent> LoadRecent(string ServerName, string ServerPort, string sid)
        {

            // Get JSON
            string RecentJSON = GetFile(ServerName, ServerPort, "recent.json", sid);

            // Load JSON world object list
            List<Models.server.Recent> RecentLst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.server.Recent>>(RecentJSON);

            return RecentLst;
        }

        public List<Models.world.Deaths> LoadDeaths(string ServerName, string ServerPort, string sid)
        {

            // Get JSON
            string DeathsJSON = GetFile(ServerName, ServerPort, "deaths.json", sid);

            // Load JSON world object list
            List<Models.world.Deaths> MonumnetLst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.world.Deaths>>(DeathsJSON);

            return MonumnetLst;
        }

        public List<Models.world.Monument> LoadMonuments(string ServerName, string ServerPort, string sid)
        {

            // Get JSON
            string MonumentsJSON = GetFile(ServerName, ServerPort, "monuments.json", sid);   

            // Load JSON world object list
            List<Models.world.Monument> MonumnetLst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.world.Monument>>(MonumentsJSON);

            return MonumnetLst;
        }

        public string GetFile(string ServerName, string ServerPort, string filepath, string sid)
        {
            try
            {

                String URL = "http://" + ServerName + ":" + ServerPort + "/" + filepath;
                string text;

                HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);

                webRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;
                webRequest.Referer = GetFakeReferer(ServerName, ServerPort);
                webRequest.Headers.Add("sid", sid);

                WebResponse webResponse = webRequest.GetResponse();

                using (var reader = new System.IO.StreamReader(webResponse.GetResponseStream(), Encoding.GetEncoding(1256)))
                {
                    
                    text = reader.ReadToEnd();
                }

                return text;
            }
            catch (Exception ex)
            {

            }

            return string.Empty;
        }

        public Image GetMap(string ServerName, string ServerPort)
        {
            try
            {
                Image image = null;
                String MapURL = "http://" + ServerName + ":" + ServerPort + "/map.jpg";

                HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(MapURL);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;
                webRequest.Referer = GetFakeReferer(ServerName, ServerPort);

                WebResponse webResponse = webRequest.GetResponse();

                Stream stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream);

                webResponse.Close();

                return image;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public string GetFakeReferer(string ServerName, string ServerPort)
        {
            return "http://playrust.io/map/?" + ServerName + ":" + ServerPort;
        }

        public Bitmap RotateImage(Image image, float angle)
        {

            // Create empty bitmap
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);

            // Calc rotation
            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);
                g.Clear(Color.Transparent);
                g.DrawImage(image, 0, 0);
            }
            
            // Set Bitmap and transperent 
            rotatedBmp.MakeTransparent();

            // Return Bitmap
            return rotatedBmp;
        }
    }
}
