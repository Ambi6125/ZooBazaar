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
        private readonly List<Exhibit> exhibits = new List<Exhibit>();

        public IReadOnlyList<Exhibit> Exhibits => exhibits;

        public int NumberOfExhibits
        {
            get
            {
                var dbResponse = dataSource.Count;
                if(dbResponse <= 0)
                {
                    return exhibits.Count;
                }
                else
                {
                    return dbResponse;
                }
            }
        }


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
            return new ExhibitManager(new MockDALExhibit());
        }

        public IValidationResponse AddExhibit(Exhibit e)
        {
            if (exhibits.Any(exhibit => exhibit.Id == e.Id))
                throw new InvalidOperationException("Duplicate ID");


            var response = dataSource.AddEntry(e);
            if (response.Success)
            {
                exhibits.Add(e);
            }
            return response;
        }

        public IValidationResponse DeleteExhibit(Exhibit e)
        {
            var response = dataSource.DeleteEntry(e);
            if (response.Success)
            {
                exhibits.Remove(e);
            }
            return response;
        }

        public IValidationResponse UpdateExhibit(Exhibit e)
        {
            var response = dataSource.UpdateEntry(e);
            if (response.Success)
            {
                bool occurs = exhibits.Any(exh => exh.Id == e.Id);
                if (occurs)
                {
                    int index = exhibits.FindIndex(exh => exh.Id == e.Id);
                    exhibits[index] = e;
                }
            }
            return response;
        }

        public Exhibit SearchById(int id)
        {

            Exhibit? returnValue;

            returnValue = exhibits.SingleOrDefault(ex => ex.Id == id);

            if(returnValue is not null)
            {
                return returnValue;
            }

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


            returnValue = new Exhibit(exhibitId, name, zone, capacity, count);
            exhibits.Add(returnValue);
            return returnValue;
        }

        public IReadOnlyCollection<Exhibit> GetByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Exhibit> finalResult = exhibits.Where(ex => ex.Name.ToLower().Contains(name.ToLower())).ToList();
            foreach (var result in queryResult)
            {
                int? exhibitId = result.GetValueAs<int?>("id");
                string resaultname = result.GetValueAs<string>("name");
                string zone = result.GetValueAs<string>("zone");
                int count = result.GetValueAs<int>("count");
                int capacity = result.GetValueAs<int>("capacity");
                Exhibit exhibit = new Exhibit(exhibitId, resaultname, zone, capacity, count);
                if (!finalResult.Any(e => e.Id == exhibitId))
                {
                    finalResult.Add(exhibit);
                }
            }
            return finalResult;
        }

        public IReadOnlyCollection<Exhibit> GetByZone(string zone)
        {
            var queryResult = dataSource.GetByZone(zone);
            List<Exhibit> finalResult = exhibits.Where(x => x.Zone.ToLower().Contains(zone.ToLower())).ToList();
            foreach (var result in queryResult)
            {
                int? exhibitId = result.GetValueAs<int?>("id");
                string name = result.GetValueAs<string>("name");
                string resaultzone = result.GetValueAs<string>("zone");
                int count = result.GetValueAs<int>("count");
                int capacity = result.GetValueAs<int>("capacity");
                Exhibit exhibit = new Exhibit(exhibitId, name, resaultzone, capacity, count);
                if(!finalResult.Any(x => x.Id == exhibitId))
                {
                    finalResult.Add(exhibit);
                }
            }
            return finalResult;
        }

        public IReadOnlyCollection<Exhibit> GetAll()
        {
            var queryResult = dataSource.GetAll();
            List<Exhibit> finalResult = exhibits.ToList();
            foreach (var result in queryResult)
            {
                int? exhibitId = result.GetValueAs<int?>("id");
                string resaultname = result.GetValueAs<string>("name");
                string zone = result.GetValueAs<string>("zone");
                int count = result.GetValueAs<int>("count");
                int capacity = result.GetValueAs<int>("capacity");
                Exhibit exhibit = new Exhibit(exhibitId, resaultname, zone, capacity, count);
                if (!finalResult.Any(x => x.Id == exhibitId.Value))
                {
                    finalResult.Add(exhibit);
                    exhibits.Add(exhibit);
                }
            }

            return finalResult;
        }

        public IReadOnlyCollection<Exhibit> GetByFullName(string zone, string name)
        {
            return GetByZone(zone).Where(x => x.Name.Equals(name)).ToList();
        }
    }
}
