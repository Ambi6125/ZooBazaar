using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Managers;

namespace ZooBazaarDesktop.Forms
{
    public partial class AnimalDetailsForm : Form
    {
        private readonly Animal subject;
        public AnimalDetailsForm(Animal a)
        {
            InitializeComponent();
            subject = a;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            tbName.Text = subject.Name;
            tbSpecies.Text = subject.Species.Name;
            dtpAnimalUpdate.Value = Convert.ToDateTime(subject.BirthDay);
            tbZooStatus.Text = subject.Status;
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void OnAnimalUpdateClick(object sender, EventArgs e)
        {
            AnimalManager am = AnimalManager.CreateForDatabase();
            DialogResult dr = DialogResult.None; //The value of this is checked later
            do
            {
                subject.Name = tbName.Text;
                subject.ChangeBirthDay(dtpAnimalUpdate.Value.Date);
                subject.ChangeStatus(tbZooStatus.Text);
                var response = am.UpdateAnimals(subject);
                if (response.Success)
                {
                    dr = MessageBox.Show("Data was succesfully saved.\nWould you like to close this form now?",
                        "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    dr = MessageBox.Show(response.Message, "Operation failed", MessageBoxButtons.RetryCancel); ;
                }
            } while (dr == DialogResult.Retry); //dr is either yes or no after this loop.

            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
