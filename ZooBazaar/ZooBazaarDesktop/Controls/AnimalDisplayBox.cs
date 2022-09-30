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
