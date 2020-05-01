using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sandwich_Way.Models;
using Sandwich_Way.ViewModels;

namespace Sandwich_Way.Controllers
{
    public class SandwichController : Controller
    {
        private readonly ISandwichRepository _sandwichRepository;
        private readonly ICategoryRepository _categoryRepository;

        public SandwichController(ISandwichRepository sandwichRepository, ICategoryRepository categoryRepository)
        {
            _sandwichRepository = sandwichRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Sandwiches> sandwiches;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                sandwiches = _sandwichRepository.GetAllSandwiches.OrderBy(s => s.SandwichId);
                currentCategory = "All Candy";
            }

            else
            {
                sandwiches = _sandwichRepository.GetAllSandwiches.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new SandwichListViewModel
            {
                Sandwiches = sandwiches,
                CurrentCategory = currentCategory
            });

        }

        public IActionResult Details(int id)
        {
            var sandwich = _sandwichRepository.GetSandwichesById(id);
            if (sandwich == null)
                return NotFound();

            return View(sandwich);
        }
    }
}