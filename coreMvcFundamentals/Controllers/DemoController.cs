using coreMvcFundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcFundamentals.Controllers
{
    public class DemoController : Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() { Id = 101, Name = "Jes", Amount = 12000 },
            new Customer() { Id = 102, Name = "Aldrin", Amount = 12000 },
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Customer Management System";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"] = customers;
            return View();
        }

        public IActionResult Method1()
        {
            TempData["Message"] = "Customer Management System";
            TempData["CustomerCount"] = customers.Count();
            TempData["CustomerList"] = customers;
            return View();
        }

        public IActionResult Method2()
        {
            if (TempData["Message"] == null)
                return RedirectToAction("Index");
            TempData["Message"] = TempData["Message"].ToString();
            return View();
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "Aldrin");
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Index");
        }

        // Request Url: https://localhost:7221/Demo/QueryTest
        // Request Url: https://localhost:7221/Demo/QueryTest?name=Rabanal
        public IActionResult QueryTest()
        {
            string name = "Jes Aldrin";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];
            ViewBag.Name = name;
            return View();
        }
    }
}
