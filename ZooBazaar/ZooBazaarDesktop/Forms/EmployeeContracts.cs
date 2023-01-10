using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarDesktop.Controls;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarDesktop.Forms
{
    public partial class EmployeeContracts : Form
    {
        private readonly Employee employee;
        private readonly MainForm origin;
        public EmployeeContracts(Employee e, MainForm source)
        {
            InitializeComponent();
            employee = e;
            this.origin = source;   
        }

        private void OnLoad(object sender, EventArgs e)
        {
            flpEmployeeContracts.Controls.Clear();
            EmployeeManager em = EmployeeManager.CreateForDatabase();
            var allcontracts = em.GetAllEmployeeContracts(employee);
            if(allcontracts.Any())
            {
                foreach (Contract contract in allcontracts)
                {
                    ContractDisplayBox box = new ContractDisplayBox(contract);
                    flpEmployeeContracts.Controls.Add(box);
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("This Employee has no Contract.\nWould you like to close this Form?", "No Contracts", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e)
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
