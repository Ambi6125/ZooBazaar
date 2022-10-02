﻿using System;
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

namespace ZooBazaarDesktop.Controls
{
    public partial class SpeciesDisplayBox : UserControl
    {
        private readonly Species species;

        public Species Topic => species;

        public SpeciesDisplayBox(Species s)
        {
            InitializeComponent();
            species = s;
            Color background = AdjustColor();
            this.panel1.BackColor = background;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            lblTitle.Text = species.Name;
            lblScientific.Text = species.ScientificName;
        }

        private void OnDetailsClick(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)ParentForm;
            parent.Hide();
            new SpeciesDetailsForm(species, parent).Show();
        }

        internal void ResetSelectability()
        {
            cbSelect.Visible = false;
        }

        internal void ToggleSelectability()
        {
            if (cbSelect.Visible)
            {
                cbSelect.Visible = false;
            }
            else
            {
                cbSelect.Visible = true;
            }
        }

        private Color AdjustColor()
        {
            Color result = Color.WhiteSmoke;
            switch (species.Exhibit.Zone.ToLower())
            {
                case "jungle":
                    result = Color.Green;
                    break;
                case "arctic":
                    result = Color.Aqua;
                    break;
                case "taiga":
                    result = Color.Bisque;
                    break;
                case "desert":
                    result = Color.LightGoldenrodYellow;
                    break;
                case "savannah":
                    result = Color.FromArgb(255, 121, 0);
                    break;
                    
            }
            return result;
        }
        internal bool IsSelected => cbSelect.Visible && cbSelect.Checked;
    }
}
