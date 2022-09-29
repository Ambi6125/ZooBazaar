using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Managers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ZooBazaarDesktop.Forms
{
    public partial class AnimalCreateForm : Form
    {
        private readonly MainForm mainForm;
        public AnimalCreateForm(MainForm origin)
        {
            InitializeComponent();
            mainForm = origin;
        }

        private void OnAnimalCreateClick(object sender, EventArgs e)
        {
           
            
            DialogResult dr = DialogResult.None; //The value of this is checked later
            do
            {
                AnimalManager am = AnimalManager.CreateForDatabase();
                SpeciesManager sm = SpeciesManager.CreateForDatabase();
                Species species = sm.GetSpeciesByName(cbbAnimalSpeciesCreate.SelectedItem.ToString()).FirstOrDefault();
                Animal animal = new Animal(tbAnimalNameCreate.Text, dtpAnimalCreate.Value.Date, species);
                var response = am.CreateAnimal(animal);
                if (response.Success)
                {

                    species.IncreaseQuantity(1);
                    var speciesresponse = sm.UpdateSpecies(species);
                    if (speciesresponse.Success)
                    {
                        dr = MessageBox.Show("Data was succesfully saved.\nWould you like to close this form now?",
                                                "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        dr = MessageBox.Show(response.Message, "Operation failed", MessageBoxButtons.RetryCancel); ;
                    }
                    
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

        private void OnLoad(object sender, EventArgs e)
        {
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            var result = sm.GetSpeciesByName(string.Empty);
            foreach (Species species in result)
            {
                cbbAnimalSpeciesCreate.Items.Add(species);
            }
        }
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                mainForm.Show();
            }
            else
            {
                mainForm.Close();
            }
        }
    }
}
