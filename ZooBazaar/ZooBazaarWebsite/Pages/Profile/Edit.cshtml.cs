using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisWebsite.Models;
using System.Security.Claims;
using ZooBazaarLogicLayer.Managers;
using ZooBazaarLogicLayer.People;

namespace ZooBazaarWebsite.Pages.Profile
{
    public class EditModel : PageModel
    {
        public EmployeeModel employee = new EmployeeModel();
        [BindProperty]
        public EmployeeModel updateEmployee { get; set; }
        public Employee subject = new Employee();

        public void OnGet()
        {
            FillData();

        }
        public IActionResult OnPost()
        {
            EmployeeManager em = EmployeeManager.CreateForDatabase();
            DateTime birthDate = DateTime.ParseExact(updateEmployee.BirthDate, "dd/MM/yyyy", null);
            subject = GetEmployee();

            try
            { 
                subject.ChangeAddress(updateEmployee.Address);
                subject.Name = updateEmployee.FullName;
                subject.ChangePhoneNumber(updateEmployee.Phone);
                subject.ChangeEmail(updateEmployee.Email);
                subject.ChangeBirthDay(birthDate.Date);
                var response = em.UpdateEmployees(subject);
                if (response.Success)
                {
                        return Redirect($"~/Profile/Index");

                }
                else
                {
                       return Redirect($"/");
                }
            }
            catch (Exception ex)
            {
                return Page();

            }
        }
        private void FillData()
        {
            ZooBazaarLogicLayer.People.Account a = GetAccount();
            Employee e = GetEmployee();
            employee.Email = a.Email;
            employee.BirthDate = e.BirthDay;
            employee.Address = e.Address;
            employee.Phone = e.PhoneNumber;
            employee.FullName = e.Name;
            employee.id = Convert.ToInt32(a.id);
            employee.username = a.Username;

        }
        public ZooBazaarLogicLayer.People.Account GetAccount()
        {
            AccountManager am = AccountManager.CreateForDatabase();
            ZooBazaarLogicLayer.People.Account user;
            user = am.GetByEmail(User.FindFirstValue(ClaimTypes.Email));
            return user;

        }
        public Employee GetEmployee()
        {
            EmployeeManager manager = EmployeeManager.CreateForDatabase();
            List<Employee> user = new List<Employee>();
            int userid = Convert.ToInt32(GetAccount().id);
            foreach (var result in manager.GetEmployeesById(userid))
            {
                user.Add(result);
            }
            return user[0];

        }
    }
}
