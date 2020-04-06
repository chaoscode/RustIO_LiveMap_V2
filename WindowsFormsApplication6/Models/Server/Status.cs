using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6.Models.server
{
    public class World
    {
        public int size { get; set; }
        public int seed { get; set; }
    }

    public class Version
    {
        public string io { get; set; }
    }

    public class Env
    {
        public double time { get; set; }
    }

    public class Status
    {
        public string hostname { get; set; }
        public int players { get; set; }
        public int maxplayers { get; set; }
        public int sleepers { get; set; }
        public string level { get; set; }
        public World world { get; set; }
        public Version version { get; set; }
        public Env env { get; set; }
    }
}
