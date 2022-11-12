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
            foreach (Contract contract in em.GetAllEmployeeContracts(employee))
            {
                ContractDisplayBox box = new ContractDisplayBox(contract);
                flpEmployeeContracts.Controls.Add(box);
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
