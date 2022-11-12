using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarDesktop.Forms
{
    public partial class CreateEmployeeForm : Form
    {
        private readonly MainForm mainForm;
        public CreateEmployeeForm(MainForm origin)
        {
            InitializeComponent();
            mainForm = origin;
        }

        private void OnCreateEmployeeClick(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.None; //The value of this is checked later
            do
            {
                EmployeeManager em =  EmployeeManager.CreateForDatabase();
                Employee employee = new Employee(txtCreateEmployeeName.Text,txtCreateEmployeeAddress.Text,txtCreateEmployeePhoneNumber.Text, txtCreateEmployeeEmail.Text, dtpCreateEmployeeBirthDate.Value.Date,false);
                var response = em.CreateEmployee(employee);
                if (response.Success)
                {
                    dr = MessageBox.Show("Data was succesfully saved.\nWould you like to close this form now?",
                                                "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    dr = MessageBox.Show(response.Message, "Operation failed", MessageBoxButtons.RetryCancel); ;
                }
            } while (dr == DialogResult.Retry); //dr is either yes or no after this loop.

            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                mainForm.Show();
            }
            else
            {
                mainForm.Close();
            }
        }
    }
}
