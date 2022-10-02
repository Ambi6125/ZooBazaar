using EasyTools.Validation;
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
using ZooBazaarLogicLayer.Zones;
using ZooBazaarLogicLayer.Animals;

namespace ZooBazaarDesktop.Forms
{
    public partial class CreateSpeciesForm : Form
    {
        private MainForm mainForm;
        public CreateSpeciesForm(MainForm origin)
        {
            InitializeComponent();
            mainForm = origin;
        }

        private string UnitSizeSelected
        {
            get
            {
                if (rbSingle.Checked)
                    return "single";

                else if (rbMass.Checked)
                    return "mass";

                else
                {
                    return string.Empty;
                }
            }
        }
        private IValidationResponse InputValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    return new ValidationResponse(false, "Please enter a name for the species");
                }
                else if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    return new ValidationResponse(false, "Please enter the species' scientific name");
                }
                else if (string.IsNullOrWhiteSpace(cbbZone.Text) || string.IsNullOrWhiteSpace(cbbExhibitName.Text))
                {
                    return new ValidationResponse(false, "Please specify the exhibit.");
                }
                else if (UnitSizeSelected == String.Empty)
                {
                    return new ValidationResponse(false, "Please specify the unit size.");
                }

                return new ValidationResponse(true, string.Empty);
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }

        private void OnCreateClick(object sender, EventArgs e)
        {
            var inputValidation = InputValid;
            if(inputValidation.Success == false)
            {
                MessageBox.Show(inputValidation.Message);
                return;
            }
            ExhibitManager em = ExhibitManager.CreateForDatabase();
            Exhibit exhibit = em.GetByFullName(cbbZone.Text, cbbExhibitName.Text).First();

            Species newSpecies = new Species(tbName.Text, tbScientificName.Text, exhibit, UnitSizeSelected, 0);
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            var response = sm.AddSpecies(newSpecies);
            if (response.Success)
            {
                MessageBox.Show("Succesfully added!");
                mainForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            foreach(string s in Zones.AllowedZones)
            {
                cbbZone.Items.Add(s);
            }
        }

        private void OnSelectedZoneChanged(object sender, EventArgs e)
        {
            cbbExhibitName.Items.Clear();
            try
            {
                ExhibitManager em = ExhibitManager.CreateForDatabase();
                var result = em.GetByZone(cbbZone.SelectedItem.ToString());
                foreach(var item in result)
                {
                    cbbExhibitName.Items.Add(item.Name);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Please reconnect to your VPN and try again.");
            }
        }
    }
}
