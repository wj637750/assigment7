using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using assigment7.infrastructure;
using assigment7.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace assigment7.Controllers
{
    public class CartController : Controller{
        private IProductRepository repository;

        public CartController(IProductRepository repo)
        {
            repository = repo;
        }

        public RedirectToActionResult AddToCart(int productId, string returnUrl){
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}