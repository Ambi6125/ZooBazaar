using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALExhibit;
using ZooBazaarDataLayer.DALSpecies;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Zones;

namespace ZooBazaarLogicLayer.Managers
{
    public class ExhibitManager
    {
        private readonly IDALExhibit dataSource;

        private ExhibitManager(IDALExhibit source)
        {
            dataSource = source;
        }

        public static ExhibitManager CreateForDatabase()
        {
            return new ExhibitManager(new DBExhibit());
        }

        public static ExhibitManager CreateForUnitTest()
        {
            throw new NotImplementedException();
        }

        public IValidationResponse AddExhibit(Exhibit e)
        {
            return dataSource.AddEntry(e);
        }

        public IValidationResponse DeleteExhibit(Exhibit e)
        {
            return dataSource.DeleteEntry(e);
        }

        public IValidationResponse UpdateExhibit(Exhibit e)
        {
            return dataSource.UpdateEntry(e);
        }

        public Exhibit SearchById(int id)
        {
            var result = dataSource.GetById(id);

            if(result is null)
            {
                throw new ArgumentException("No exhibit with that id exists.");
            }
            int? exhibitId = result.GetValueAs<int?>("id");
            string name = result.GetValueAs<string>("name");
            string zone = result.GetValueAs<string>("zone");
            int count = result.GetValueAs<int>("count");
            int capacity = result.GetValueAs<int>("capacity");


            return new Exhibit(exhibitId, name, zone, capacity, count);
        }

        public IReadOnlyCollection<Exhibit> GetByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Exhibit> finalResult = new List<Exhibit>();
            foreach (var result in queryResult)
            {
                int? exhibitId = result.GetValueAs<int?>("id");
                string resaultname = result.GetValueAs<string>("name");
                string zone = result.GetValueAs<string>("zone");
                int count = result.GetValueAs<int>("count");
                int capacity = result.GetValueAs<int>("capacity");
                Exhibit exhibit = new Exhibit(exhibitId, resaultname, zone, capacity, count);
                finalResult.Add(exhibit);
            }
            return finalResult;
        }

        public IReadOnlyCollection<Exhibit> GetByZone(string zone)
        {
            var queryResult = dataSource.GetByZone(zone);
            List<Exhibit> finalResult = new List<Exhibit>();
            foreach (var result in queryResult)
            {
                int? exhibitId = result.GetValueAs<int?>("id");
                string name = result.GetValueAs<string>("name");
                string resaultzone = result.GetValueAs<string>("zone");
                int count = result.GetValueAs<int>("count");
                int capacity = result.GetValueAs<int>("capacity");
                Exhibit exhibit = new Exhibit(exhibitId, name, resaultzone, capacity, count);
                finalResult.Add(exhibit);
            }
            return finalResult;
        }

        public IReadOnlyCollection<Exhibit> GetAll()
        {
            var queryResult = dataSource.GetAll();
            List<Exhibit> finalResult = new List<Exhibit>();
            foreach (var result in queryResult)
            {
                int? exhibitId = result.GetValueAs<int?>("id");
                string resaultname = result.GetValueAs<string>("name");
                string zone = result.GetValueAs<string>("zone");
                int count = result.GetValueAs<int>("count");
                int capacity = result.GetValueAs<int>("capacity");
                Exhibit exhibit = new Exhibit(exhibitId, resaultname, zone, capacity, count);
                finalResult.Add(exhibit);
            }
            return finalResult;
        }

        public IReadOnlyCollection<Exhibit> GetByFullName(string zone, string name)
        {
            return GetByZone(zone).Where(x => x.Name.Equals(name)).ToList();
        }
    }
}
