using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AspNetCoreWebAPIProject.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /* // Route
        [Route("employees/all")]
        public string GetAllEmployees()
        {
            return "All Employees Here";
        }
        [Route("employees/{id:int:min(100)}")]
        public string GetEmployeeById(int id)
        {
            return "Employee with Id: " + id;
        }
        [Route("emps/{id:int}")]
        public string GetEmployeeDetails(int id)
        {
            return "Employee Details: " + id;
        }
        [Route("emps/{name:alpha}")]
        public string GetEmployeeDetails(string name)
        {
            return "Employee Details: " + name;
        }
        */
    }
}