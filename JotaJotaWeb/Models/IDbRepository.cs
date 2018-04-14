using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Models
{
    public interface IDbRepository
    {
        //Product
        IEnumerable<Product> GetAllProducts();

        Product GetProductById(int PId);
        
        //Service
        IEnumerable<Service> AllServices();

        //Contact
        void AddContact(Contact contact);
    }
}
