using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer.Zones;

namespace ZooBazaarDesktop.Controls
{
    public partial class ExhibitDispalyBox : UserControl
    {
        private Exhibit sub;
        public ExhibitDispalyBox(Exhibit e)
        {
            InitializeComponent();
            sub = e;
        }

        private void ExhibitDispalyBox_Load(object sender, EventArgs e)
        {
            Namelabel.Text = sub.Name;
            Zonelabel.Text = sub.Zone;
        }

        private void Detailbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
