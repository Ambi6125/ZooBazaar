using MySqlX.XDevAPI.Common;
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
    public partial class CreateContractForm : Form
    {
        private MainForm mainForm;
        private ContractManager manager = ContractManager.CreateForDatabase();
        public CreateContractForm(MainForm Origin)
        {
            InitializeComponent();
            mainForm = Origin;
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            ContractType type;
            if (cbHours.Text == "Zero Based - 0 hours")
            {
               type = ContractType.ZeroBased;
            }
            else if(cbHours.Text == "Part Time - 32 hours")
            {
                type = ContractType.PartTime;
            }
            else if(cbHours.Text == "Full Time - 40 hours")
            {
                type = ContractType.FullTime;
            }
            else //this needs to change
            {
                type = ContractType.ZeroBased;
            }

            DateTime start = dTPStart.Value;
            DateTime? end;

            if (checkBoxEnd.Checked)
            {
                end = null;
            }
            else
            {
                end = dTPEnd.Value;
            }            

            bool active = false;

            if (chbActiveStatus.Checked)
            {
                active = true;
            }
            else if (chbNonActiveStatus.Checked)
            {
                active = false;
            }

            Contract contract = new Contract(start, end, type, active);
            var result = manager.CreateContract(contract);
            if (result.Success)
            {
                MessageBox.Show("Succesfully created.");
                mainForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show($"Something went wrong: {result.Message}");
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }
    }
}
