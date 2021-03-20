using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Threading;
using System.IO;
using System.Net;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        // Setting Form
        Settings SettingsForm = new Settings();

        // Server Data Sets
        List<Models.world.Monument> Monumentlst = new List<Models.world.Monument>();
        List<Models.world.Deaths> DeathLst = new List<Models.world.Deaths>();
        List<Models.world.@object> WorldObjects = new List<Models.world.@object>();
        Models.server.Status Status = new Models.server.Status();
        Models.server.Session Session = new Models.server.Session();

        // RustIO Data Sets
        List<Models.server.Languages> Languages = new List<Models.server.Languages>();
        List<Models.server.Recent> RecentLst = new List<Models.server.Recent>();
        Models.server.Items Items = new Models.server.Items();
        Models.server.Config Config = new Models.server.Config();

        // Websocket array
        List<ClientWebSocket> WSArray = new List<ClientWebSocket>();
        CancellationTokenSource cts = new CancellationTokenSource();

        // Map Manager
        Managers.MapManager MapMgr = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists("./map/img/") == false)
            {
                Directory.CreateDirectory("./map/img/");
            }
        }

        private void PingButton_Click(object sender, EventArgs e)
        {
            Managers.HelperClass HelperMgr = new Managers.HelperClass();
            Status = HelperMgr.LoadStatus(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, SettingsForm.SIDBox.Text);
            OutPutPingServer();
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private string RandomCharacters(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(255 * random.NextDouble())));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private void wsGreet()
        {
            try
            {
                var uri = "ws://" + SettingsForm.ServerNameBox.Text + ":" + SettingsForm.ServerPortBox.Text + "/ms";

                WSArray.Add(new ClientWebSocket());
                WSArray[0].Options.SetRequestHeader("Origin", "http://playrust.io");
                WSArray[0].Options.Cookies = new CookieContainer();
                
                // Build session cookie
                Cookie SIDCookie = new Cookie() 
                { 
                    Name = "sid",
                    Value = SettingsForm.SIDBox.Text,
                    Domain = SettingsForm.ServerNameBox.Text 
                };

                WSArray[0].Options.Cookies.Add(SIDCookie);

                // Connect to websocket
                WSArray[0].ConnectAsync(new Uri(uri), cts.Token);

                while (WSArray[0].State != WebSocketState.Open)
                {
                    //Wait for the socket to be connected and open
                }
                
                // Recive data
                Task.WhenAll(Receive(WSArray[0]));
            }
            catch (Exception ex)
            {
                OutPut.AppendText("Error: " + ex.Message + Environment.NewLine);
            }
        }

        private void wsGreetRCON()
        {
            try
            {
                var uri = "ws://" + SettingsForm.ServerNameBox.Text + ":" + SettingsForm.ServerPortBox.Text + "/cs";

                WSArray.Add(new ClientWebSocket());
                WSArray[1].Options.SetRequestHeader("Origin", "http://playrust.io");
                WSArray[1].Options.Cookies = new CookieContainer();

                // Build session cookie
                Cookie SIDCookie = new Cookie()
                {
                    Name = "sid",
                    Value = SettingsForm.SIDBox.Text,
                    Domain = SettingsForm.ServerNameBox.Text
                };

                WSArray[1].Options.Cookies.Add(SIDCookie);

                // Connect to websocket
                WSArray[1].ConnectAsync(new Uri(uri), cts.Token);

                while (WSArray[1].State != WebSocketState.Open)
                {
                    //Wait for the socket to be connected and open
                }

                // Recive data
                Task.WhenAll(Receive(WSArray[1]));
            }
            catch (Exception ex)
            {
                OutPut.AppendText("Error: " + ex.Message + Environment.NewLine);
            }
        }

        public void OutPutPingServer()
        {
           if (Status != null)
            { 
            OutPut.AppendText(
                "   Server is UP" + Environment.NewLine +
                "   CurrentVersion: " + Status.version.io + Environment.NewLine +
                "   CurrentTime: " + Status.env.time + Environment.NewLine +
                "   Players: " + Status.players + " / " + Status.maxplayers + Environment.NewLine +
                "   Sleepers: " + Status.sleepers + Environment.NewLine +
                "   Level:" + Status.level + Environment.NewLine +
                "   World Size: " + Status.world.size + Environment.NewLine +
                "   World Seed:" + Status.world.seed + Environment.NewLine);
            } else
            {
                OutPut.AppendText("   Server is not responding" + Environment.NewLine);
            }
        }

        public async Task Receive(ClientWebSocket webSocket)
        {
            byte[] buffer = new byte[1024];
            string wsTextResponse = string.Empty;

            while (webSocket.State != WebSocketState.Closed)
            {
                //WebSocket.CreateClientBuffer()
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cts.Token);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cts.Token);

                }
                else
                {
                    // Clean string
                    wsTextResponse = Uri.UnescapeDataString(Encoding.UTF8.GetString(buffer).Replace("\0", ""));

                    // Main loop
                    if (wsTextResponse.Length > 0)
                    {
                        String[] CommandLst = wsTextResponse.Split(new[] { ' ' }, 2);
                        DateTime timestamp = DateTime.Now;
                        Models.world.@object WorldObject = null;

                        // Records type
                        switch (CommandLst[0])
                        {
                            case "hello":
                                OutPut.AppendText(Environment.NewLine + "Server synced: Hello CMD");
                                break;
                            case "l":
                            case "s":
                            case "b":
                            case "p":
                            case "S":
                            case "h":
                                Models.world.@object InWorldObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.world.@object>(CommandLst[1]);
                                WorldObject = WorldObjects.Where(wo => wo.id == InWorldObject.id).FirstOrDefault();

                                if (WorldObject == null)
                                {
                                    // Give Object a Icon                                    
                                    InWorldObject = MapMgr.LoadWorldObjectImage(InWorldObject, CommandLst[0], MapImg);

                                    // Add Object
                                    WorldObjects.Add(InWorldObject);
                                }
                                else
                                {
                                    // Set Icon
                                    InWorldObject.Icon = WorldObject.Icon;

                                    // Update Object
                                    var ValidCustomers = WorldObjects.Where(c => c.id == InWorldObject.id).ToList();
                                    ValidCustomers.ForEach(wo => { wo.x = InWorldObject.x; wo.z = InWorldObject.z; wo.r = InWorldObject.r; wo.k = InWorldObject.k;});
                                }

                                MapMgr.DrawMovingWorldObjects(WorldObjects, MapImg, Status);
                                break;
                            case "player.death":
                                Models.player.death PlayerDeath = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.player.death>(CommandLst[1]);
                                OutPut.AppendText(Environment.NewLine + "{" + timestamp.ToString() + "}" + "[" + PlayerDeath.id + "] " + PlayerDeath.name + " was killed by " + PlayerDeath.lastDamage);
                                break;
                            case "player.chat":
                                Models.player.chat PlayerChat = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.player.chat>(CommandLst[1]);

                                // I think 0 means the websocket chat is disabled
                                if (PlayerChat.message == "0" | PlayerChat.message == "1")
                                {
                                    OutPut.AppendText(Environment.NewLine + "{" + timestamp.ToString() + "}" + PlayerChat.name + " says something");
                                }
                                else
                                {
                                    OutPut.AppendText(Environment.NewLine + "{" + timestamp.ToString() + "}" + PlayerChat.name + ": " + PlayerChat.message);
                                }
                                break;
                            case "player.spawn":
                                Models.player.spawn PlayerSpawn = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.player.spawn>(CommandLst[1]);
                                OutPut.AppendText(Environment.NewLine + "{" + timestamp.ToString() + "}" + "[" + PlayerSpawn.id + "] " + PlayerSpawn.name + " has respawn");
                                break;
                            case "player.connect":
                                Models.player.connect PlayerConnect = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.player.connect>(CommandLst[1]);
                                OutPut.AppendText(Environment.NewLine + "{" + timestamp.ToString() + "}" + "[" + PlayerConnect.id + "] " + PlayerConnect.name + " has connected");
                                break;
                            case "session":
                                Session = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.server.Session>(CommandLst[1]);
                                OutPut.AppendText(Environment.NewLine + "{" + timestamp.ToString() + "}" + "[Server] You are logged in as id:" + Session.id);
                                break;
                            default:
                                OutPut.AppendText(Environment.NewLine + "Server sent unknown record type: " + wsTextResponse);
                                break;
                        }

                        MapImg.Refresh();
                        buffer = new byte[1024];
                    }

                }
            }

        }

        public async Task Close(ClientWebSocket webSocket)
        {
            await webSocket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, webSocket.CloseStatusDescription, cts.Token);
        }

        public async Task Send(ClientWebSocket webSocket, string stringToSend)
        {
            if (webSocket.CloseStatus == WebSocketCloseStatus.NormalClosure)
            {
                OutPut.AppendText(Environment.NewLine + "Rcon websocket closed with msg: " + webSocket.CloseStatusDescription);
            }
            else
            {
                byte[] sendBytes = Encoding.UTF8.GetBytes(stringToSend + Environment.NewLine);
                var sendBuffer = new ArraySegment<byte>(sendBytes);

                await webSocket.SendAsync(sendBuffer, WebSocketMessageType.Text, false, cts.Token);
                OutPut.AppendText(Environment.NewLine + "Client: " + stringToSend);
            }

        }

        private void MapButton_Click(object sender, EventArgs e)
        {
            Managers.HelperClass HelperMgr = new Managers.HelperClass();
            MapImg.Image = HelperMgr.GetMap(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connect")
            {
                ConnectButton.Text = "Disconnect";

                // Create Helper Manager
                Managers.HelperClass HelperMgr = new Managers.HelperClass();

                // Load Status
                Status = HelperMgr.LoadStatus(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, SettingsForm.SIDBox.Text);

                // Get the base map image
                MapImg.Image = HelperMgr.GetMap(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text);

                //Load Map Manager
                MapMgr = new Managers.MapManager(MapImg.Image);

                // Load Monuments World Objects
                Monumentlst = HelperMgr.LoadMonuments(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, SettingsForm.SIDBox.Text);

                // Load Deaths
                DeathLst = HelperMgr.LoadDeaths(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, SettingsForm.SIDBox.Text);

                // Load Languages
                Languages = HelperMgr.LoadLanguages(SettingsForm.SIDBox.Text);

                // Load Languages
                Items = HelperMgr.LoadItems(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, SettingsForm.SIDBox.Text);

                // Load Config
                Config = HelperMgr.LoadConfig(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, SettingsForm.SIDBox.Text);

                // Load Recent Players
                RecentLst = HelperMgr.LoadRecent(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, SettingsForm.SIDBox.Text);

                // Draw Monuments World Objects
                MapImg = MapMgr.DrawMonuments(SettingsForm.ServerNameBox.Text, SettingsForm.ServerPortBox.Text, Monumentlst, MapImg, Status, OutPut);

                // Update base map with Monuments
                MapMgr.UpdateMapImg((Image)MapImg.Image.Clone());

                // Greet the web socket server
                wsGreet();

                // Greet the web socket server RCON
                wsGreetRCON();
            }
            else
            {

                Task.WhenAll(Close(WSArray[0]));
                WSArray[0] = new ClientWebSocket();
                ConnectButton.Text = "Connect";
            }
        }

        private void OutPut_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            OutPut.SelectionStart = OutPut.Text.Length;

            // scroll it automatically
            OutPut.ScrollToCaret();
        }            

        private void MapImg_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            OutPut.AppendText(Environment.NewLine + "[Click] x:" + coordinates.X + "   y:" + coordinates.Y);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            MapImg.Width = this.Width - 325;
            MapImg.Height = this.Height - 70;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Models.WebRcon test = new Models.WebRcon();
            test.Identifier = 1;
            test.Message = SendBox.Text;
            test.Name = "WebRcon";

            Task.WhenAll(Send(WSArray[1], SendBox.Text));
        }
    }
}
