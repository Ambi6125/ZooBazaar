using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.Zones;

namespace ZooBazaarLogicLayer.Animals
{
    public class Species : IEquatable<Species>
    {
        private readonly int? id = null;
        private readonly string unitSize;
        private Exhibit exhibit;

        public string Name { get; }
        public string ScientificName { get; }
        public int Quantity { get; }

        /// <summary>
        /// Creates a new Species object, that is not yet registered
        /// </summary>
        public Species(string name, string scientificName, Exhibit e, string unitSize, int quantity)
        {
            this.unitSize = unitSize;
            Quantity = quantity;
            Name = name;
            ScientificName = scientificName;
            exhibit = e;
        }

        internal int Id => id.Value;

        /// <summary>
        /// Creates species object from database data
        /// </summary>
        public Species(int id, string name, string scientificName, Exhibit e, string unitSize, int quantity)
            :this(name, scientificName, e, unitSize, quantity)
        {
            this.id = id;
        }

        public void ChangeExhibit(Exhibit e)
        {
            exhibit = e;
        }


        /// <summary>
        /// Species are the same if their ids are equal
        /// </summary>
        public bool Equals(Species? other)
        {
            return id == other?.id;
        }
    }
}
