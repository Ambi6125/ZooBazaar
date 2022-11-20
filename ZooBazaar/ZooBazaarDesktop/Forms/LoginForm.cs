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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            Func<string, Account?>? searchmethod;
            AccountManager am = AccountManager.CreateForDatabase();
            string input = tbUsername.Text;


            if (input.StartsWith("ZB-"))
            {
                searchmethod = am.GetByUsernameExact;
            }
            else if (EasyTools.RegexTools.RegexToolBox.IsEmail(input))
            {
                searchmethod = am.GetByEmail;
            }
            else //If not a username or an email is put in, return early.
            {
                MessageBox.Show("Unrecognized login method.\nPlease enter your username or email.");
                return;
            }

            Account? loginAttempt = searchmethod(input);

            //Check if a result was found. If not, return early.
            if(loginAttempt is null)
            {
                MessageBox.Show("Invalid data");
                return;
            }

            //Check for password
            if(loginAttempt.PasswordIsCorrect(tbPassword.Text, ZooBazaarLogicLayer.PasswordHandling.PasswordHelper.DefaultHash))
            {
                UILogic.SessionSimulator.LoggedAccount = loginAttempt;

                Hide();
                new MainForm(this).Show();
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }
        }
    }
}
