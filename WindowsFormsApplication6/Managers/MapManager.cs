using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6.Managers
{
    class MapManager
    {
        string RustIOServer = "playrust.io";
        double offset = .01;

        public Image _defaultMapImg;

        public MapManager(Image defaultMapImg)
        {
            _defaultMapImg = (Image)defaultMapImg.Clone();
        }

        public void UpdateMapImg(Image Map)
        {
            _defaultMapImg = Map;
        }

        public PictureBox DrawMovingWorldObjects(List<Models.world.@object> WorldObjects, PictureBox MapImg, Models.server.Status ServerStatus)
        {
            // Reset Map
            MapImg.Image = (Image)_defaultMapImg.Clone();

            foreach (Models.world.@object WorldObject in WorldObjects)
            {
                
                // Draw World Objects
                DrawMovingWorldObject(WorldObject, MapImg, ServerStatus);
            }

            return MapImg;
        }

        public Image GetImage(string ServerName, string ServerPort, string ImgPath)
        {
            try
            {
                Image image = null;
                String ImgURL = "http://" + ServerName + ":" + ServerPort + ImgPath;

                HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(ImgURL);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                WebResponse webResponse = webRequest.GetResponse();

                using (Stream stream = webResponse.GetResponseStream())
                {              
                    image = Image.FromStream(stream);
                }
                    
                webResponse.Close();

                return image;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public PictureBox DrawMonuments(string ServerName, string ServerPort, List<Models.world.Monument> Monumentlst,  PictureBox MapImg, Models.server.Status ServerStatus, RichTextBox OutPut)
        {

            HelperClass HelpMgr = new HelperClass();

            if (Monumentlst != null)
                { 
                    OutPut.AppendText(Environment.NewLine + "Total World Monumnets:" + Monumentlst.Count.ToString());

                    foreach (Models.world.Monument Monument in Monumentlst)
                    {

                        // Output the load of image
                        OutPut.AppendText(Environment.NewLine + "Attempting to draw [" + Monument.name + "]: " + Monument.displayName);

                        string ImgPath = BuildMonumentsImagePath(Monument);
                        Image ObjectImg = null;

                        // Check if image is cached
                        if (File.Exists("." + ImgPath))
                        {
                            // Load file from cache
                            ObjectImg = Image.FromFile("." + ImgPath);
                        } else
                        {

                            // Try to get image for object
                            ObjectImg = GetImage(RustIOServer, "80", BuildMonumentsImagePath(Monument));

                            // Cache Image
                            ObjectImg.Save("." + ImgPath);
                        }
                
                        // Make sure its not null
                        if (ObjectImg != null)
                        {

                            // Draw Monuments
                            MapImg = DrawMonument(Monument, ObjectImg, MapImg, ServerStatus);
                        }

                    }
                }

            return MapImg;
        }

        public string BuildMonumentsImagePath(Models.world.Monument Monument)
        {
            string ImagePath = string.Empty;
            String[] NameLst = Monument.name.Split(new[] { ' ' }, 2);

            switch (NameLst[0])
            {
                case "OilrigAI":
                    ImagePath = "unknown.png";
                    break;
                case "OilrigAI2":
                    ImagePath = "unknown.png";
                    break;
                case "lighthouse":
                    ImagePath = "lighthouse.png";
                    break;
                case "cave_large_sewers_hard":
                    ImagePath = "cave.png";
                    break;
                case "cave_small_easy":
                    ImagePath = "cave.png";
                    break;
                case "cave_medium_easy":
                    ImagePath = "cave.png";
                    break;
                case "cave_small_hard":
                    ImagePath = "cave.png";
                    break;
                case "cave_medium_medium":
                    ImagePath = "cave.png";
                    break;
                case "cave_small_medium":
                    ImagePath = "cave.png";
                    break;
                case "power_sub_big_2":
                    ImagePath = "powersub.png";
                    break;
                case "power_sub_big_1":
                    ImagePath = "powersub.png";
                    break;
                case "power_sub_small_1":
                    ImagePath = "powersub.png";
                    break;
                case "power_sub_small_2":
                    ImagePath = "powersub.png";
                    break;
                case "swamp_a":
                    ImagePath = "swamp.png";
                    break;
                case "swamp_b":
                    ImagePath = "swamp.png";
                    break;
                case "swamp_c":
                    ImagePath = "swamp.png";
                    break;
                case "water_well_c":
                    ImagePath = "well.png";
                    break;
                case "water_well_d":
                    ImagePath = "well.png";
                    break;
                case "water_well_a":
                    ImagePath = "well.png";
                    break;
                case "water_well_e":
                    ImagePath = "well.png";
                    break;
                case "water_well_b":
                    ImagePath = "well.png";
                    break;
                case "warehouse":
                    ImagePath = "warehouse.png";
                    break;
                case "gas_station_1":
                    ImagePath = "gasstation.png";
                    break;
                case "mining_quarry_a":
                    ImagePath = "quarry.png";
                    break;
                case "supermarket_1":
                    ImagePath = "supermarket.png";
                    break;
                case "satellite_dish":
                    ImagePath = "dish.png";
                    break;
                case "sphere_tank":
                    ImagePath = "spheretank.png";
                    break;
                case "mining_quarry_b":
                    ImagePath = "quarry.png";
                    break;
                case "mining_quarry_c":
                    ImagePath = "quarry.png";
                    break;
                case "radtown_small_3":
                    ImagePath = "radtown.png";
                    break;
                case "bandit_town":
                    ImagePath = "outpost.png";
                    break;
                case "compound":
                    ImagePath = "outpost.png";
                    break;
                case "military_tunnel_1":
                    ImagePath = "militarytunnel.png";
                    break;
                case "water_treatment_plant_1":
                    ImagePath = "watertreatment.png";
                    break;
                case "airfield_1":
                    ImagePath = "airfield.png";
                    break;
                case "junkyard_1":
                    ImagePath = "junkyard.png";
                    break;
                case "trainyard_1":
                    ImagePath = "trainyard.png";
                    break;
                case "powerplant_1":
                    ImagePath = "powerplant.png";
                    break;
                case "excavator_1":
                    ImagePath = "excavator.png";
                    break;
                case "launch_site_1":
                    ImagePath = "launchsite.png";
                    break;
                case "harbor_2":
                    ImagePath = "harbor.png";
                    break;
                case "harbor_1":
                    ImagePath = "harbor.png";
                    break;
                case "powerline_a":
                    ImagePath = "powerline.png";
                    break;
                case "powerline_b":
                    ImagePath = "powerline_b.png";
                    break;
                case "powerline_c":
                    ImagePath = "powerline_b.png";
                    break;
                case "powerline_d":
                    ImagePath = "powerline_d.png";
                    break;
                case "powerline_pole_a":
                    ImagePath = "powerline.png";
                    break;
                case "vendingmachine.deployed":
                    ImagePath = "vendor.png";
                    break;
                case "npcvendingmachine_building":
                    ImagePath = "vendor.png";
                    break;
                case "npcvendingmachine_attire":
                    ImagePath = "vendor.png";
                    break;
                case "npcvendingmachine_weapons":
                    ImagePath = "vendor.png";
                    break;
                case "npcvendingmachine_components":
                    ImagePath = "vendor.png";
                    break;
                case "npcvendingmachine_resources":
                    ImagePath = "vendor.png";
                    break;
                case "npcvendingmachine_tools":
                    ImagePath = "vendor.png";
                    break;
                case "shopkeeper_vm_invis":
                    ImagePath = "vendor.png";
                    break;
                default:
                    ImagePath = "unknown.png";
                    break;
            }

            ImagePath = "/map/img/" + ImagePath;

            return ImagePath;
        }

        public PictureBox DrawMonument(Models.world.Monument Monument, Image MonumentImg, PictureBox MapImg, Models.server.Status ServerStatus)
        {


            // Scaling
            double rationy = (Convert.ToDouble(MapImg.Image.Height) / ServerStatus.world.size) - offset;
            double rationx = (Convert.ToDouble(MapImg.Image.Width) / ServerStatus.world.size) - offset;

            // Top + to Bottom -
            double y = MapCenter(ServerStatus) - Monument.position.z;

            // Left - to Right +
            double x = MapCenter(ServerStatus) + Monument.position.x;

            // Apply scale
            y = (y * rationy);
            x = (x * rationx);

            // Temp draw box
            using (Graphics gr = Graphics.FromImage(MapImg.Image))
            {

                // Build Rectangle
                RectangleF rect = new RectangleF(Convert.ToInt32(x), Convert.ToInt32(y), MonumentImg.Height, MonumentImg.Width);

                // Draw Solid Rectangle
                gr.DrawImage(MonumentImg, rect);

            }

            // Update map
            return MapImg;
        }

        public Models.world.@object LoadWorldObjectImage(Models.world.@object WorldObject, string WorldObjectType, PictureBox MapImg)
        {
            string ImgPath = string.Empty;

            // Data map
            switch (WorldObjectType)
            {
                case "b":
                    ImgPath = "/map/img/bradley.png";
                    break;
                case "S":
                    ImgPath = "/map/img/ship.png";
                    break;
                case "h":
                    ImgPath = "/map/img/heli.gif";
                    break;
                case "p":
                    ImgPath = "/map/img/plane.png";
                    break;
                case "l":
                    ImgPath = "/map/img/self.png";
                    break;
                case "s":
                    ImgPath = "unknown.png";
                    break;
                default:
                    ImgPath = "unknown.png";
                    break;
            }

            // Check if image is cached
            if (File.Exists("." + ImgPath))
            {
                // Load file from cache
                WorldObject.Icon = Image.FromFile("." + ImgPath);
                WorldObject.Icon2.Image = Image.FromFile("." + ImgPath);
            }
            else
            {
                // Try to get image for object
                WorldObject.Icon = GetImage(RustIOServer, "80", ImgPath);
                WorldObject.Icon2.Image = GetImage(RustIOServer, "80", ImgPath);

                // Cache Image
                WorldObject.Icon.Save("." + ImgPath);
            }

            WorldObject.Icon2.Parent = MapImg;
            WorldObject.Icon2.BackColor = Color.Transparent;
            WorldObject.Icon2.Size = new Size(WorldObject.Icon2.Image.Width, WorldObject.Icon2.Image.Height);
            WorldObject.Icon2.Location = new Point(1, 1);            
            WorldObject.Icon2.BringToFront();            

            if (WorldObjectType == "h")
            {
                WorldObject.Icon.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            }
            return WorldObject;
        }

        public PictureBox DrawMovingWorldObject(Models.world.@object worldobject, PictureBox MapImg, Models.server.Status ServerStatus)
        {
            // Scaling
            double rationy = (Convert.ToDouble(MapImg.Height) / ServerStatus.world.size) - offset;
            double rationx = (Convert.ToDouble(MapImg.Width) / ServerStatus.world.size) - offset;

            // Top + to Bottom -
            double y = MapCenter(ServerStatus) - worldobject.z;

            // Left - to Right +
            double x = MapCenter(ServerStatus) + worldobject.x;

            // Apply scale
            y = (y * rationy);
            x = (x * rationx);

            // Do rotation
            HelperClass Helpmgr = new HelperClass();

            // Move Picture Box
            // This breaks the GIF animation but I do not have a solution for this yet.
            worldobject.Icon2.Image = (Bitmap)Helpmgr.RotateImage((Bitmap)worldobject.Icon.Clone(), worldobject.r).Clone();            
            worldobject.Icon2.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));            
            worldobject.Icon2.BringToFront();

            // Update map
            return MapImg;
        }

        private double MapCenter(Models.server.Status ServerStatus)
        {
            // In-game cords zero is dead center. So take map size and div by 2. This is the MapCenter value.
            return (ServerStatus.world.size / 2);
        }
    }
}
