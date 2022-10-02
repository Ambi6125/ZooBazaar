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
using ZooBazaarDesktop.Forms;
using ZooBazaarDataLayer.DALSpecies;
using ZooBazaarDesktop.Colours;

namespace ZooBazaarDesktop.Controls
{
    public partial class AnimalDisplayBox : UserControl
    {
        private readonly Animal animal;
        public Animal Topic => animal;
        public AnimalDisplayBox(Animal a)
        {
            InitializeComponent();
            animal = a;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            lblName.Text = animal.Name;
            lblSpecies.Text = animal.Species.Name;
            lblAge.Text = animal.Age.ToString() + " year(s) old";
            AdjustBackground();
        }

        private void AdjustBackground()
        {
            switch (animal.Status.ToLower())
            {
                case "in zoo":
                    this.BackColor = ZooBazaarColors.StatusColors.InZoo;
                    break;
                case "deceased":
                    this.BackColor = ZooBazaarColors.StatusColors.Deceased;
                    break;
                case "transferred":
                    this.BackColor = ZooBazaarColors.StatusColors.Transferred;
                    break;
                case "released":
                    this.BackColor= ZooBazaarColors.StatusColors.Released;
                    break;
            }
        }

        private void OnDetailsClick(object sender, EventArgs e)
        {
            new AnimalDetailsForm(animal).Show();
        }
        internal void ToggleAnimalsSelectability()
        {
            if (cbAnimalSelect.Visible)
            {
                cbAnimalSelect.Visible = false;
            }
            else
            {
                cbAnimalSelect.Visible = true;
            }
        }
        internal bool IsSelectedAnimal => cbAnimalSelect.Visible && cbAnimalSelect.Checked;
    }
}
