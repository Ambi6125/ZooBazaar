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

namespace ZooBazaarDesktop.Controls
{
    public partial class ContractDisplayBox : UserControl
    {
        private readonly Contract subject;
        private string name;
        public ContractDisplayBox(Contract c, string name)
        {
            InitializeComponent();
            subject = c;
            this.name = name;
        }

        private void ContractDisplayBox_Load(object sender, EventArgs e)
        {
            if (subject.IsActive)
            {
                isActivelabel.Text = "Active";
            }
            else
            {
                isActivelabel.Text = "Non Active";
            }

            if(subject.EndDate == null)
            {
                Datelabel.Text = $"{subject.StartDate} - ???";
            }
            else
            {
                Datelabel.Text = $"{subject.StartDate} - {subject.EndDate}";
            }

            EmpNamelabel.Text = name;
        }
    }
}
