using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Example_1.Models;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product{ Id = 1, Name = "Laptop", Price = 1000 },
            new Product{ Id = 2, Name = "Phone", Price = 500 },
            new Product{ Id = 3, Name = "Pencel", Price = 8 },
            new Product{ Id = 4, Name = "Pen", Price = 12 },
            new Product{ Id = 5, Name = "Book", Price = 85 }
        };
        return View(products);
    }
}