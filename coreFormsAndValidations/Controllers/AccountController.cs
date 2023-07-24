using coreFormsAndValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreFormsAndValidations.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeaklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        public IActionResult LoginSuccess(LoginViewModel login)
        {
            if(login.Username != null && login.Password != null)
            {
                if(login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    ViewBag.Message = "You are successfully logged in.";
                    return View();
                }
            }
            ViewBag.Message = "Invalid Credentials";
            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new LoginViewModel() { Username = "Aldrin", Password = "12345" };
            return View(user);
        }

        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel() { Username = "Aldrin", Password = "12345" },
                new LoginViewModel() { Username = "Steve", Password = "12345" },
                new LoginViewModel() { Username = "Bill", Password = "12345" }

            };
            return View(users);
        }

        public IActionResult GetAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostAccount(Account account)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            return RedirectToAction("GetAccount");
        }
    }
}
