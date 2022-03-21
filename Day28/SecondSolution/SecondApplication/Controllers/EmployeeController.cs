using Microsoft.AspNetCore.Mvc;
using SecondApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondApplication.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=101,Name="Ramu",Age=21},
            new Employee(){Id=102,Name="Somu",Age=24},
            new Employee(){Id=103,Name="Bimu",Age=28}
        };
        public IActionResult Index()
        {
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return View();
        }
    }
}
