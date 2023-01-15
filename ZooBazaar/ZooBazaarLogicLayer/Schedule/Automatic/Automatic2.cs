using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;
using ZooBazaarLogicLayer.Schedule.Availability;
namespace ZooBazaarLogicLayer.Schedule.Automatic
{
    public class Automatic2
    {
        //public static List<Shift> GenerateSchedule(List<AutoEmployee> employees, int employeesPerShift, DateTime startDate, DateTime endDate)
        //{
        //    List<Shift> shifts = new List<Shift>();
        //    DateTime currentDate = startDate;
        //    Dictionary<AutoEmployee, int> employeeHours = new Dictionary<AutoEmployee, int>();
        //    Dictionary<AutoEmployee, int> employeeWeekHours = new Dictionary<AutoEmployee, int>();
        //    Dictionary<AutoEmployee, Tuple<DayOfWeek, ShiftType>> lastAssignedShift = new Dictionary<AutoEmployee, Tuple<DayOfWeek, ShiftType>>();

        //    while (currentDate <= endDate)
        //    {
        //        // Create a list to store employees assigned to this shift
        //        List<AutoEmployee> shiftEmployees = new List<AutoEmployee>();
        //        // iterate over all employees that are available for the current shift
        //        foreach (var employee in employees.Where(e => !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Morning))))
        //        {
        //            if (shiftEmployees.Count == employeesPerShift) break;
        //            if (employee.ContractType != ContractType.ZeroBased)
        //            {
        //                // check if the employee can work more hours
        //                if (employee.ContractType == ContractType.FullTime && employeeHours.GetValueOrDefault(employee) < 40 ||
        //                    employee.ContractType == ContractType.PartTime && employeeHours.GetValueOrDefault(employee) < 32)
        //                {
        //                    // check if the employee haven't worked this week or less hours than other employee
        //                    if (!employeeWeekHours.ContainsKey(employee) || employeeWeekHours.GetValueOrDefault(employee) <= employeeWeekHours.Values.Min())
        //                    {
        //                        shiftEmployees.Add(employee);
        //                        // update the employee's hours
        //                        employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
        //                        employeeWeekHours[employee] = employeeWeekHours.GetValueOrDefault(employee) + 8;
        //                    }
        //                }
        //            }
        //        }
        //        if (shiftEmployees.Count < employeesPerShift)
        //        {
        //            foreach (var employee in employees.Where(e => e.ContractType == ContractType.ZeroBased && !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Morning))))
        //            {
        //                if (shiftEmployees.Count == employeesPerShift) break;
        //                if (!shiftEmployees.Contains(employee))
        //                {
        //                    shiftEmployees.Add(employee);
        //                    employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
        //                    employeeWeekHours[employee] = employeeWeekHours.GetValueOrDefault(employee) + 8;
        //                }
        //            }
        //        }
        //        shifts.Add(new Shift(ShiftType.Morning, currentDate, RevertEmployee(shiftEmployees)));

