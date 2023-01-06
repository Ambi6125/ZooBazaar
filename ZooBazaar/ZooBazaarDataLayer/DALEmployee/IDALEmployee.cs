using EasyTools.MySqlDatabaseTools;
using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarDataLayer.DALEmployee
{
    public interface IDALEmployee
    {
        IValidationResponse AddEntry(IDataProvider employee);
        IValidationResponse DeleteEntry(IDataProvider employee);
        IValidationResponse UpdateEntry(IDataProvider employee);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetByName(string name);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetById(int id);
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesWithNoContracts();
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesWithInactiveContracts(bool isActive);
        //TODO: change
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAllEmployeesContracts(int? id);
        //IValidationResponse UpdateContractStatus(IDataProvider employee);
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAllEmployees();
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesWithActiveContract(DateTime date);
        IReadOnlyCollection<IReadOnlyParameterValueCollection> GetUnAvailableEmployeeByShift(DayOfWeek weekday, int type);
    }
}