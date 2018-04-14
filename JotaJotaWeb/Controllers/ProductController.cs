using JotaJotaWeb.Models;
using JotaJotaWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Controllers
{
    public class ProductController : Controller
    {
        //Db Injection
        private readonly IDbRepository dbRepository;
        public ProductController(IDbRepository _dbRepository)
        {
            dbRepository = _dbRepository;
        }

        //Index
        public IActionResult Index()
        {
            var products = dbRepository.GetAllProducts().OrderBy(p => p.Name);
            var productViewModel = new ProductViewModel()
            {
                Products = products.ToList()
                
            };

            return View(productViewModel);
        }
    }

}
