using JotaJotaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Controllers
{
    public class ContactController : Controller
    {


        private readonly IDbRepository _dbRepository;

        public ContactController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

      
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _dbRepository.AddContact(contact);
                return RedirectToAction("ContactComplete");
            }
            return View(contact);
            
        }

        public IActionResult ContactComplete()
        {
            return View();
        }


     
    }
}
