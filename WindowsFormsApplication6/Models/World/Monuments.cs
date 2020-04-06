using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WindowsFormsApplication6.Models.world
{


    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

    public class Good
    {
        public string item { get; set; }
        public int itemAmount { get; set; }
        public string currency { get; set; }
        public int currencyAmount { get; set; }
        public int inStock { get; set; }
    }

    public class Monument
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public Position position { get; set; }
        public int rotation { get; set; }
        public List<Good> goods { get; set; }
    }
}
