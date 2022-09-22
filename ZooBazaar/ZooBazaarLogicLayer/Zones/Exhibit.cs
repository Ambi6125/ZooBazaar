using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.Zones
{
    public class Exhibit
    {
        public string Name { get; set; }
        public string Zone { get; set; }
        public int Capacity { get; }
        public int Count { get; private set; }
        public override string ToString() => $"{Zone}-{Name}";
    }
}
