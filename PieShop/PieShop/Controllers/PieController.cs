using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using PieShop.Data;
using PieShop.Models;
using PieShop.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHtmlHelper _htmlHelper;

        public IEnumerable<SelectListItem> Categories { get; set; }
        public Pie Pie { get; set; }
        public Category Category { get; set; }

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository, IHtmlHelper htmlHeleper)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
            _htmlHelper = htmlHeleper;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "Wszystkie ciasta";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);

            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }

        public IActionResult ListAllPies(string searchTerm)
        {
            
            var pies = _pieRepository.GetPieByName(searchTerm);

            if (pies == null)
            {
                return NotFound();
            }

            return View(new PiesListViewModel
            {
                Pies = pies
            });
        }

        public IActionResult Edit(int? pieId)
        {
            Categories = _categoryRepository.AllCategories.Select(c => new SelectListItem { Text = c.CategoryName, Value = c.CategoryName }).ToList();

            if (pieId.HasValue)
            {
                Pie = _pieRepository.GetPieById(pieId.Value);
                Category = _categoryRepository.GetCategoryById(Pie.CategoryId);
                
            }
            else
            {
                Pie = new Pie();
                Category = new Category();
            }

            if (Pie == null)
            {
                return NotFound();
            }

            return View(new PieEditViewModel { Pie = Pie, Categories = Categories, Category = Category });
        }

        [HttpPost]
        public IActionResult Update(PieEditViewModel updatePie)
        {
            updatePie.Pie.Category = _categoryRepository.AllCategories
                .FirstOrDefault(c => c.CategoryName == updatePie.Category.CategoryName);
            updatePie.Pie.CategoryId = _categoryRepository.AllCategories
                .FirstOrDefault(c => c.CategoryName == updatePie.Category.CategoryName).CategoryId;

            if (updatePie.Pie.PieId > 0)
            {
                updatePie.Pie = _pieRepository.Update(updatePie.Pie);
            }
            else
            {
                updatePie.Pie = _pieRepository.Add(updatePie.Pie);
            }

            _pieRepository.Commit();

            return RedirectToAction("Details",
                new RouteValueDictionary(new { controller = "Pie", action = "Details", Id = updatePie.Pie.PieId })); ;
        }
        public IActionResult Delete(int pieId)
        {
            var pie = _pieRepository.GetPieById(pieId);

            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }

        [HttpPost]
        public IActionResult DeleteItem(int pieId)
        {
            var pie = _pieRepository.Delete(pieId);

            _pieRepository.Commit();

            if (pie == null)
            {
                return NotFound();
            }

            return RedirectToAction("ListAllPies");
        }
    }
}