﻿using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALAnimal;
using ZooBazaarDataLayer.DALEmployee;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarLogicLayer.Managers
{
    public class EmployeeManager
    {
        private IDALEmployee dataSource;
        private EmployeeManager(IDALEmployee source)
        {
            dataSource = source;
        }

        public static EmployeeManager CreateForDatabase()
        {
            return new EmployeeManager(new DBEmployee());
        }

        public static EmployeeManager CreateForUnitTest()
        {
            throw new NotImplementedException();
        }

        public IValidationResponse UpdateEmployees(Employee e)
        {
            return null; //dataSource.UpdateEntry(e);
        }
        public IValidationResponse CreateAnimal(Employee e)
        {
            return null;// dataSource.AddEntry(e);
        }
        public IValidationResponse DeleteAnimal(Employee e)
        {
            return null;// dataSource.DeleteEntry(e);
        }

        public IReadOnlyCollection<Employee> GetEmployeesByName(string name)
        {
            var queryResult = dataSource.GetByName(name);
            List<Employee> finalResult = new List<Employee>();
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("employeeName");
                string address = result.GetValueAs<string>("address");
                string phoneNumber = result.GetValueAs<string>("phoneNumber");
                string email = result.GetValueAs<string>("email");
                DateTime birth = result.GetValueAs<DateTime>("birthDate");
                
                Employee employee = new Employee(id, resultname, address, phoneNumber,email, birth);
                finalResult.Add(employee);
            }
            return finalResult;
        }
    }
}
