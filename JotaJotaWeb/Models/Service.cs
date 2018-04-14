using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string AltTag { get; set; }

        public bool Top { get; set; }
    }
}
