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

namespace ZooBazaarDesktop.Forms
{
    public partial class AssignAccountForm : Form
    {
        private readonly Employee subject;
        private Account currentSelection;
        public AssignAccountForm(Employee target)
        {
            InitializeComponent();
            subject = target;
        }

        private void FillAccountListBox(IEnumerable<Account> accounts)
        {
            lbAccounts.Items.AddRange(accounts.ToArray());
        }

        private void OnSelectedAccountChanged(object sender, EventArgs e)
        {
            var selection = lbAccounts.SelectedItem as Account;
            if(selection is not null)
            {
                currentSelection = selection;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Text = $"Assign account to {subject.Name}";
            AccountManager manager = AccountManager.CreateForDatabase();
            var list = manager.GetUnassignedAccounts();
            FillAccountListBox(list);
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            return;
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnAssignClick(object sender, EventArgs e)
        {
            if(currentSelection is null)
            {
                MessageBox.Show("Please select an account.");
                return;
            }
            bool wasAssigned = subject.AssignAccount(currentSelection);

            if (!wasAssigned)
            {
                MessageBox.Show("This employee has an account");
                return;
            }
            else
            {
                EmployeeManager em = EmployeeManager.CreateForDatabase();
                var response = em.UpdateEmployees(subject);
                if (response.Success)
                {
                    MessageBox.Show($"{currentSelection} was assigned to {subject}");
                    Close();
                }
                else
                {
                    MessageBox.Show(response.Message);
                }
            }
        }
    }
}
