using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JotaJotaWeb.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext appDbContext)
        {

            //Product data cleaner
            foreach (var product in appDbContext.Products)
            {
                appDbContext.Remove(product);
            }
            appDbContext.SaveChanges();

            //Service data cleaner
            foreach (var service in appDbContext.Services)
            {
                appDbContext.Remove(service);
            }
            appDbContext.SaveChanges();

            //Product
            if (!appDbContext.Products.Any())
            {
                appDbContext.AddRange
                    (
                    new Product { Name = "Cable", Description = "Todo tipo de calibres y medidas", ImagePath= "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", AltTag = "AltExample", Top = true },
                    new Product { Name = "Posteria", Description = "Todos los postes ", ImagePath = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", AltTag = "AltExample", Top = true },
                    new Product { Name = "Herrajes", Description = "Todo el herraje del mundo", ImagePath = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", AltTag = "AltExample", Top = false },
                    new Product { Name = "Gabinetes", Description = "Cajas?, claro que si", ImagePath = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", AltTag = "AltExample", Top = true },
                    new Product { Name = "Aparatos", Description = "Cosas y asi? Tambien!", ImagePath = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", AltTag = "AltExample", Top = false }
                    );
                appDbContext.SaveChanges();
            }


            //Service
            if (!appDbContext.Services.Any())
            {
                appDbContext.AddRange
                    (
                    new Service { Name = "Tramites", Description = "Tramitamos ante CFE todo lo que tu proyecto necesita", ImagePath = "images/Banner1.svg", AltTag = "AltExample", Top = true },
                    new Service { Name = "Construccion", Description = "Deja tu proyecto en nuestras manos", ImagePath = "images/Servicio.jpg", AltTag = "AltExample", Top = false },
                    new Service { Name = "Diseño de proyectos", Description = "Diseño? Tambien!", ImagePath = "images/Servicio.jpg", AltTag = "AltExample", Top = true },
                    new Service { Name = "Consultoria", Description = "Te asesoramos en todo lo que ocupes", ImagePath = "images/Servicio.jpg", AltTag = "AltExample", Top = true }
                    );
                appDbContext.SaveChanges();
            }
        }
    }
}
