using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BL_Core.Controllers;
using BL_Core.Database;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            EmpDB objDB = new EmpDB();
            var emp = objDB.GetDetail().OrderBy(i=>i.Id);
            
            ViewBag.emp = emp;
            ViewData["Name"] = emp;
            return View();
        }

        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }         
    }
}
