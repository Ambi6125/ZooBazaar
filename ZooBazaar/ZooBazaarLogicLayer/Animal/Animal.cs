using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.Animals
{
    
    public class Animal : IEquatable<Animal>, IDataProvider
    {
        #region internals
        internal static string[] allowedStatuses = { "In zoo", "Deceased", "Transferred", "Released" };
        #endregion



        private readonly int? id = null;
        private DateTime birthDate;
        private string status;
        public string Name { get; set; }
        public Species Species { get; set; }



        public string BirthDay => birthDate.ToString("dd/MM/yyyy");
        public int Age => (int)Math.Floor((DateTime.Today - birthDate.Date).Days / 365.25);
        public string Status => status;


        /// <summary>
        /// Create new animal
        /// </summary>
        public Animal(string name, DateTime birth, Species species)
        {
            Name = name;
            birthDate = birth;
            Species = species;
            status = "In zoo";
            
        }

        /// <summary>
        /// Reading animal data
        /// </summary>
        public Animal(int? id, string name, DateTime birth, Species species, string status)
            : this(name, birth, species)
        {
            this.id = id;
            this.status = status;
        }

        public bool Equals(Animal? other)
        {
            return id == other?.id;
        }

        public bool ChangeStatus(string status)
        {
            if (allowedStatuses.Contains(status))
            {
                this.status = status;
                return true;
            }
            return false;
        }

        public void ChangeBirthDay(DateTime t)
        {
            if(DateTime.Today < t)
            {
                throw new ArgumentException("Impossible birthday.");
            }
            birthDate = t;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            IParameterValueCollection args = new ParameterValueCollection();
            args.Add("id", id);
            args.Add("animalName", Name);
            args.Add("birthdate", birthDate);
            args.Add("species", Species.Id);
            args.Add("status", status);

            return args;
        }
    }
}
