using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee();
            employee.Id = 101;
            employee.Name = "Ramu";
            employee.Age = 38;
            ViewData["myEmployee"] = employee.Name;
            ViewBag.Employee = employee;
            return View();
        }
        public IActionResult ShowEmployee()
        {
            Employee employee = new Employee();
            employee.Id = 101;
            employee.Name = "Ramu";
            employee.Age = 38;
            return View(employee);
        }
    }
}
