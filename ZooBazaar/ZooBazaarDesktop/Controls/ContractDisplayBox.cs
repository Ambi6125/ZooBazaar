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
using ZooBazaarDesktop.Colours;

namespace ZooBazaarDesktop.Controls
{
    public partial class ContractDisplayBox : UserControl
    {
        private readonly Contract subject;
        public ContractDisplayBox(Contract c)
        {
            InitializeComponent();
            subject = c;
        }

        private void ContractDisplayBox_Load(object sender, EventArgs e)
        {
            switch (subject.ContractType)
            {
                case ContractType.PartTime:
                    this.BackColor = ZooBazaarColors.ContractColors.PartTime;
                    break;
                case ContractType.FullTime:
                    this.BackColor = ZooBazaarColors.ContractColors.FullTime;
                    break;
                case ContractType.ZeroBased:
                    this.BackColor = ZooBazaarColors.ContractColors.ZeroTime;
                    break;
            }

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
                Datelabel.Text = $"{subject.StartDate.ToString("dd/MM/yy")} - ???";
            }
            else
            {
                Datelabel.Text = $"{subject.StartDate.ToString("dd/MM/yy")} - {subject.EndDate.Value.ToString("dd/MM/yy")}";
            }

            EmpNamelabel.Text = subject.EmployeeName;
        }
    }
}
