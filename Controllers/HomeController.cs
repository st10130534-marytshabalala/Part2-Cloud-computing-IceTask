using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace st101030534_part2_CLDV7111.Controllers
{
    public class HomeController : Controller
    {
        private List<Artisan> artisans;
        private List<Product> products;

        public HomeController()
        {
            artisans = new List<Artisan>();
            products = new List<Product>();
        }
        public ActionResult Index()
        {
            // Create artisans
            Artisan artisan1 = new Artisan { Name = "John Doe", Craftwork = "Woodworking" };
            Artisan artisan2 = new Artisan { Name = "Jane Smith", Craftwork = "Pottery" };

            // Create products
            Product product1 = new Product { Name = "Wooden Chair", Description = "Handcrafted wooden chair", Price = 100, Artisan = artisan1 };
            Product product2 = new Product { Name = "Ceramic Vase", Description = "Beautiful ceramic vase", Price = 50, Artisan = artisan2 };
            Product product3 = new Product { Name = "Wooden Table", Description = "Handmade wooden table", Price = 200, Artisan = artisan1 };

            // Add artisans and products
            artisans.Add(artisan1);
            artisans.Add(artisan2);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            var model = new ArtisanProductViewModel
            {
                Artisans = artisans,
                Products = products
            };

            return View(model);
        }
    

    public class Artisan
    {
        public string Name { get; set; }
        public string Craftwork { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Artisan Artisan { get; set; }
    }

    public class ArtisanProductViewModel
    {
        public List<Artisan> Artisans { get; set; }
        public List<Product> Products { get; set; }
    } 

public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }


}