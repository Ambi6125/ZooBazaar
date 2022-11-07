using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer.People;
using ZooBazaarDesktop.Forms;
using ZooBazaarDesktop.Colours;
using ZooBazaarDataLayer.DALEmployee;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarDataLayer.DALAnimal;

namespace ZooBazaarDesktop.Controls
{
    public partial class EmployeeDisplayBox : UserControl
    {
        private readonly Employee employee;
        public EmployeeDisplayBox(Employee e)
        {
            InitializeComponent();
            employee = e;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            lblName.Text = employee.Name;
            lblAge.Text = employee.Age.ToString() + " year(s) old";
        }

        private void btnDetailsClick(object sender, EventArgs e)
        {
            new EmployeeDetailsForm(employee, (MainForm)ParentForm).Show();
        }

        private void OnViewContractsClick(object sender, EventArgs e)
        {

        }
    }
}
