using EasyTools;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using ZooBazaarLogicLayer.Managers;

namespace ZooBazaarWebsite.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public SynthesisWebsite.Models.LoginModel login { get; set; }
        
        public IActionResult OnGet()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();

            }
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {

                    Func<string, ZooBazaarLogicLayer.People.Account?>? searchmethod;
                    AccountManager am = AccountManager.CreateForDatabase();
                    string input = login.Email;


                    if (input.StartsWith("ZB-"))
                    {
                        searchmethod = am.GetByUsernameExact;
                    }
                    else if (EasyTools.RegexTools.RegexToolBox.IsEmail(input))
                    {
                        searchmethod = am.GetByEmail;
                    }
                    else //If not a username or an email is put in, return early.
                    {
                        return Page();
                    }

                    ZooBazaarLogicLayer.People.Account? loginAttempt = searchmethod(input);

                    //Check if a result was found. If not, return early.
                    if (loginAttempt is null)
                    {
                        return Page();

                    }

                    //Check for password
                    if (loginAttempt.PasswordIsCorrect(login.Password, ZooBazaarLogicLayer.PasswordHandling.PasswordHelper.DefaultHash))
                    {
                        var claims = new List<Claim>
                        {
                           
                            new Claim(ClaimTypes.Email,login.Email),
                           
                        };
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                        return RedirectToPage("/Index");
                    }
                    else
                    {
                        return Page();
                    }
                    //if (loginState == false) return Page();
                    //else
                    //{
                    //    var claims = new List<Claim>
                    //    {
                    //        new Claim(ClaimTypes.NameIdentifier , u.Id.ToString()),
                    //        new Claim(ClaimTypes.Email,u.Email),
                    //        new Claim("FullName", u.GetFullName()),
                    //        new Claim(ClaimTypes.Role, u.Role)
                    //    };
                    //    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    //    return RedirectToPage("../");
                    //}

                }
                catch (Exception ex)
                {
                    return Page();

                }

            }
            else
            {
                return Page();
            }
        }
    }
}
