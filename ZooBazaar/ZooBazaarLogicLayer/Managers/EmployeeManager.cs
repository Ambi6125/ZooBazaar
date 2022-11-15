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
            return dataSource.UpdateEntry(e);
        }
        public IValidationResponse CreateEmployee(Employee e)
        {
            return dataSource.AddEntry(e);
        }
        public IValidationResponse DeleteEmployee(Employee e)
        {
            return dataSource.DeleteEntry(e);
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
                bool hasContract = result.GetValueAs<bool>("hasContract");
                
                Employee employee = new Employee(id, resultname, address, phoneNumber,email, birth,hasContract);
                finalResult.Add(employee);
            }
            return finalResult;
        }

        //TODO: Dear Luc Amogus, Inner join with a contracts table to get employees with inactive contracts
        public IValidationResponse UpdateContractStatus(Employee e)
        {
            return dataSource.UpdateEntry(e);
        }
        public IReadOnlyCollection<Employee> GetEmployeesWithNoContracts()
        {
            var queryResult = dataSource.GetEmployeesWithNoContracts();
            List<Employee> finalResult = new List<Employee>();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("employeeName");
                string address = result.GetValueAs<string>("address");
                string phoneNumber = result.GetValueAs<string>("phoneNumber");
                string email = result.GetValueAs<string>("email");
                DateTime birth = result.GetValueAs<DateTime>("birthDate");
                bool hasContract = result.GetValueAs<bool>("hasContract");

                Employee employee = new Employee(id, resultname, address, phoneNumber, email, birth, hasContract);
                finalResult.Add(employee);
            }
            return finalResult;
        }
        public IReadOnlyCollection<Employee> GetEmployeesWithInactiveContracts(bool isActive)
        {
            var queryResult = dataSource.GetEmployeesWithInactiveContracts(isActive);
            List<Employee> finalResult = new List<Employee>();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("employeeName");
                string address = result.GetValueAs<string>("address");
                string phoneNumber = result.GetValueAs<string>("phoneNumber");
                string email = result.GetValueAs<string>("email");
                DateTime birth = result.GetValueAs<DateTime>("birthDate");
                bool hasContract = result.GetValueAs<bool>("hasContract");

                Employee employee = new Employee(id, resultname, address, phoneNumber, email, birth, hasContract);
                finalResult.Add(employee);
            }
            return finalResult;
        }

        public IReadOnlyCollection<Employee> GetAll()
        {
            var queryResult = dataSource.GetAllEmployees();
            List<Employee> finalResult = new List<Employee>();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("employeeName");
                string address = result.GetValueAs<string>("address");
                string phoneNumber = result.GetValueAs<string>("phoneNumber");
                string email = result.GetValueAs<string>("email");
                DateTime birth = result.GetValueAs<DateTime>("birthDate");
                bool hasContract = result.GetValueAs<bool>("hasContract");

                Employee employee = new Employee(id, resultname, address, phoneNumber, email, birth, hasContract);
                finalResult.Add(employee);
            }
            return finalResult;
        }

        public IReadOnlyCollection<Contract> GetAllEmployeeContracts(Employee employee)
        {
            var queryResult = dataSource.GetAllEmployeesContracts(employee.ID);
            List<Contract> finalResult = new List<Contract>();
            foreach (var result in queryResult)
            {
                int? id = result.GetValueAs<int?>("id");
                string resultname = result.GetValueAs<string>("employeeName");
                DateTime startDate = result.GetValueAs<DateTime>("startDate");
                DateTime endDate = result.GetValueAs<DateTime>("endDate");
                bool isActive = result.GetValueAs<bool>("isActive");
                int contractHours = result.GetValueAs<int>("contractHours");
                ContractType contractType = ContractType.ZeroBased;

                if (contractHours == 0)
                {
                    contractType = ContractType.ZeroBased;
                }
                else if (contractHours == 32)
                {
                    contractType= ContractType.PartTime;
                }
                else if (contractHours == 40)
                {
                    contractType = ContractType.FullTime;
                }

                Contract contract = new Contract(id, startDate, endDate, contractType, isActive, resultname);
                finalResult.Add(contract);
            }
            return finalResult;
        }

    }
}