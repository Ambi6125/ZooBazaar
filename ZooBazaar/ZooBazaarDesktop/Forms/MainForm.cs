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
using ZooBazaarLogicLayer.Zones;

namespace ZooBazaarDesktop.Forms
{
    public partial class MainForm : Form
    {
        private Action? exhibitsearch;
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

        private void CExhibitbtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //CreateExhibit form = new CreateExhibit();
            //form.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            exhibitsearch();
        }

        private void fillExhibitList(ICollection<Exhibit> e)
        {
            FLPExhibits.Controls.Clear();
            foreach(Exhibit ex in e)
            {
                FLPExhibits.Controls.Add(new ExhibitDispalyBox(ex));
            }
        }

        private void fillExhibitList(Exhibit e)
        {
            FLPExhibits.Controls.Clear();
            FLPExhibits.Controls.Add(new ExhibitDispalyBox(e));
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

        #region Filters
        private void SearchById()
        {
            ExhibitManager manager = new ExhibitManager(new ZooBazaarDataLayer.DALExhibit.DBExhibit());
            Exhibit resault = manager.SearchById(Convert.ToInt32(Searchtb.Text));
            fillExhibitList(resault);
        }

        private void SearchByZone()
        {
            ExhibitManager manager = new ExhibitManager(new ZooBazaarDataLayer.DALExhibit.DBExhibit());
            var resault = manager.GetByZone(Searchtb.Text);

            fillExhibitList(resault.ToList());
        }

        private void SearchByName()
        {
            ExhibitManager manager = new ExhibitManager(new ZooBazaarDataLayer.DALExhibit.DBExhibit());
            var resault = manager.GetByName(Searchtb.Text);

            fillExhibitList(resault.ToList());
        }

        private void NoFilter()
        {
            MessageBox.Show("No Filter Selected");
        }
        #endregion

        //Dont forghet to add a Control for Exhibits
    }
}
