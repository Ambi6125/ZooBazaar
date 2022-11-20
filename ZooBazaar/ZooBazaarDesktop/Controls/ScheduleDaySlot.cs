using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarDesktop.Controls
{
    public partial class ScheduleDaySlot : UserControl
    {
        private readonly Shift subject;
        public ScheduleDaySlot(Shift shift)
        {
            InitializeComponent();
            subject = shift;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(169, 206, 249);
            switch (subject.ShiftType)
            {
                case ShiftType.Morning:
                    lblShiftType.Text = "Morning";
                    break;
                case ShiftType.Afternoon:
                    lblShiftType.Text = "Afternoon";
                    break;
                case ShiftType.Evening:
                    lblShiftType.Text = "Evening";
                    break;
                default:
                    throw new InvalidOperationException("Unrecognized shift type");
            }
            lbWorkingEmployees.Items.AddRange(subject.Employees.ToArray());
        }

        private void OnEditClick(object sender, EventArgs e)
        {

        }
    }
}
