using Microsoft.AspNetCore.Mvc;
using PieShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Components
{
    public class CategorySelected : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategorySelected(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
