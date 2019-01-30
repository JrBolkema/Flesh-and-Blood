using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			Product[] array = {
			new Product {ProductID = 1, Name = "Kayak", Price = 275M, StockLevel = 2},
			new Product {ProductID = 2, Name = "Lifejacket", Price = 48.95M, StockLevel = 23 },
			new Product {ProductID = 3, Name = "Soccer Ball", Price = 19.50M, StockLevel = 55 },
			new Product {ProductID = 4, Name = "Corner Flag", Price = 34.95M}
			};

			

            return View(array);
        }
    }
}