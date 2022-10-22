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
using EasyTools.RegexTools;
using ZooBazaarLogicLayer.Managers;

namespace ZooBazaarDesktop.Forms
{
    public partial class AccountEditForm : Form
    {
        private readonly Account subject;
        private readonly MainForm mainForm;
        public AccountEditForm(MainForm origin, Account a)
        {
            InitializeComponent();
            subject = a;
            mainForm = origin;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Text = $"Edit {subject.Username}";
            cbbType.SelectedIndex = (int)subject.AccountType;
            tbEmail.Text = subject.Email;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void OnEmailFocusStopped(object sender, EventArgs e)
        {
            if (RegexToolBox.IsEmail(tbEmail.Text))
            {
                tbEmail.BackColor = Color.LightGreen;
            }
            else
            {
                tbEmail.BackColor = Color.IndianRed;
            }
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            if (!RegexToolBox.IsEmail(tbEmail.Text))
            {
                MessageBox.Show("Not a valid email address");
                return;
            }
            AccountManager am = AccountManager.CreateForDatabase();
            subject.ChangeMail(tbEmail.Text);
            subject.ChangeType((AccountType)cbbType.SelectedIndex);
            var response = am.UpdateAccount(subject);
            MessageBox.Show(response.Message);
            if (response.Success)
            {
                Close();
            }
        }
    }
}
