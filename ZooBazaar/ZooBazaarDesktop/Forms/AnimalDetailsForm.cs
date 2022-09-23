using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer.Animals;

namespace ZooBazaarDesktop.Forms
{
    public partial class AnimalDetailsForm : Form
    {
        private readonly Animal subject;
        public AnimalDetailsForm(Animal a)
        {
            InitializeComponent();
            subject = a;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            tbName.Text = subject.Name;
        }
    }
}
