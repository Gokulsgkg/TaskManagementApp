using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;
namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            Employee employee = new Employee
            {
                Id = 1,
                Name = "John Doe",
                Department = "IT"
            };
            return View(employee);
        }
    }
}