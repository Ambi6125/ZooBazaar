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
        private ExhibitManager manager = ExhibitManager.CreateForDatabase();
        private readonly MainForm mainForm;
        public DetailedExhibitForm(Exhibit exhibit, MainForm form)
        {
            InitializeComponent();
            ex = exhibit;
            mainForm = form;
        }

        private void Deltebutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                var result = manager.DeleteExhibit(ex);
                if (result.Success)
                {
                    MessageBox.Show(result.Message);
                    mainForm.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong when deleting.");
                }
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            Hide();
            new UpdateExhibitForm(ex, this).Show();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Namelbl.Text = ex.Name;
            Zonelabel.Text = ex.Zone;
            Capasitylabel.Text = ex.Capacity.ToString();
            ANumlbl.Text = ex.Count.ToString();
        }
    }
}
