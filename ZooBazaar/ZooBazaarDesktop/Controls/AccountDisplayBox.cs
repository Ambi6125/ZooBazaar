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

namespace ZooBazaarDesktop.Controls
{
    public partial class AccountDisplayBox : UserControl
    {
        private readonly Account subject;
        public AccountDisplayBox(Account a)
        {
            InitializeComponent();
            subject = a;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            grpbUser.Text = subject.Email;
            lblUsername.Text = subject.Username;
        }

        private void OnEditClick(object sender, EventArgs e)
        {
            AccountEditForm editorForm = new AccountEditForm((MainForm)ParentForm, subject);
            editorForm.Show();
        }
    }
}
