using JotaJotaWeb.Models;
using JotaJotaWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Controllers
{
    public class ServiceController : Controller

    {

        //Db Injection
        private readonly IDbRepository dbRepository;
        public ServiceController(IDbRepository _dbRepository)
        {
            dbRepository = _dbRepository;
        }

        //Index
        public IActionResult Index()
        {
            var services = dbRepository.AllServices().OrderBy(s => s.Name);

            var serviceViewModel = new ServiceViewModel()
            {
                Services = services.ToList()

            };

            return View(serviceViewModel);
        }

    }
}
