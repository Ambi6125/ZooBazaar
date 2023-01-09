using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazaarDataLayer.DALSpecies;
using ZooBazaarDesktop.Controls;
using ZooBazaarLogicLayer.Animals;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.Zones;
using ZooBazaarLogicLayer.People;
using ZooBazaarLogicLayer.Schedule.Shifts;

namespace ZooBazaarDesktop.Forms
{
    public partial class MainForm : Form
    {
        private Action? exhibitsearch;
        private Action? speciesSearch;
        private Action? animalsSearch;
        private Action? accountSearch;
        private Action? contractSearch;
        private Action? employeeSearch;
        private readonly LoginForm origin;
        
        public MainForm(LoginForm origin)
        {
            InitializeComponent();
            this.origin = origin;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                origin.Show();
                UILogic.SessionSimulator.LoggedAccount = null;
            }
            else
            {
                origin.Close(); //If the form closes due to unexpected reasons, close the parent form too
            }
        }

        #region Species tab UI
        private void OnSpeciesSearch(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSpeciesSearchInput.Text))
            {
                MessageBox.Show("Please input a search term.");
                return;
            }

            if(speciesSearch is not null)
            {
                speciesSearch();
            }
            else
            {
                NoSpeciesSearch();
            }
        }

        private void RefillSpeciesList(ICollection<Species> species)
        {
            flpSpecies.Controls.Clear();
            foreach(Species s in species)
            {
                flpSpecies.Controls.Add(new SpeciesDisplayBox(s));
            }
            DisplaySpeciesResultCount(species.Count);
        }
        private void RefillSpeciesList(Species? species)
        {
            flpSpecies.Controls.Clear();
            if (species is not null)
            {
                flpSpecies.Controls.Add(new SpeciesDisplayBox(species));
                DisplaySpeciesResultCount(1);
            }
            else
            {
                DisplaySpeciesResultCount(0);
            }
        }

        private void OnAddSpeciesButtonClicked(object sender, EventArgs e)
        {
            new CreateSpeciesForm(this).Show();
            Hide();
        }

        private void ToggleSpeciesSelectables(object sender, EventArgs e)
        {
            foreach(SpeciesDisplayBox db in flpSpecies.Controls)
            {
                db.ToggleSelectability();
            }
            if(btnDelete.Enabled)
                btnDelete.Enabled = false;
            else
                btnDelete.Enabled = true;
        }

        private void OnSpeciesDeleteClick(object sender, EventArgs e)
        {
            IEnumerable<SpeciesDisplayBox> boxes = flpSpecies.Controls
                .OfType<SpeciesDisplayBox>()
                .Where((SpeciesDisplayBox x) => x.IsSelected);

            if (!boxes.Any())
            {
                MessageBox.Show("No selection given.");
                return;
            }

            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            foreach(SpeciesDisplayBox x in boxes)
            {
                var response = sm.DeleteSpecies(x.Topic);
                if(response.Success == false)
                {
                    MessageBox.Show(response.Message);
                }
            }
            MessageBox.Show("Deleted succesfully.");
        }

        private void DisplaySpeciesResultCount(int count)
        {
            lblResultCount.Text = $"{count} result(s) for \"{tbSpeciesSearchInput.Text}\".";
        }

        private void OnSpeciesFilterMethodUpdated(object sender, EventArgs e)
        {
            switch (cbbSpeciesFilter.SelectedItem)
            {
                case "ID":
                    speciesSearch = SpeciesIdSearch;
                    break;
                case "Name":
                    speciesSearch = SpeciesNameSearch;
                    break;
                default:
                    speciesSearch = NoSpeciesSearch;
                    break;
            }
        }
        #endregion

        #region Exhibit tab UI

        private void CExhibitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateExhibit form = new CreateExhibit(this);
            form.Show();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            exhibitsearch();
        }

        private void FillExhibitList(ICollection<Exhibit> e)
        {
            FLPExhibits.Controls.Clear();
            foreach(Exhibit ex in e)
            {
                FLPExhibits.Controls.Add(new ExhibitDisplayBox(ex));
            }
        }

        private void fillExhibitList(Exhibit e)
        {
            FLPExhibits.Controls.Clear();
            FLPExhibits.Controls.Add(new ExhibitDisplayBox(e));
        }

        private void FilterMethod(object sender, EventArgs e)
        {          
            switch (SearchCB.SelectedItem.ToString())
            {
                case "id":
                    exhibitsearch = SearchById;
                    break;
                case "zone":
                    exhibitsearch = SearchByZone;
                    break;
                case "name":
                    exhibitsearch = SearchByName;
                    break;
                default:
                    exhibitsearch = NoFilter;
                    break;
            }
        }
        #endregion

        #region Exhibit Filters
        private void SearchById()
        {
            ExhibitManager manager = ExhibitManager.CreateForDatabase();
            Exhibit resault = manager.SearchById(Convert.ToInt32(Searchtb.Text));
            fillExhibitList(resault);
        }

        private void SearchByZone()
        {
            ExhibitManager manager = ExhibitManager.CreateForDatabase();
            var resault = manager.GetByZone(Searchtb.Text);

            FillExhibitList(resault.ToList());
        }

        private void SearchByName()
        {
            ExhibitManager manager = ExhibitManager.CreateForDatabase();
            var resault = manager.GetByName(Searchtb.Text);

            FillExhibitList(resault.ToList());
        }

        private void NoFilter()
        {
            MessageBox.Show("No Filter Selected");
        }
        #endregion

        #region Species Filters

        private void SpeciesIdSearch()
        {
            string inputValue = tbSpeciesSearchInput.Text;
            int id;

            if(!int.TryParse(inputValue, out id))
            {
                MessageBox.Show("Please enter a numeric id.", "ZooBazaar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } //Check if input is numeric

            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            var result = sm.GetById(id);
            RefillSpeciesList(result);
        }

        private void SpeciesNameSearch()
        {
            string inputValue = tbSpeciesSearchInput.Text;
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            var result = sm.GetSpeciesByName(inputValue);
            RefillSpeciesList(result.ToArray());
        }

        private void NoSpeciesSearch()
        {
            MessageBox.Show("Someting went wrong. Please select something to filter by.");
        }
        #endregion

        #region Animal Filters
        //TODO: Add animal searches in this area
        //private void AnimalsIdSearch()
        //{
        //    string inputValue = tbAnimalSearchInput.Text;
        //    int id;

        //    if (!int.TryParse(inputValue, out id))
        //    {
        //        MessageBox.Show("Please enter a numeric id.", "ZooBazaar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    } //Check if input is numeric

        //    AnimalManager am = AnimalManager.CreateForDatabase();
        //    var result = am.GetById(id);
        //    RefillSpeciesList(result);
        //}
        private void AnimalsNameSearch()
        {
            string inputValue = tbAnimalSearchInput.Text;
            AnimalManager am = AnimalManager.CreateForDatabase();
            var result = am.GetAnimalsByName(inputValue);
            RefillAnimalList(result.ToArray());
        }
        private void AnimalsSpeciesSearch()
        {
            string inputValue = tbAnimalSearchInput.Text;
            SpeciesManager sm = SpeciesManager.CreateForDatabase();
            var speciesresult = sm.GetSpeciesByName(inputValue).FirstOrDefault();
            
            AnimalManager am = AnimalManager.CreateForDatabase();
            var result = am.GetAnimalsBySpecies(speciesresult);
            RefillAnimalList(result.ToArray());
        }
        private void NoAnimalsSearch()
        {
            MessageBox.Show("Someting went wrong. Please select something to filter by.");
        }
        #endregion

        #region Account Filters
        private void NoAccountFilterApplied()
        {
            MessageBox.Show("Please select an option to filter accounts by");
        }

        private void SearchAccountsByUsername()
        {
            flpAccounts.Controls.Clear();
            AccountManager acm = AccountManager.CreateForDatabase();
            foreach(Account account in acm.GetByUsername(tbSearchAccountInput.Text))
            {
                AccountDisplayBox box = new AccountDisplayBox(account);
                flpAccounts.Controls.Add(box);
            }
        }

        private void SearchAccountsByEmail()
        {
            flpAccounts.Controls.Clear();
            AccountManager acm = AccountManager.CreateForDatabase();
            try
            {
                Account? a = acm.GetByEmail(tbSearchAccountInput.Text);
                if(a is null)
                {
                    MessageBox.Show("No account is tied to this email.", "No results");
                    return;
                }
                AccountDisplayBox box = new AccountDisplayBox(a);
                flpAccounts.Controls.Add(box);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Contract Filters

        private void NoContractFilterApplied()
        {
            MessageBox.Show("Please select an option to filter contracts by");
        }

        private void SearchContractsByName()
        {
            flpContracts.Controls.Clear();
            ContractManager cm = ContractManager.CreateForDatabase();
            foreach (Contract contract in cm.GetByEmployeeName(SearchContbx.Text))
            {
                ContractDisplayBox box = new ContractDisplayBox(contract);
                flpContracts.Controls.Add(box);
            }
        }

        private void SearchContractsBytype()
        {
            flpContracts.Controls.Clear();
            ContractManager cm = ContractManager.CreateForDatabase();

            int hours =0;
            if (cbContractType.Text == "ZeroBased")
            {
                hours = ((int)ContractType.ZeroBased);
            }
            else if(cbContractType.Text == "Part-Time")
            {
                hours = ((int)ContractType.PartTime);
            }
            else if(cbContractType.Text == "Full-Time")
            {
                hours = ((int)ContractType.FullTime);
            }

            foreach(Contract contract in cm.GetByType(hours))
            {
                ContractDisplayBox box = new ContractDisplayBox(contract);
                flpContracts.Controls.Add(box);
            }

        }

        private void SearchContractsByStatus()
        {
            flpContracts.Controls.Clear();
            ContractManager cm = ContractManager.CreateForDatabase();
            bool status = false;
            if (chbActiveStatus.Checked)
            {
                status = true;
            }
            else if(chbNonActiveStatus.Checked)
            {
                status = false;
            }
            foreach (Contract contract in cm.GetByStatus(status))
            {
                ContractDisplayBox box = new ContractDisplayBox(contract);
                flpContracts.Controls.Add(box);
            }
        }

        #endregion

        #region Employee Filters
        private void NoEmployeeFilterApplied()
        {
            MessageBox.Show("Please select an option to filter contracts by");
        }

        private void SearchEmployeesByName()
        {
            flpEmployees.Controls.Clear();
            EmployeeManager em = EmployeeManager.CreateForDatabase();
            foreach (Employee employee in em.GetEmployeesByName(txtboxSearchEmployee.Text))
            {
                EmployeeDisplayBox box = new EmployeeDisplayBox(employee);
                flpEmployees.Controls.Add(box);
            }
        }
        #endregion

        #region Animals Tab UI

        public void RefillAnimalList(ICollection<Animal> animals)
        {
            flpAnimals.Controls.Clear();
            foreach (Animal a in animals)
            {
                flpAnimals.Controls.Add(new AnimalDisplayBox(a));
            }
        }
        private void OnAnimalsFilterMethodUpdated(object sender, EventArgs e)
        {
            switch (cbbAnimalsFilter.SelectedItem)
            {
                //case "ID":
                //    animalsSearch = AnimalsIdSearch;
                //    break;
                case "Name":
                    animalsSearch = AnimalsNameSearch;
                    break;
                case "Species":
                    animalsSearch = AnimalsSpeciesSearch;
                    break;
                default:
                    animalsSearch = NoAnimalsSearch;
                    break;
            }
        }
        private void OnAnimalSearchClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAnimalSearchInput.Text))
            {
                MessageBox.Show("Please input a search term.");
                return;
            }

            if (animalsSearch is not null)
            {
                animalsSearch();
            }
            else
            {
                NoAnimalsSearch();
            }
        }

        private void OnNewAnimalClick(object sender, EventArgs e)
        {
            this.Hide();
            new AnimalCreateForm(this).Show();
        }
        #endregion

        /// <summary>
        /// Runs whenever the form is loaded in.
        /// </summary>
        private void OnLoad(object sender, EventArgs e)
        {
            lblResultCount.Text = string.Empty;
            Text = $"ZooBazaar - {UILogic.SessionSimulator.LoggedAccount?.Username}";
        }
        private void ToggleAnimalsSelectables(object sender, EventArgs e)
        {
            foreach (AnimalDisplayBox db in flpAnimals.Controls)
            {
                db.ToggleAnimalsSelectability();
            }
            if (btnDeleteAnimal.Enabled)
                btnDeleteAnimal.Enabled = false;
            else
                btnDeleteAnimal.Enabled = true;
        }
        private void OnAnimalRemoveClick(object sender, EventArgs e)
        {
            
            IEnumerable<AnimalDisplayBox> boxes = flpAnimals.Controls
               .OfType<AnimalDisplayBox>()
               .Where((AnimalDisplayBox x) => x.IsSelectedAnimal);

            if (!boxes.Any())
            {
                MessageBox.Show("No selection given.");
                return;
            }

            AnimalManager am = AnimalManager.CreateForDatabase();
            foreach (AnimalDisplayBox x in boxes)
            {
                this.Hide();
                new AnimalDeleteForm(x.Topic,this).Show();
            }
            
        }


        #region Accounts tab UI
        private void AccountFilterChanged(object sender, EventArgs e)
        {
            if(cbbAccountSearchFilter.Text == "Username")
            {
                accountSearch = SearchAccountsByUsername;
            }
            else if(cbbAccountSearchFilter.Text == "E-mail address")
            {
                accountSearch = SearchAccountsByEmail;
            }
            else
            {
                accountSearch = NoAccountFilterApplied;
            }
        }
        private void OnNewAccountClick(object sender, EventArgs e)
        {
            NewAccountForm form = new NewAccountForm(this);
            Hide();
            form.Show();
        }

        private void OnAccountSearchClick(object sender, EventArgs e)
        {
            accountSearch?.Invoke();
        }

        private void OnLoadAll(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("This might take a long time.\nContinue?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (userResponse == DialogResult.Yes)
            {
                flpAccounts.Controls.Clear();
                AccountManager manager = AccountManager.CreateForDatabase();
                foreach (var result in manager.GetAll())
                {
                    AccountDisplayBox box = new AccountDisplayBox(result);
                    flpAccounts.Controls.Add(box);
                }
            }
        }

        #endregion

        #region Contracts tab UI
        private void FilterConcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterConcb.Text == "FirstName")
            {
                contractSearch = SearchContractsByName;
            }
            else if (FilterConcb.Text == "Type")
            {
                contractSearch = SearchContractsBytype;
            }
            else if (FilterConcb.Text == "Status")
            {
                contractSearch = SearchContractsByStatus;
            }
            else
            {
                contractSearch = NoContractFilterApplied;
            }
        }

        private void SearchConbtn_Click(object sender, EventArgs e)
        {
            contractSearch?.Invoke();
        }

        private void NewContractbtn_Click(object sender, EventArgs e)
        {
            CreateContractForm form = new CreateContractForm(this);
            Hide();
            form.Show();
        }

        private void ContractsLoadbtn_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("This might take a long time.\nContinue?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (userResponse == DialogResult.Yes)
            {
                flpContracts.Controls.Clear();
                ContractManager manager = ContractManager.CreateForDatabase();
                foreach (var result in manager.GetAll())
                {
                    ContractDisplayBox box = new ContractDisplayBox(result);
                    flpContracts.Controls.Add(box);
                }
            }
        }

        #endregion

        #region Employee tab UI
      

        private void OnEmployeeSearchClick(object sender, EventArgs e)
        {
            employeeSearch?.Invoke();
        }

        private void OnEmployeeFilterChanged(object sender, EventArgs e)
        {
            if (cbEmployeeSearchFilter.Text == "Name")
            {
                employeeSearch = SearchEmployeesByName;
            }
            //else if (cbEmployeeSearchFilter.Text == "E-mail address")
            //{
            //    employeeSearch = ;
            //}
            else
            {
                employeeSearch = NoEmployeeFilterApplied;
            }
        }

        private void OnCreateEmployeeClick(object sender, EventArgs e)
        {
            this.Hide();
            new CreateEmployeeForm(this).Show();
        }
        #endregion

        private void GeAllEmpClick(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("This might take a long time.\nContinue?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (userResponse == DialogResult.Yes)
            {
                flpEmployees.Controls.Clear();
                EmployeeManager manager = EmployeeManager.CreateForDatabase();
                foreach (var result in manager.GetAll())
                {
                    EmployeeDisplayBox box = new EmployeeDisplayBox(result);
                    flpEmployees.Controls.Add(box);
                }
            }
        }

        #region Shift tab UI (Beta)

        private void RefillShiftListBoxes(IEnumerable<Shift> shifts)
        {
            lbMorning.Items.Clear();
            lbAfternoon.Items.Clear();
            lbEvening.Items.Clear();

            if(shifts.Count() == 0)
            {
                MessageBox.Show("There are no shifts in the selected date.");
                return;
            }

            var morningShift = shifts.FirstOrDefault(x => x.ShiftType == ShiftType.Morning, null);
            if(morningShift != null)
            {
                lbMorning.Items.AddRange(morningShift.Employees.ToArray());
            }            

            var afternoonShift = shifts.FirstOrDefault(x => x.ShiftType == ShiftType.Afternoon, null);
            if(afternoonShift != null)
            {
                lbAfternoon.Items.AddRange(afternoonShift.Employees.ToArray());
            }            

            var eveningShift = shifts.FirstOrDefault(x => x.ShiftType == ShiftType.Evening, null);
            if(eveningShift != null)
            {
                lbEvening.Items.AddRange(eveningShift.Employees.ToArray());
            }            
        }

        private void OnShiftSearch(object sender, EventArgs e)
        {
            var manager = ShiftManager.CreateForDatabase();

            DateTime selectedDate = dtpShiftDateInput.Value;
            var result = manager.GetByDate(selectedDate.Date);

            RefillShiftListBoxes(result);
        }

        #endregion

        private void OnNewClick(object sender, EventArgs e)
        {
            AddShiftsForm form = new AddShiftsForm(this);
            form.Show();
            Hide();
        }
    }
}
