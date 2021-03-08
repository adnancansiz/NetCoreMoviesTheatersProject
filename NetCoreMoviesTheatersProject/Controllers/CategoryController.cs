using Microsoft.AspNetCore.Mvc;
using NetCoreMoviesTheatersProject.Model.Entities;
using NetCoreMoviesTheatersProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMoviesTheatersProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(categoryRepository.GetCategories());
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryRepository.Create(category);
            return RedirectToAction("Index");
        }
    }
}
