using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B1_CNNet_COMP1064_in_Class.Models;

namespace B1_CNNet_COMP1064_in_Class.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();
        public IActionResult Index()
        {
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
                // add to list
                products.Add(product);                
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if(product != null)
            {
                return View(product);
            }
            // return RedirectToAction(actionName: "Index", controllerName: "Product");
            return RedirectToAction("Index", "Product");
        }

        [HttpPost]
        public IActionResult Edit(Product product )
        {
            var _product = products.FirstOrDefault(p => p.ID == product.ID);
            if (_product != null)
            {
                // Update data
                _product.Name = product.Name;
                _product.Price = product.Price;
                _product.Quantity = product.Quantity;
            }

            return RedirectToAction("Index");
        }
        public IActionResult Delete (int id)
        {
            var _product = products.FirstOrDefault(p => p.ID == id);
            if (_product != null)
            {
                // remove
                products.Remove(_product);
            }

            return RedirectToAction("Index");
        }
    }
}
