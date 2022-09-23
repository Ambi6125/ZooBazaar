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

namespace ZooBazaarDesktop.Controls
{
    public partial class SpeciesDisplayBox : UserControl
    {
        private readonly Species species;
        public SpeciesDisplayBox(Species s)
        {
            InitializeComponent();
            species = s;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            lblTitle.Text = species.Name;
            lblScientific.Text = species.ScientificName;
        }
    }
}
