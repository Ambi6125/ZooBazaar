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
        public AddShiftsForm()
        {
            InitializeComponent();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            ShiftType type = (ShiftType)cbbType.SelectedIndex;
            DateTime date = dtpDate.Value;
            Employee? emp = default;
            try
            {
                emp = lbEmployees.SelectedItem as Employee;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            ShiftManager manager = ShiftManager.CreateForDatabase();
            var existingShift = manager.GetByDateAndType(date, type);

            if(existingShift is null)
            {
                Shift newShift = new Shift(date, type);
                manager.AddShift(newShift);

                int recentId = manager.GetRecentId();

                var relationship = new ZooBazaarDataLayer.DALScheduling.DALShift.ShiftEmployeeRelationShip(emp.ID.Value, recentId);
                manager.Register(relationship);
            }
            else
            {
                manager.Register(existingShift, emp);
            }
        }
    }
}
