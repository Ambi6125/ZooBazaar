using EasyTools.MySqlDatabaseTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer
{
    public class EmployeeContractLink : IDataProvider
    {

        private readonly int contractid;
        private readonly int employeeid;

        public EmployeeContractLink(int contractid, int employeeid)
        {
            this.contractid = contractid;
            this.employeeid = employeeid;
        }

        public IParameterValueCollection GetParameterArgs()
        {
            ParameterValueCollection pvc = new ParameterValueCollection();
            pvc.Add("employeeId", employeeid);
            pvc.Add("contractId", contractid);            

            return pvc;
        }
    }
}
