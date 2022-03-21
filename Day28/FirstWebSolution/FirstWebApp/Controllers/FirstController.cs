using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class FirstController : Controller
    {
        //Action methods
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployee()
        {
            return View();
        }
    }
}
