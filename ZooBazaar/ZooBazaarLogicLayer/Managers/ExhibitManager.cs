using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALExhibit;
using ZooBazaarLogicLayer.Zones;

namespace ZooBazaarLogicLayer.Managers
{
    public class ExhibitManager
    {
        private readonly IDALExhibit dataSource;

        public ExhibitManager(IDALExhibit source)
        {
            dataSource = source;
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
    }
}
