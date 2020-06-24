using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.Data
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category
            {
                CategoryId = 1,
                CategoryName = "Ciasta owocowe",
                Description = "Wszystkie ciasta owocowe"
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Serniki",
                Description = "Serowy przez całą drogę"
            },
            new Category
            {
                CategoryId = 3,
                CategoryName = "Ciasta sezonowe",
                Description = "Zrób nastrój na sezonowe ciasta"
            }
        };
    }
}