using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooBazaarDesktop.Forms
{
    public partial class CreateContractForm : Form
    {
        private MainForm mainForm;
        private ContractManager manager = ContractManager.CreateForDatabase();
        private EmployeeManager empmanager = EmployeeManager.CreateForDatabase();
        private ContractType type;
        public CreateContractForm(MainForm Origin)
        {
            InitializeComponent();
            mainForm = Origin;
            FillList(empmanager.GetEmployeesWithNoContracts().ToArray());
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {            
            DateTime start = dTPStart.Value;
            DateTime? end;
            if (checkBoxEnd.Checked)
            {
                end = null;
            }
            else
            {
                end = dTPEnd.Value;
            }
            bool active = true;
            //bool active = start.Date == DateTime.Now.Date;
            Contract contract = new Contract(start, end, type, active);

            int num = employeelistbox.SelectedIndex;
            var emp = empmanager.GetEmployeesWithNoContracts();
            //Contract oldcontract = emp.ElementAt(num).CurrentContract;
            //if (oldcontract != null)
            //{
            //    oldcontract.IsActive = false;
            //    manager.UpdateContract(oldcontract);
            //}
            manager.CreateContract(contract);
            var result = manager.AssignContract(emp.ElementAt(num));
            if (result.Success)
            {
                MessageBox.Show("Succesfully created.");
                mainForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show($"Something went wrong: {result.Message}");
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void OnHoursChanged(object sender, EventArgs e)
        {
            switch (cbHours.SelectedIndex)
            {
                case 0:
                    type = ContractType.ZeroBased;
                    break;
                case 1:
                    type = ContractType.PartTime;
                    break;
                case 2:
                    type = ContractType.FullTime;
                    break;
            }
        }

        private void CreateContractForm_Load(object sender, EventArgs e)
        {
            cbHours.SelectedIndex = 0;
        }

        private void FillList(ICollection<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                string name = $"{e.Name} - {e.Email}";
                employeelistbox.Items.Add(name);
            }           
        }
    }
}
