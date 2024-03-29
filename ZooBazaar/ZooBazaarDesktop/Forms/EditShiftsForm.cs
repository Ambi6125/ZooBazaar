﻿using EasyTools.Validation;
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
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarDesktop.Forms
{
    public partial class EditShiftsForm : Form
    {
        private readonly MainForm mainForm;
        public EditShiftsForm(MainForm source)
        {
            InitializeComponent();
            this.mainForm = source;
        }

        private void DisplayEmployeesCorrectly(IEnumerable<Employee> available, IEnumerable<Employee> taken)
        {
            lbEmployeesAvailable.Items.Clear();
            lbEmployeesUsed.Items.Clear();
            foreach (Employee emp in available)
            {
                lbEmployeesAvailable.Items.Add(emp);
            }
            foreach(Employee emp in taken)
            {
                lbEmployeesUsed.Items.Add(emp);
            }
        }
        private void OnAddClick(object sender, EventArgs e)
        {
            ShiftType type = (ShiftType)cbbType.SelectedIndex;
            DateTime date = dtpDate.Value;
            Shift finalshift;
            Employee? emp = default;
            try
            {
                emp = (Employee?)lbEmployeesAvailable.SelectedItem;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            ShiftManager manager = ShiftManager.CreateForDatabase();
            var existingShift = manager.GetByDateAndType(date, type);
            IValidationResponse response;
            if(emp is null)
            {
                MessageBox.Show("No selection.");
                return;
            }
            if(existingShift is null)
            {
                Shift newShift = new Shift(date, type);
                manager.AddShift(newShift);
                finalshift = newShift;
                int recentId = manager.GetRecentId();

                var relationship = new ZooBazaarDataLayer.DALScheduling.DALShift.ShiftEmployeeRelationShip(emp.ID.Value, recentId);
                response = manager.Register(relationship);
            }
            else
            {
                response = manager.Register(existingShift, emp);
                finalshift = existingShift;
            }
            if (response.Success)
            {
                lbLog.Items.Add($"{finalshift}: added {emp.Name}");
                Search(sender, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                mainForm.Show();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }


        private void Search(object sender, EventArgs e)
        {
            ShiftManager sm = ShiftManager.CreateForDatabase();            
            List<Employee> availableEmployees = Enumerable.Empty<Employee>().ToList();
            List<Employee> takenEmployees = Enumerable.Empty<Employee>().ToList();

            try
            {
                Shift? selectedShift = sm.GetByDateAndType(dtpDate.Value, (ShiftType)cbbType.SelectedIndex);


                if (selectedShift is not null)
                {
                    takenEmployees = sm.GetEmployeesFromShift(selectedShift).ToList();
                    if (takenEmployees != null)
                    {
                        availableEmployees = sm.GetEmployeesThatCanWork(selectedShift).ToList();
                    }

                    availableEmployees.RemoveAll(x => takenEmployees.Contains(x));
                }
                else
                {
                    Shift shift = new Shift(dtpDate.Value, (ShiftType)cbbType.SelectedIndex);
                    availableEmployees = sm.GetEmployeesThatCanWork(shift).ToList();
                }

                DisplayEmployeesCorrectly(availableEmployees, takenEmployees);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid data.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #region comented code
            //EmployeeManager em = EmployeeManager.CreateForDatabase();
            // this contains all the employees with an active contract
            //Shift previoushift = sm.GetPreviousShift(selectedShift);
            //if(previoushift != null)
            //{
            //    List<Employee> employeesfrompreviousshift = sm.GetEmployeesFromShift(previoushift).ToList();
            //    availableEmployees.RemoveAll(e => employeesfrompreviousshift.Contains(e));
            //}

            //if (selectedShift is not null) //No shift exists here yet
            //{
            //    takenEmployees = selectedShift.Employees.ToList();
            //    Shift? previousShift = sm.GetPreviousShift(selectedShift);
            //    //TODO: Get employees without contracts
            //    availableEmployees = em.GetAll().ToList();
            //}
            #endregion
        }

        private void OnRemoveClick(object sender, EventArgs e)
        {
            Employee? selectedemployee = (Employee?)lbEmployeesUsed.SelectedItem;
            if(selectedemployee == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            ShiftManager sm = ShiftManager.CreateForDatabase();
            Shift? selectedShift = sm.GetByDateAndType(dtpDate.Value, (ShiftType)cbbType.SelectedIndex);
            sm.RemoveEmployee(new(selectedemployee.ID.Value, selectedShift.ID));
            Search(sender, EventArgs.Empty);
        }
    }
}
