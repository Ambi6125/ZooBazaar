using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.Animals;

namespace ZooBazaarLogicLayer.Zones
{
    public class Exhibit : IEquatable<Exhibit>, IDataProvider
    {
        private readonly int? id = null;

        public string Name { get; set; }
        public string Zone { get; set; }
        public int Capacity { get; set; }
        public int Count { get; private set; }
        internal int Id => id.Value;


        /// <summary>
        /// Create new exhibit
        /// </summary>
        public Exhibit(string name, string zone, int capacity, int count)
        {
            object[] parameters = { name, zone, capacity, count };
            string[] stringParameters = { name, zone };
            if(parameters.Any(obj => obj is null))
            {
                throw new ArgumentNullException();
            }
            else if(stringParameters.Any(str => string.IsNullOrWhiteSpace(str)))
            {
                throw new ArgumentException("Cannot be empty or whitespace");
            }

            Name = name;
            Zone = zone;
            Capacity = capacity;
            if(count > capacity)
            {
                throw new ArgumentOutOfRangeException("Too many animals");
            }
            else
            {
                Count = count;
            }
        }

        /// <summary>
        /// Read exhibit
        /// </summary>
        public Exhibit(int? id, string name, string zone, int capacity, int count)
            : this(name, zone, capacity, count)
        {
            this.id = id;
        }

        public bool Equals(Exhibit? other)
        {
            return id == other?.id;
        }

        public void ChangeZone(string zone)
        {
            if (Zones.IsValid(zone))
            {
                Zone = zone;
            }
            else
            {
                throw new ArgumentException("Unknown  Zone");
            }
        }

        public void ChangeCount(int count)
        {
            if(count > Capacity)
            {
                throw new ArgumentOutOfRangeException("Over Capacity");
            }
            else if(count < 0)
            {
                throw new ArgumentException("Cannot have a negative count");
            }
            else
            {
                Count = count;
            }
        }

        public override string ToString() => $"{Zone}-{Name}";

        public IParameterValueCollection GetParameterArgs()
        {
            IParameterValueCollection args = new ParameterValueCollection();
            args.Add("id", id);
            args.Add("zone", Zone);
            args.Add("name", Name);
            args.Add("capacity", Capacity);
            args.Add("count", Count);

            return args;
        }
    }
}