        //        shiftEmployees = new List<AutoEmployee>();
        //        foreach (var employee in employees.Where(e => !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Afternoon))))
        //        {
        //            if (employee.ContractType == ContractType.FullTime && employeeHours.GetValueOrDefault(employee) < 40 ||
        //            employee.ContractType == ContractType.PartTime && employeeHours.GetValueOrDefault(employee) < 32 ||
        //            employee.ContractType == ContractType.ZeroBased)
        //            {
        //                if (!lastAssignedShift.ContainsKey(employee) || lastAssignedShift[employee].Item1 != currentDate.DayOfWeek)
        //                {
        //                    shiftEmployees.Add(employee);
        //                    employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
        //                    lastAssignedShift[employee] = Tuple.Create(currentDate.DayOfWeek, ShiftType.Afternoon);
        //                }
        //            }
        //            if (shiftEmployees.Count == employeesPerShift) break;
        //        }
        //        if (shiftEmployees.Count < employeesPerShift)
        //        {
        //            var zeroHourEmployees = employees.Where(e => e.ContractType == ContractType.ZeroBased && !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Afternoon)));
        //            foreach (var employee in zeroHourEmployees)
        //            {
        //                if (!lastAssignedShift.ContainsKey(employee) || lastAssignedShift[employee].Item1 != currentDate.DayOfWeek)
        //                {
        //                    shiftEmployees.Add(employee);
        //                    employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
        //                    lastAssignedShift[employee] = Tuple.Create(currentDate.DayOfWeek, ShiftType.Afternoon);
        //                }
        //                if (shiftEmployees.Count == employeesPerShift) break;
        //            }
        //        }
        //        shifts.Add(new Shift(ShiftType.Afternoon, currentDate, RevertEmployee(shiftEmployees)));
        //        shiftEmployees = new List<AutoEmployee>();
        //        foreach (var employee in employees.Where(e => !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Evening))))
        //        {
        //            if (!lastAssignedShift.ContainsKey(employee) || lastAssignedShift[employee].Item1 != currentDate.DayOfWeek)
        //            {
        //                //check if the employee can work more hours
        //                if (employee.ContractType == ContractType.FullTime && employeeHours.GetValueOrDefault(employee) < 40 ||
        //                employee.ContractType == ContractType.PartTime && employeeHours.GetValueOrDefault(employee) < 32 ||
        //                employee.ContractType == ContractType.ZeroBased)
        //                {
        //                    shiftEmployees.Add(employee);
        //                    // update the employee's hours and last assigned shift
        //                    employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
        //                    lastAssignedShift[employee] = Tuple.Create(currentDate.DayOfWeek, ShiftType.Evening);
        //                }
        //            }
        //            if (shiftEmployees.Count == employeesPerShift) break;
        //        }
        //        //if there aren't enough employees for the shift, then assign all available employees
        //        if (shiftEmployees.Count < employeesPerShift)
        //        {
        //            foreach (var employee in employees.Where(e => e.ContractType == ContractType.ZeroBased && !e.DaysOff.Contains(Tuple.Create((DayOfWeek)currentDate.DayOfWeek, ShiftType.Evening)) && !shiftEmployees.Contains(e)))
        //            {
        //                if (!lastAssignedShift.ContainsKey(employee) || lastAssignedShift[employee].Item1 != (DayOfWeek)currentDate.DayOfWeek)
        //                {
        //                    shiftEmployees.Add(employee);
        //                    // update the employee's hours and last assigned shift
        //                    employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
        //                    lastAssignedShift[employee] = Tuple.Create(currentDate.DayOfWeek, ShiftType.Evening);
        //                }
        //            }
        //        }
        //        shifts.Add(new Shift(ShiftType.Evening, currentDate, RevertEmployee(shiftEmployees)));
        //        currentDate = currentDate.AddDays(1);
        //        // reset the employee's week hours
        //        employeeWeekHours = new Dictionary<AutoEmployee, int>();
        //    }
        //    return shifts;
        //}

        public static List<Shift> GenerateSchedule(List<AutoEmployee> employees, int employeesPerShift, DateTime startDate, DateTime endDate)
        {
            List<Shift> shifts = new List<Shift>();
            DateTime currentDate = startDate;
            Dictionary<AutoEmployee, int> employeeHours = new Dictionary<AutoEmployee, int>();
            Dictionary<AutoEmployee, int> employeeWeekHours = new Dictionary<AutoEmployee, int>();
            Dictionary<AutoEmployee, Tuple<DayOfWeek, ShiftType>> lastAssignedShift = new Dictionary<AutoEmployee, Tuple<DayOfWeek, ShiftType>>();

            while (currentDate <= endDate)
            {
                // Create a list to store employees assigned to this shift
                List<AutoEmployee> shiftEmployees = new List<AutoEmployee>();
                // iterate over all employees that are available for the current shift
                foreach (var employee in employees.Where(e => !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Morning))))
                {
                    // check if the employee can work more hours
                    if (employee.ContractType == ContractType.FullTime && employeeHours.GetValueOrDefault(employee) < 40 ||
                        employee.ContractType == ContractType.PartTime && employeeHours.GetValueOrDefault(employee) < 32 ||
                        employee.ContractType == ContractType.ZeroBased)
                    {
                        // check if the employee haven't worked this week or less hours than other employee
                        if (!employeeWeekHours.ContainsKey(employee) || employeeWeekHours.GetValueOrDefault(employee) <= employeeWeekHours.Values.Min())
                        {
                            shiftEmployees.Add(employee);
                            // update the employee's hours
                            employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
                            employeeWeekHours[employee] = employeeWeekHours.GetValueOrDefault(employee) + 8;
                            lastAssignedShift[employee] = Tuple.Create(currentDate.DayOfWeek, ShiftType.Morning);
                        }
                        if (shiftEmployees.Count == employeesPerShift) break;
                    }
                }
                shifts.Add(new Shift(ShiftType.Morning, currentDate, RevertEmployee(shiftEmployees)));

