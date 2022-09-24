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
    public partial class CreateExhibit : Form
    {
        private MainForm mainForm;
        private ExhibitManager manager = new ExhibitManager(new ZooBazaarDataLayer.DALExhibit.DBExhibit());
        public CreateExhibit(MainForm Origin)
        {
            InitializeComponent();
            foreach(string s in Zones.AllowZones)
            {
                ZonecB.Items.Add(s);
            }
            mainForm = Origin;
        }

        private void CanBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            string name = Nametb.Text;
            int num = (int)CapasityNUD.Value;
            string zone = ZonecB.Text;

            Exhibit exhibit = new Exhibit(name, zone, num, 0);
            manager.AddExhibit(exhibit);
            mainForm.Show();
            Close();
        }
    }
}
