using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarDesktop.Forms
{
    public partial class EmployeeDetailsForm : Form
    {
        private readonly Employee subject;
        private readonly MainForm origin;
        public EmployeeDetailsForm(Employee e, MainForm o)
        {
            InitializeComponent();
            subject = e;        
            origin = o;
;
        }
        private void OnLoad(object sender, EventArgs e)
        {
            txtbUpdateEmployeeName.Text = subject.Name;
            txtbUpdateEmployeeAddress.Text = subject.Address;
            txtbUpdateEmployeePhoneNumber.Text = subject.PhoneNumber;
            txtbUpdateEmployeeEmail.Text = subject.Email;
            dtpUpdateEmployeeBirthDate.Value = Convert.ToDateTime(subject.BirthDay);
        }
        private void OnUpdateEmployeeClick(object sender, EventArgs e)
        {
            EmployeeManager em = EmployeeManager.CreateForDatabase();
            DialogResult dr = DialogResult.None; //The value of this is checked later
            do
            {
                subject.Name = txtbUpdateEmployeeName.Text;
                subject.ChangeAddress(txtbUpdateEmployeeAddress.Text);
                subject.ChangePhoneNumber(txtbUpdateEmployeePhoneNumber.Text);
                subject.ChangeEmail(txtbUpdateEmployeeEmail.Text);
                subject.ChangeBirthDay(dtpUpdateEmployeeBirthDate.Value.Date);
                var response = em.UpdateEmployees(subject);
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
                origin.Show();
            }
            else
            {
                origin.Close();
            }
        }
    }
}
