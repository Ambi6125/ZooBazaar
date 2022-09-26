﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarDesktop.Controls;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.Zones;

namespace ZooBazaarDesktop.Forms
{
    public partial class MainForm : Form
    {
        private Action? exhibitsearch;
        private Action? speciesSearch;
        private readonly LoginForm origin;
        public MainForm(LoginForm origin)
        {
            InitializeComponent();
            this.origin = origin;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                origin.Show();
            }
            else
            {
                origin.Close(); //If the form closes due to unexpected reasons, close the parent form too
            }
        }

        #region Species tab UI
        private void OnSpeciesSearch(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSpeciesSearchInput.Text))
            {
                MessageBox.Show("Please input a search term.");
                return;
            }

            if(speciesSearch is not null)
            {
                speciesSearch();
            }
            else
            {
                NoSpeciesSearch();
            }
        }

        private void RefillSpeciesList(ICollection<Species> species)
        {
            flpSpecies.Controls.Clear();
            foreach(Species s in species)
            {
                flpSpecies.Controls.Add(new SpeciesDisplayBox(s));
            }
            DisplaySpeciesResultCount(species.Count);
        }
        private void RefillSpeciesList(Species? species)
        {
            flpSpecies.Controls.Clear();
            if (species is not null)
            {
                flpSpecies.Controls.Add(new SpeciesDisplayBox(species));
                DisplaySpeciesResultCount(1);
            }
            else
            {
                DisplaySpeciesResultCount(0);
            }
        }

        private void OnAddSpeciesButtonClicked(object sender, EventArgs e)
        {
            new CreateSpeciesForm(this).Show();
            Hide();
        }

        private void ToggleSpeciesSelectables(object sender, EventArgs e)
        {
            foreach(SpeciesDisplayBox db in flpSpecies.Controls)
            {
                db.ToggleSelectability();
            }
            if(btnDelete.Enabled)
                btnDelete.Enabled = false;
            else
                btnDelete.Enabled = true;
        }

        private void OnSpeciesDeleteClick(object sender, EventArgs e)
        {
            IEnumerable<SpeciesDisplayBox> boxes = flpSpecies.Controls
                .OfType<SpeciesDisplayBox>()
                .Where((SpeciesDisplayBox x) => x.IsSelected);

            if (!boxes.Any())
            {
                MessageBox.Show("No selection given.");
                return;
            }

            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            foreach(SpeciesDisplayBox x in boxes)
            {
                var response = sm.DeleteSpecies(x.Topic);
                if(response.Success == false)
                {
                    MessageBox.Show(response.Message);
                }
            }
            MessageBox.Show("Deleted succesfully.");
        }

        private void DisplaySpeciesResultCount(int count)
        {
            lblResultCount.Text = $"{count} result(s) for \"{tbSpeciesSearchInput.Text}\".";
        }

        private void OnSpeciesFilterMethodUpdated(object sender, EventArgs e)
        {
            switch (cbbSpeciesFilter.SelectedItem)
            {
                case "ID":
                    speciesSearch = SpeciesIdSearch;
                    break;
                case "Name":
                    speciesSearch = SpeciesNameSearch;
                    break;
                default:
                    speciesSearch = NoSpeciesSearch;
                    break;
            }
        }
        #endregion

        #region Exhibit tab UI

        private void CExhibitbtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //CreateExhibit form = new CreateExhibit(MainForm form);
            //form.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            exhibitsearch();
        }

        private void FillExhibitList(ICollection<Exhibit> e)
        {
            FLPExhibits.Controls.Clear();
            foreach(Exhibit ex in e)
            {
                FLPExhibits.Controls.Add(new ExhibitDisplayBox(ex));
            }
        }

        private void fillExhibitList(Exhibit e)
        {
            FLPExhibits.Controls.Clear();
            FLPExhibits.Controls.Add(new ExhibitDisplayBox(e));
        }

        private void FilterMethod(object sender, EventArgs e)
        {
            switch (Searchtb.Text)
            {
                case "id":
                    exhibitsearch = SearchById;
                    break;
                case "zone":
                    exhibitsearch = SearchByZone;
                    break;
                case "name":
                    exhibitsearch = SearchByName;
                    break;
                default:
                    exhibitsearch = NoFilter;
                    break;
            }
        }
        #endregion

        #region Exhibit Filters
        private void SearchById()
        {
            ExhibitManager manager = ExhibitManager.CreateForDatabase();
            Exhibit resault = manager.SearchById(Convert.ToInt32(Searchtb.Text));
            fillExhibitList(resault);
        }

        private void SearchByZone()
        {
            ExhibitManager manager = ExhibitManager.CreateForDatabase();
            var resault = manager.GetByZone(Searchtb.Text);

            FillExhibitList(resault.ToList());
        }

        private void SearchByName()
        {
            ExhibitManager manager = ExhibitManager.CreateForDatabase();
            var resault = manager.GetByName(Searchtb.Text);

            FillExhibitList(resault.ToList());
        }

        private void NoFilter()
        {
            MessageBox.Show("No Filter Selected");
        }
        #endregion

        #region Species Filters

        private void SpeciesIdSearch()
        {
            string inputValue = tbSpeciesSearchInput.Text;
            int id;

            if(!int.TryParse(inputValue, out id))
            {
                MessageBox.Show("Please enter a numeric id.", "ZooBazaar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } //Check if input is numeric

            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            var result = sm.GetById(id);
            RefillSpeciesList(result);
        }

        private void SpeciesNameSearch()
        {
            string inputValue = tbSpeciesSearchInput.Text;
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            var result = sm.GetSpeciesByName(inputValue);
            RefillSpeciesList(result.ToArray());
        }

        private void NoSpeciesSearch()
        {
            MessageBox.Show("Someting went wrong. Please select something to filter by.");
        }
        #endregion

        #region Animal Filters
        //TODO: Add animal searches in this area

        #endregion


        /// <summary>
        /// Runs whenever the form is loaded in.
        /// </summary>
        private void OnLoad(object sender, EventArgs e)
        {
            lblResultCount.Text = string.Empty;
        }

        
    }
}
