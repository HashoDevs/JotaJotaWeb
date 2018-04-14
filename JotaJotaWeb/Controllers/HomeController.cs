using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JotaJotaWeb.Models;
using JotaJotaWeb.ViewModels;

namespace JotaJotaWeb.Controllers
{
    public class HomeController : Controller
    {

        //Db Injection
        private readonly IDbRepository dbRepository;
        public HomeController(IDbRepository _dbRepository)
        {
            dbRepository = _dbRepository;
        }

        //Index
        public IActionResult Index()
        {
            var products = dbRepository.GetAllProducts().OrderBy(p => p.Name);
            var services = dbRepository.AllServices().OrderBy(s => s.Name);

            var homeViewModel = new HomeViewModel()
            {
                Products = products.Where(x => x.Top).ToList(),
                Services = services.Where(x => x.Top).ToList()
            };

            return View(homeViewModel);
        }

        //About
        public IActionResult About()
        {
            return View();
        }

        //Error
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
