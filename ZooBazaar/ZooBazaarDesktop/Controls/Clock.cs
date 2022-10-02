using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazaarDesktop.Controls
{
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
            lblDisplay.Text = DateTime.Now.ToString("hh:mm");
        }

        private void Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = DateTime.Now.ToString("hh:mm");
        }
    }
}
