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
    public partial class UpdateExhibitForm : Form
    {
        private Exhibit ex;
        private readonly ExhibitManager manager = ExhibitManager.CreateForDatabase();
        private readonly DetailedExhibitForm form;
        public UpdateExhibitForm(Exhibit exhibit, DetailedExhibitForm origin)
        {
            InitializeComponent();
            NametextBox.Text = exhibit.Name;
            CapasityUpDown.Value = exhibit.Capacity;
            ex = exhibit;
            form = origin;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            ex.Name = NametextBox.Text;
            ex.Capacity = (int)CapasityUpDown.Value;
            manager.UpdateExhibit(ex);
            form.Show();
            this.Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
    }
}
