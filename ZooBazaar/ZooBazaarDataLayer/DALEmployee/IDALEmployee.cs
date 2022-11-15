﻿using EasyTools.MySqlDatabaseTools;
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
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesWithNoContracts();
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetEmployeesWithInactiveContracts(bool isActive);
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAllEmployeesContracts(int? id);
        IValidationResponse UpdateContractStatus(IDataProvider employee);
        public IReadOnlyCollection<IReadOnlyParameterValueCollection> GetAllEmployees();
    }
}