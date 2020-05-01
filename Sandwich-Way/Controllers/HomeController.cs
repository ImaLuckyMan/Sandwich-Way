using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandwich_Way.Models;
using Sandwich_Way.ViewModels;

namespace Sandwich_Way.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISandwichRepository _sandwichRepository;

        public HomeController(ISandwichRepository sandwichRepository)
        {
            _sandwichRepository = sandwichRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SandwichOnSale = _sandwichRepository.GetSandwichOnSale
            };

            return View(homeViewModel);
        }
    }
}