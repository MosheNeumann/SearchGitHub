using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstAPI.Data;
using MyFirstAPI.web.Models;

namespace MyFirstAPI.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult PopulateTable(string user)
        {
            var repo = new Repository();
            var vm = new ViewModel();
            vm.person = repo.GetPerson($"https://api.github.com/users/{user}");
            vm.Projects = repo.AllProjects($"https://api.github.com/users/{user}/repos");

            return View(vm);
        }
    
    }
}