using coreMvcFundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcFundamentals.Controllers
{
    public class CustomerController : Controller
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
            return View();
        }
        //[Route("~/")]
        [Route("/sample/message")]
        public IActionResult Message()
        {
            return View();
        }
    }
}
