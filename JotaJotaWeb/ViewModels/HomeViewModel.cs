using JotaJotaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }

        public List<Service> Services { get; set; }
    }
}
