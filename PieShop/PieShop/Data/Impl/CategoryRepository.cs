using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.Data.Impl
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}