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

namespace ZooBazaarDesktop.Forms
{
    public partial class DetailedExhibitForm : Form
    {
        private Exhibit ex;
        private ExhibitManager manager = new ExhibitManager(new ZooBazaarDataLayer.DALExhibit.DBExhibit());
        public DetailedExhibitForm(Exhibit exhibit)
        {
            InitializeComponent();
            Namelbl.Text = exhibit.Name;
            Zonelabel.Text = exhibit.Zone;
            Capasitylabel.Text = exhibit.Capacity.ToString();
            ANumlbl.Text = exhibit.Count.ToString();
            ex = exhibit;
        }

        private void Deltebutton_Click(object sender, EventArgs e)
        {
            manager.DeleteExhibit(ex);
            //A go back function to Mainpage needs to be added her
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            //A go back function to Mainpage needs to be added her
        }
    }
}
