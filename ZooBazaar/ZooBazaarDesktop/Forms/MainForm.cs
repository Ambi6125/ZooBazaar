using System;
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

namespace ZooBazaarDesktop.Forms
{
    public partial class MainForm : Form
    {
        
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

        private void OnSpeciesSearch(object sender, EventArgs e)
        {
            SpeciesManager sm = new SpeciesManager(new ZooBazaarDataLayer.DALSpecies.DBSpecies());

            IReadOnlyCollection<Species> allResults = sm.GetSpeciesByName(tbNameSearch.Text);
            if(allResults.Count > 0)
            {
                flpDisplayResult.Controls.Clear();
                foreach (Species s in allResults)
                {

                    flpDisplayResult.Controls.Add(new SpeciesDisplayBox(s));
                }
            }
            else
            {
                MessageBox.Show("No results found.");
            }
            
        }
    }
}
