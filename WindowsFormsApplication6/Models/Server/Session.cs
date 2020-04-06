using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6.Models.server
{
    class Session
    {
        public string _id { get; set; }
        public string id { get; set; }
        public int owner { get; set; }
        public List<object> friends { get; set; }
        public List<object> shares { get; set; }
    }
}
