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
            FillList(empmanager.GetEmployeesThatCanGetAContract().ToArray());
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
            
            Employee selectedemployee = (Employee)employeelistbox.SelectedItem;
            Contract[] selectedEmployeesContracts = manager.GetByEmployeeName(selectedemployee.Name).ToArray();
            Func<Contract, bool> contractHasNoEndDate = c => c.EndDate is null;
            if(selectedEmployeesContracts.Any(contractHasNoEndDate))
            {
                var oldContract = selectedEmployeesContracts.Single(contractHasNoEndDate);
                oldContract.EndDate = DateTime.Today;
                manager.UpdateContract(oldContract);
            }
            
            Contract newContract = new Contract(start, end, type, selectedemployee);            
            var result = manager.CreateContract(newContract);            
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
                employeelistbox.Items.Add(e);
            }           
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
