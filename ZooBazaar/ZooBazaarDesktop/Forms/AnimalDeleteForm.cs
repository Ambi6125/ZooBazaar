using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Managers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Console;


namespace ZooBazaarDesktop.Forms
{
    public partial class AnimalDeleteForm : Form
    {
        private readonly Animal subject;
        private readonly MainForm origin;
        public AnimalDeleteForm(Animal a,MainForm mainform)
        {
            InitializeComponent();
            subject = a;
            origin = mainform;
        }

        private void OnAnimalRemoveClick(object sender, EventArgs e)
        {
            
            DialogResult dr = DialogResult.None; //The value of this is checked later
            do
            {
                AnimalManager am = AnimalManager.CreateForDatabase();
                
                var response = am.DeleteAnimal(subject);
                if (response.Success)
                {
                    dr = MessageBox.Show("Data was succesfully saved.\nWould you like to close this form now?",
                        "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    dr = MessageBox.Show(response.Message, "Operation failed", MessageBoxButtons.RetryCancel); ;
                }
            } while (dr == DialogResult.Retry); //dr is either yes or no after this loop.

            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            cbbAnimalStatus.Items.Clear();
            cbbAnimalStatus.Items.Add(subject.AvailableStatuses[0]);
            cbbAnimalStatus.Items.Add(subject.AvailableStatuses[1]);
            cbbAnimalStatus.Items.Add(subject.AvailableStatuses[2]);
            //cbbAnimalStatus.Items.Add(subject.AvailableStatuses[3]);
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                origin.Show();
            }
            else
            {
                origin.Close();
            }
        }
    }
}