                // repeat the same for afternoon and evening
                shiftEmployees = new List<AutoEmployee>();
                foreach (var employee in employees.Where(e => !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Afternoon))))
                {
                    if (employee.ContractType == ContractType.FullTime && employeeHours.GetValueOrDefault(employee) < 40 ||
                    employee.ContractType == ContractType.PartTime && employeeHours.GetValueOrDefault(employee) < 32 ||
                    employee.ContractType == ContractType.ZeroBased)
                    {
                        if (!lastAssignedShift.ContainsKey(employee) || lastAssignedShift[employee].Item1 != currentDate.DayOfWeek)
                        {
                            shiftEmployees.Add(employee);
                            // update the employee's hours
                            employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
                            lastAssignedShift[employee] = Tuple.Create(currentDate.DayOfWeek, ShiftType.Afternoon);
                        }
                    }
                    if (shiftEmployees.Count == employeesPerShift) break;
                }
                shifts.Add(new Shift(ShiftType.Afternoon, currentDate, RevertEmployee(shiftEmployees)));

                shiftEmployees = new List<AutoEmployee>();
                foreach (var employee in employees.Where(e => !e.DaysOff.Contains(Tuple.Create(currentDate.DayOfWeek, ShiftType.Evening))))
                {
                    if (employee.ContractType == ContractType.FullTime && employeeHours.GetValueOrDefault(employee) < 40 ||
                       employee.ContractType == ContractType.PartTime && employeeHours.GetValueOrDefault(employee) < 20 ||
                       employee.ContractType == ContractType.ZeroBased)
                    {
                        if (!lastAssignedShift.ContainsKey(employee) || lastAssignedShift[employee].Item1 != currentDate.DayOfWeek)
                        {
                            shiftEmployees.Add(employee);
                            // update the employee's hours
                            employeeHours[employee] = employeeHours.GetValueOrDefault(employee) + 8;
                            lastAssignedShift[employee] = Tuple.Create(currentDate.DayOfWeek, ShiftType.Evening);
                        }
                    }
                    if (shiftEmployees.Count == employeesPerShift) break;
                }
                shifts.Add(new Shift(ShiftType.Evening, currentDate, RevertEmployee(shiftEmployees)));

                // reset the employee's week hours at the end of the week
                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    employeeWeekHours = new Dictionary<AutoEmployee, int>();
                }

                // move to the next day
                currentDate = currentDate.AddDays(1);
            }

            return shifts;
        }

        public static List<AutoEmployee> ConvertEmployee(List<Employee> employees)
        {
            List<AutoEmployee> result = new List<AutoEmployee>();
            AvailabilityManager manager = AvailabilityManager.CreateForDatabase();
            ContractManager contractManager = ContractManager.CreateForDatabase();
            List<Contract> contracts = contractManager.GetActiveContracts(DateTime.Now).ToList();
            List<UnavailabilityData> list = manager.GetAllData().ToList();
            foreach (var emp in employees)
            {
                List<UnavailabilityData> unav = list.Where(x => x.Employee.ID == emp.ID).ToList();
                Contract contract = contracts.FirstOrDefault(x => x.EmployeeOwner.ID.Equals(emp.ID));
                List<Tuple<DayOfWeek, ShiftType>> daysOff = new List<Tuple<DayOfWeek, ShiftType>>();
                foreach(var item in unav)
                {                    
                    daysOff.Add(Tuple.Create(item.DayOfWeek, item.ShiftType));
                }
                AutoEmployee employee = new AutoEmployee(emp.ID.Value, emp.Name, daysOff, contract.ContractType);
                result.Add(employee);
            }
            return result;
        }

        public static ICollection<People.Employee> RevertEmployee(IList<AutoEmployee> employees)
        {
            EmployeeManager manager = EmployeeManager.CreateForDatabase();
            List<People.Employee> emp = new List<People.Employee>();
            foreach(var item in employees)
            {
                emp.Add(manager.GetEmployeesByName(item.Name).First());
            }
            return emp;
        }
    }

    public class AutoEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Tuple<DayOfWeek, ShiftType>> DaysOff { get; set; }
        public ContractType ContractType { get; set; }

        public AutoEmployee(int id, string name, List<Tuple<DayOfWeek, ShiftType>> daysOff, ContractType contractType)
        {
            Id = id;
            Name = name;
            DaysOff = daysOff;
            ContractType = contractType;
        }
    }
}
