using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.Zones
{
    public class Exhibit : IDataProvider
    {
        private readonly int? id = null;

        public string Name { get; set; }
        public string Zone { get; set; }
        public int Capacity { get; }
        public int Count { get; private set; }
        internal int Id => id.Value;


        /// <summary>
        /// Create new exhibit
        /// </summary>
        public Exhibit(string name, string zone, int capacity, int count)
        {
            Name = name;
            Zone = zone;
            Capacity = capacity;
            Count = count;
        }

        /// <summary>
        /// Read exhibit
        /// </summary>
        public Exhibit(int? id, string name, string zone, int capacity, int count)
            : this(name, zone, capacity, count)
        {
            this.id = id;
        }

        public override string ToString() => $"{Zone}-{Name}";

        public IParameterValueCollection GetParameterArgs()
        {
            IParameterValueCollection args = new ParameterValueCollection();
            args.Add("id", id);
            args.Add("name", Name);
            args.Add("zone", Zone);
            args.Add("capacity", Capacity);
            args.Add("count", Count);

            return args;
        }
    }
}
