using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarLogicLayer.Schedule.Automatic
{
    public class AutomaticScheduler
    {
        private ShiftManager shiftManager;
        private EmployeeManager employeeManager;
        private AvailabilityManager availabilityManager;
        private Shift[][] shiftgrid = new Shift[7][];
        private readonly Dictionary<DateTime, int> dateToCollumnConv = new Dictionary<DateTime, int>();
        private readonly Dictionary<int, DateTime> collumnToDateConv = new Dictionary<int, DateTime>();
        private readonly Dictionary<Employee, int> employeeHoursMap = new Dictionary<Employee, int>();

        public AutomaticScheduler(DateTime startdate)
        {
            shiftManager = ShiftManager.CreateForDatabase();
            employeeManager = EmployeeManager.CreateForDatabase();
            availabilityManager = AvailabilityManager.CreateForDatabase(); 
            DateTime currentday = shiftManager.GetMonday(startdate);
            for(int collumn = 0; collumn < 7; collumn++)
            {
                shiftgrid[collumn] = new Shift[3];
                dateToCollumnConv.Add(currentday.Date, collumn);
                collumnToDateConv.Add(collumn, currentday.Date);
                currentday = currentday.AddDays(1);
            }
            FillExistingShifts(startdate);
            
        }

        private void FillExistingShifts(DateTime startdate)
        {
            var existingshifts = shiftManager.GetAllCurrentWeeksShifts(startdate);
            foreach (var shift in existingshifts)
            {
                int targetcollumn = dateToCollumnConv[shift.Date.Date];
                int targetrow = (int)shift.ShiftType;
                shiftgrid[targetcollumn][targetrow] = shift;
            }
        }

        private void CompleteGrid()
        {
            for (int collumn = 0; collumn < 7; collumn++)
            {
                for (int row = 0; row < 3; row++)
                {
                    Shift? target = shiftgrid[collumn][row];
                    if (target != null)
                    {

                    }
                    else
                    {
                        MakeNewShift(collumn, row);
                    }
                }
            }
        }

        private void MakeNewShift(int collumn, int row)
        {
            DateTime targetDate = collumnToDateConv[collumn];
            Shift shift = new Shift(targetDate, (ShiftType)row);
            shiftgrid[collumn][row] = shift;
        }

        private void AssignPeople(Shift shift, int collumn, int row)
        {
            List<Employee> employees = employeeManager.GetEmployeesWithActiveContract(shift.Date).ToList();
            List<Employee> removethese;

            #region next shift collumns and rows

            int nextcollumn = 0;
            int nextrow = 0;

            //This is used to help us look through the next or previous shift in the grid
            if (row == 2)//If shift is the last shift of the day we move to the next day and set shifttype to Morning
            {
                nextcollumn = collumn + 1;
                nextrow = 0;
                if(nextcollumn > 6)//If the shift was in the last day the week is done and the nextday's shift is back to the start
                {
                    nextcollumn = 0;
                }
            }
            else if(row != 2)//if the shiftType of shift is not Evening shiftType we set the next shifts shiftType to the next ShiftType and we keep the day of the current shift 
            {
                nextrow = row + 1;
                nextcollumn = collumn;
            }
            #endregion

            #region previous shift collumns and rows

            int previouscollumn = 0;
            int previousrow = 0;

            //This is used to help us look through the next or previous shift in the grid
            if (row == 0)//If shift is the first shift of the day we move to the previous day and set shifttype to Evening
            {
                previouscollumn = collumn - 1;
                previousrow = 2;
                if (previouscollumn < 0)//If the shift was in the first day the week is started and the previous's shift is back to the end
                {
                    previouscollumn = 6;
                }
            }
            else if (row != 0)//if the shiftType of shift is not Mornig shiftType we set the previous shifts shiftType to the previous ShiftType and we keep the day of the current shift 
            {
                previousrow = row - 1;
                previouscollumn = collumn;
            }
            #endregion

            #region removing employees from adjacent shifts of the the shift we handeling
            //Looks for people who have been assigned to work either the next or previous shift from the shift we are handeling so that they could be removed from the pull of employees that could be assigned to the shift we are handeling
            if (collumn == 0 && row == 0)//if the shift we are handeling is the first shift of the day we need to get information from the database regarding the people who worked on the previous shift and we also look if there are people already working in the next shift
            {
                Shift? previousshift = shiftManager.GetPreviousShift(shift);
                if(previousshift != null)
                {
                    removethese = shiftManager.GetEmployeesFromShift(previousshift).ToList();
                    employees.RemoveAll(x => removethese.Contains(x));
                    Shift? nextshift = shiftgrid[nextcollumn][nextrow];
                    if (nextshift != null)
                    {
                        removethese = nextshift.Employees.ToList();
                        employees.RemoveAll(x => removethese.Contains(x));
                    }
                }                
            }
            else if(collumn == 6 && row == 2)//if the shift we are handeling is the last shift of the week we look if there exist a shift in the start of the next week and we get the people from that shift
            {
                Shift? nextshift = shiftManager.GetNextShift(shift);
                if (nextshift != null)
                {
                    removethese = shiftManager.GetEmployeesFromShift(nextshift).ToList();
                    employees.RemoveAll(x => removethese.Contains(x));
                }
            }
            else//This is for when we look inside the week which the grid already has information of existing shift in that week, the database isnt required in this instance
            {
                Shift? othershift = shiftgrid[previouscollumn][previousrow];
                if (othershift != null)
                {
                    removethese = othershift.Employees.ToList();
                    employees.RemoveAll(x => removethese.Contains(x));
                }                

                othershift = shiftgrid[nextcollumn][nextrow];
                if (othershift != null)
                {
                    removethese = othershift.Employees.ToList();
                    employees.RemoveAll(x => removethese.Contains(x));
                }
            }
            #endregion

            var availabilitydata = availabilityManager.GetByMoment(shift.Date.DayOfWeek, shift.ShiftType);
        }

        public string ShowGrid()
        {
            StringBuilder sb = new StringBuilder();
            for(int collumn = 0; collumn < 7; collumn++)
            {
                for(int row = 0; row < 3; row++)
                {
                    Shift? target = shiftgrid[collumn][row];
                    if(target != null)
                    {
                        sb.Append($"- {target} -");
                    }
                    else
                    {
                        sb.Append($"- Empty -");
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
