using EasyTools.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarDesktop.Forms
{
    public partial class AddShiftsForm : Form
    {
        private readonly MainForm mainForm;
        public AddShiftsForm(MainForm source)
        {
            InitializeComponent();
            this.mainForm = source;
        }

        private void DisplayEmployeesCorrectly(IEnumerable<Employee> available, IEnumerable<Employee> taken)
        {
            lbEmployeesAvailable.Items.Clear();
            lbEmployeesUsed.Items.Clear();
            foreach (Employee emp in available)
            {
                lbEmployeesAvailable.Items.Add(emp);
            }
            foreach(Employee emp in taken)
            {
                lbEmployeesUsed.Items.Add(emp);
            }
        }
        private void OnAddClick(object sender, EventArgs e)
        {
            ShiftType type = (ShiftType)cbbType.SelectedIndex;
            DateTime date = dtpDate.Value;
            Employee? emp = default;
            try
            {
                emp = lbEmployeesAvailable.SelectedItem as Employee;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            ShiftManager manager = ShiftManager.CreateForDatabase();
            var existingShift = manager.GetByDateAndType(date, type);
            IValidationResponse response;
            if(existingShift is null)
            {
                Shift newShift = new Shift(date, type);
                manager.AddShift(newShift);

                int recentId = manager.GetRecentId();

                var relationship = new ZooBazaarDataLayer.DALScheduling.DALShift.ShiftEmployeeRelationShip(emp.ID.Value, recentId);
                response = manager.Register(relationship);
            }
            else
            {
                response = manager.Register(existingShift, emp);
            }
            if (response.Success)
            {
                var dr = MessageBox.Show("Succesfully added.\nWould you like to close this form now?", "Success", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                mainForm.Show();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }


        private void OnInputChanged(object sender, EventArgs e)
        {
            ShiftManager sm = ShiftManager.CreateForDatabase();
            EmployeeManager em = EmployeeManager.CreateForDatabase();
            List<Employee> availableEmployees;
            List<Employee> takenEmployees;


            Shift? currentShift = sm.GetByDateAndType(dtpDate.Value, (ShiftType)cbbType.SelectedIndex);
            if(currentShift is null)
            {
                takenEmployees = Enumerable.Empty<Employee>().ToList();
                availableEmployees = em.GetAll().ToList(); //TODO: Not all employees should be available -- finish the logic for this
            }
            else
            {
                availableEmployees = em.GetAll().Except(currentShift.Employees).ToList();
                takenEmployees = currentShift.Employees.ToList();
            }

            DisplayEmployeesCorrectly(availableEmployees, takenEmployees);
        }
    }
}
