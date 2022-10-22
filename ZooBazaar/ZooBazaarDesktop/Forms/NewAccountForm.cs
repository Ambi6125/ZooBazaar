using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTools.Algorithms;
using ZooBazaarLogicLayer.Managers;
using EasyTools.RegexTools;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.PasswordHandling;
using ZooBazaarLogicLayer.Mail.Presets;
using ZooBazaarLogicLayer.Mail;

namespace ZooBazaarDesktop.Forms
{
    public partial class NewAccountForm : Form
    {
        private string usernameSeed;

        private string Username => tbPrefix.Text + tbUsername.Text;
        private readonly MainForm mainForm;
        public NewAccountForm(MainForm origin)
        {
            InitializeComponent();
            mainForm = origin;
            SetValidSeed();
        }

        private bool InvalidUsername(string username)
        {
            AccountManager manager = AccountManager.CreateForDatabase();
            return manager.UsernameIsTaken(username);
        }

        /// <summary>
        /// Generates a username until an available one is generated.
        /// </summary>
        private void SetValidSeed()
        {
            do
            {
                GenerateUsername();
            } while (InvalidUsername(Username));
        }

        private bool AllInputValid =>
            !string.IsNullOrWhiteSpace(tbUsername.Text)
            && !string.IsNullOrWhiteSpace(tbEmail.Text)
            && RegexToolBox.IsEmail(tbEmail.Text);

        /// <summary>
        /// Sets the username seed to a random string of 8 digits.
        /// </summary>
        private void GenerateUsername()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= 8; i++)
            {
                int number = EasyTools.Algorithms.Generate.NewInt(0, 10);
                sb.Append(number.ToString());
            }
            usernameSeed = sb.ToString();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            tbUsername.Text = usernameSeed;
            cbbType.SelectedIndex = 0;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void OnRerollClick(object sender, EventArgs e)
        {
            SetValidSeed();
            tbUsername.Text = usernameSeed;
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

        private void OnCreateClick(object sender, EventArgs e)
        {
            if (!AllInputValid)
            {
                MessageBox.Show("Not every field is correctly filled in.");
                return;
            }
            string password;
            if (!string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                password = tbPassword.Text;
            }
            else
            {
                password = ZooBazaarLogicLayer.PasswordHandling.Generate.NewString(8);
            }

            Account newAccount = new Account(Username, password, PasswordHelper.DefaultHash, tbEmail.Text, (AccountType)cbbType.SelectedIndex);

            AccountManager am = AccountManager.CreateForDatabase();
            var dbResponse = am.AddAccount(newAccount);

            if(dbResponse.Success == false)
            {
                MessageBox.Show("Could not succesfully register the account.");
                return;
            }

            MailWriter mailWriter = new MailWriter("noreplyzoobazaar@gmail.com");
            mailWriter.Configure(new AccountCreationPreset(newAccount, password));
            mailWriter.Receiver = newAccount.Email;
            var mailResponse = mailWriter.Send();
            if (mailResponse.Success)
            {
                MessageBox.Show("Succesfully created account.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("The account was saved, but could a mail could not be sent.\nDelete the account?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    //TODO: implement delete
                    var response = am.DeleteAccount(newAccount);

                    MessageBox.Show(response.Message);
                }
            }
        }
    }
}