using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6.Models.server
{
    class Config
    {
        public bool displayMonuments { get; set; }
        public bool displayBuildings { get; set; }
        public bool displayMortality { get; set; }
        public string defaultLanguage { get; set; }
        public bool disableAllies { get; set; }
    }
}
