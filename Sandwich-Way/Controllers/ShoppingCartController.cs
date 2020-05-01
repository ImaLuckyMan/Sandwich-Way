using Microsoft.AspNetCore.Mvc;
using Sandwich_Way.Models;
using Sandwich_Way.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandwich_Way.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISandwichRepository _sandwichRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISandwichRepository sandwichRepository, ShoppingCart shoppingCart)
        {
            _sandwichRepository = sandwichRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int sandwichId)
        {
            var selectedSandwich = _sandwichRepository.GetAllSandwiches.FirstOrDefault(s => s.SandwichId == sandwichId);

            if (selectedSandwich != null)
            {
                _shoppingCart.AddToCart(selectedSandwich, 1);
            }

            return RedirectToAction("Index");

        }

        public RedirectToActionResult RemoveFromShoppingCart(int sandwichId)
        {
            var selectedSandwich = _sandwichRepository.GetAllSandwiches.FirstOrDefault(s => s.SandwichId == sandwichId);

            if (selectedSandwich != null)
            {
                _shoppingCart.RemoveFromCart(selectedSandwich);
            }

            return RedirectToAction("Index");

        }
    }
}
