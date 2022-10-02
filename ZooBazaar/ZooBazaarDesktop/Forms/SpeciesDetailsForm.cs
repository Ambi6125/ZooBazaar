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
using ZooBazaarLogicLayer.Zones;
using ZooBazaarLogicLayer.Managers;

namespace ZooBazaarDesktop.Forms
{
    public partial class SpeciesDetailsForm : Form
    {
        private Species subject;
        private MainForm parent;
        public SpeciesDetailsForm(Species target, MainForm parent)
        {
            InitializeComponent();
            subject = target;
            foreach (string s in Zones.AllowedZones)
            {
                cbbZones.Items.Add(s);
            }

            this.parent = parent;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            tbSpeciesName.Text = subject.Name;
            tbScientificName.Text = subject.ScientificName;
            tbAmount.Text = subject.Quantity.ToString();
            cbbZones.Text = subject.Exhibit.Zone;
            //TODO: Allow the editing of which exhibit in the specified zone the animal is in
            if (subject.IsSingleAnimal)
            {
                tbUnitSize.Text = "Yes";
            }
            else
            {
                tbUnitSize.Text = "No";
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                parent.Show();
            }
            else
            {
                parent.Close();
            }
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            ExhibitManager em = ExhibitManager.CreateForDatabase();
            DialogResult dr = DialogResult.None; //The value of this is checked later
            do
            {
                subject.Name = tbSpeciesName.Text;
                subject.ScientificName = tbScientificName.Text;
                Exhibit exhibit = em.GetByFullName(cbbZones.Text, cbbExhibitName.Text).First();
                subject.ChangeExhibit(exhibit);
                var response = sm.UpdateSpecies(subject);
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

            if(dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void OnZoneSelectionChanged(object sender, EventArgs e)
        {
            cbbExhibitName.Items.Clear();
            ExhibitManager em = ExhibitManager.CreateForDatabase();
            foreach (var exhibit in em.GetByZone(cbbZones.Text))
            {
                cbbExhibitName.Items.Add(exhibit.Name);
            }
        }
    }
}
