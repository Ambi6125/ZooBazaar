﻿using EasyTools.Validation;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarDataLayer.DALEmployee;
using ZooBazaarDataLayer.DALScheduling;
using ZooBazaarDataLayer.DALScheduling.DALShift;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Availability;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarLogicLayer.Managers
{
    public class ShiftManager
    {
        private readonly IDalShift dataSource;


        private ICollection<Employee> BuildEmployees(int id)
        {
            var tableWithCertainId = dataSource.GetEmployeesFromShift(id);
            var shiftEmployees = new List<Employee>();
            bool hasEmployees = tableWithCertainId.Any();
            if (hasEmployees)
            {
                foreach (var item in tableWithCertainId) //Makes employees for enclosing shift
                {
                    int empId = item.GetValueAs<int>("id");
                    string name = item.GetValueAs<string>("employeeName");
                    string address = item.GetValueAs<string>("address");
                    string phoneNumber = item.GetValueAs<string>("phoneNumber");
                    string email = item.GetValueAs<string>("email");
                    DateTime birthdate = item.GetValueAs<DateTime>("birthDate");
                    

                    Employee emp = new Employee(empId, name, address, phoneNumber, email, birthdate);
                    shiftEmployees.Add(emp);
                }
            }
            return shiftEmployees;
        }

        private ShiftManager(IDalShift dal)
        {
            dataSource = dal;
        }

        public IReadOnlyCollection<Shift> GetByDate(DateTime date)
        {
            List<Shift> shifts = new List<Shift>();
            var allData = dataSource.GetByDate(date);

            if (!allData.Any())
            {
                return Enumerable.Empty<Shift>().ToArray();
            }

            var identifiers = dataSource.GetIdsOnDate(date);

            foreach (int id in identifiers) //Makes shift
            {
                //Uses the id from identifiers to get the specific shift data from the allData list 
                var tableWithCertainId = allData.Where(x => x.GetValueAs<int>(0) == id);
                //Uses the id to get all the employees from that shift 
                List<Employee> shiftEmployees = BuildEmployees(id).ToList();

                var singleEntry = tableWithCertainId.First();

                int shiftId = singleEntry.GetValueAs<int>(0);
                ShiftType type = singleEntry.GetValueAs<ShiftType>("shiftType");
                DateTime shiftDate = singleEntry.GetValueAs<DateTime>("date");

                Shift s = new Shift(shiftId, shiftDate, shiftEmployees, type);
                shifts.Add(s);
            }

            return shifts;
        }

        public int GetRecentId()
        {
            return dataSource.GetMostRecentId();
        }
        
        public IReadOnlyCollection<Employee> GetEmployeesFromShift(Shift shift)
        {
            List<Employee> employees = new List<Employee>();
            var response = dataSource.GetEmployeesFromShift(shift.ID);

            foreach(var data in response)
            {
                int id = data.GetValueAs<int>("id");
                string employeeName = data.GetValueAs<string>("employeeName");
                string address = data.GetValueAs<string>("address");
                string phoneNumber = data.GetValueAs<string>("phoneNumber");
                string email = data.GetValueAs<string>("email");
                DateTime birthdate = data.GetValueAs<DateTime>("birthDate");
                int accountId = data.GetValueAs<int>("accountId");

                employees.Add(new Employee(id, employeeName, address, phoneNumber, email, birthdate));
            }
            return employees;
        }

        public Shift? GetPreviousShift(Shift s)
        {
            DateTime? finalDate = null;
            ShiftType? finalType = null;

            switch (s.ShiftType)
            {
                case ShiftType.Morning:
                    finalType = ShiftType.Evening;
                    finalDate = s.Date.AddDays(-1);
                    break;
                case ShiftType.Afternoon:
                    finalDate = s.Date;
                    finalType = ShiftType.Morning;
                    break;
                case ShiftType.Evening:
                    finalDate = s.Date;
                    finalType = ShiftType.Afternoon;
                    break;
            }

            if (finalType is not null && finalDate is not null)
            {
                return GetByDateAndType(finalDate.Value, finalType.Value);
            }
            else
            {
                throw new ArgumentException("Could not calculate previous date and type.");
            }
        }

        public Shift? GetNextShift(Shift s)
        {
            DateTime? finalDate = null;
            ShiftType? finalType = null;

            switch (s.ShiftType)
            {
                case ShiftType.Morning:
                    finalDate = s.Date;
                    finalType = ShiftType.Afternoon;
                    break;
                case ShiftType.Afternoon:
                    finalDate = s.Date;
                    finalType = ShiftType.Evening;
                    break;
                case ShiftType.Evening:
                    finalDate = s.Date.AddDays(1).Date;
                    finalType = ShiftType.Morning;
                    break;
            }

            if (finalType is not null && finalDate is not null)
            {
                return GetByDateAndType(finalDate.Value, finalType.Value);
            }
            else
            {
                throw new ArgumentException("Could not calculate next date and type.");
            }
        }

        public Shift? GetByDateAndType(DateTime date, ShiftType type)
        {
            var response = dataSource.GetByTime(date, (int)type);

            var singleResult = response.FirstOrDefault();

            if(singleResult == null)
                return null;

            int id = singleResult.GetValueAs<int>("id");
            ShiftType shiftType = (ShiftType)singleResult.GetValueAs<int>("shiftType");
            var employees = BuildEmployees(id);
            DateTime responseDate = singleResult.GetValueAs<DateTime>("date");

            Shift result = new Shift(id, responseDate, employees, shiftType);
            return result;
        }

        public static ShiftManager CreateForDatabase()
        {
            return new ShiftManager(new DBShifts());
        }

        public IValidationResponse AddShift(Shift s)
        {
            return dataSource.Add(s);
        }

        public IValidationResponse Register(ShiftEmployeeRelationShip data)
        {
            return dataSource.RegisterEmployee(data);
        }

        public IValidationResponse Register(Shift shift, Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee.ID);

            var relationship = new ShiftEmployeeRelationShip(employee.ID.Value, shift.ID);
            return Register(relationship);
        }

        public IValidationResponse RemoveEmployee(Shift shift, Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee.ID);
            return RemoveEmployee(new ShiftEmployeeRelationShip(employee.ID.Value, shift.ID));
        }

        public IValidationResponse RemoveEmployee(ShiftEmployeeRelationShip relationShip)
        {
            return dataSource.RemoveEmployee(relationShip);
        }

        //TODO: figure out how to get all current week shifts
        public IReadOnlyCollection<Shift> GetAllCurrentWeeksShifts(DateTime date)
        {
            List<Shift> result = new List<Shift>();
            var response = dataSource.GetBetween(GetMonday(date), GetSunday(date));
            foreach ( var shift in response)
            {
                if (!result.Any(x => x.ID == shift.GetValueAs<int>("id")))
                {
                    int id = shift.GetValueAs<int>("id");
                    ShiftType type = shift.GetValueAs<ShiftType>("shiftType");
                    DateTime shiftDate = shift.GetValueAs<DateTime>("date");
                    List<Employee> shiftEmployees = BuildEmployees(id).ToList();
                    Shift s = new Shift(id, shiftDate, shiftEmployees, type);
                    result.Add(s);
                }
            }
            return result;

            #region commented code
            //var response = dataSource.GetBetween(GetMonday(date), GetSunday(date));//gets a list of shifts between monday and sunday
            //var identifiers = dataSource.GetIdsOnDate(date);//gets a list of shift ids on a specific date
            //foreach (var shift in response)
            //{
            //    var tableWithCertainId = response.Where(x => x.GetValueAs<int>("zb_shifts.id") == id);

            //    List<Employee> shiftEmployees = BuildEmployees(id).ToList(); //we get employees from a specific shift using the shift id

            //    var singleEntry = tableWithCertainId.First();

            //    int shiftId = singleEntry.GetValueAs<int>("zb_shifts.id");
            //    ShiftType type = singleEntry.GetValueAs<ShiftType>("shiftType");
            //    DateTime shiftDate = Convert.ToDateTime(singleEntry.GetValueAs<string>("date"));

            //    Shift s = new Shift(shiftId, shiftDate, shiftEmployees, type);
            //    result.Add(s);
            //}
            #endregion
        }

        internal DateTime GetMonday(DateTime date)
        {
            int datessincemonday = (int)date.DayOfWeek - 1;
            if(datessincemonday == -1)
            {
                datessincemonday = 6;
            }
            return date.AddDays(- datessincemonday);
        }

        private DateTime GetSunday(DateTime date)
        {
            if(date.DayOfWeek == DayOfWeek.Sunday)
            {
                return date;
            }
            int datesuntilsunday = 7 - (int)date.DayOfWeek;
            return date.AddDays(datesuntilsunday);
        }

        public IReadOnlyCollection<Employee> GetEmployeesThatCanWork(Shift s)
        {
            EmployeeManager manager = EmployeeManager.CreateForDatabase();

            //First we get all employees with an active contract and put them in a list

            List<Employee> employees = manager.GetEmployeesWithActiveContract(s.Date).ToList();

            //Second we get a list of employees that can not work in the shift that we are looking at and remove those from the first list



            List<Employee> result = manager.GetUnAvailableEmployeeByShift(s).ToList();
            foreach(Employee empl in result)
            {
                if (employees.Any(x => x.ID == empl.ID))
                {
                    employees.Remove(empl);
                }
            }

            //Third we get a list of employees that have worked in the previous shift and we remove them from the first updated list

            Shift? previousShift = GetPreviousShift(s);
            if(previousShift != null)
            {
                foreach (Employee employee in previousShift.Employees)
                {
                    if (employees.Any(x => x.ID == employee.ID))
                    {
                        employees.Remove(employee);
                    }
                }
            }        
            
            Shift? nextShift = GetNextShift(s);
            if(nextShift is not null)
            {
                foreach(Employee employee in nextShift.Employees)
                {
                    if(employees.Any(x => x.ID == employee.ID))
                    {
                        employees.Remove(employee);
                    }
                }
            }

            //Fourth we get a list of employees that can not work based on hours and we remove those from the first list
            //To get those employees who have completed their weeks hours we utilize GetAllcurrentweekshifts method by checking each shift list of employees

            List<Shift> shifts = GetAllCurrentWeeksShifts(s.Date).ToList();
            List<Employee> completedemp = new List<Employee>();
            foreach (Employee e in employees)
            {
                int hoursworked = 0;
                foreach (Shift sh in shifts)
                {
                    foreach (Employee emp in sh.Employees)
                    {
                        if (e.Equals(emp))
                        {
                            hoursworked++;
                        }
                    }
                }

                //if stament to check contract type which we need to use to calculate if the hours he has worked is equal to the amount he needs to work with exception of zerobased contracts

                ContractManager contractManager = ContractManager.CreateForDatabase();
                List<Contract> contracts = contractManager.GetActiveContracts(s.Date).ToList();
                ContractType type = ContractType.ZeroBased;
                foreach (Contract contract in contracts)
                {
                    if(contract.EmployeeName == e.Name)
                    {
                        type = contract.ContractType; break;
                    }
                }


                if(type == ContractType.FullTime)
                {
                    if (hoursworked >= 5)
                    {
                        completedemp.Add(e);
                    }
                }

                if (type == ContractType.PartTime)
                {
                    if (hoursworked >= 4)
                    {
                        completedemp.Add(e);
                    }
                }                  
            }

            foreach (Employee e in completedemp)
            {
                if (employees.Any(x => x.ID == e.ID))
                {
                    employees.Remove(e);
                }
            }            

            //We give final list

            return employees;
        }
    }
}