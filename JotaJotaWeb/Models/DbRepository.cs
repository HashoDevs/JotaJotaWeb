using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Models
{
    public class DbRepository : IDbRepository
    {
        //AppDbContext Injection
        private readonly AppDbContext _appDbContext;

        public DbRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Products
        public IEnumerable<Product> GetAllProducts()
        {
            return _appDbContext.Products;
        }

        public Product GetProductById(int PId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.Id == PId);
        }

        //Service
        public IEnumerable<Service> AllServices()
        {
            return _appDbContext.Services;
        }

        //Contact
        public void AddContact(Contact contact)
        {
            _appDbContext.Contacts.Add(contact);
            _appDbContext.SaveChanges();
        }

    }
}
