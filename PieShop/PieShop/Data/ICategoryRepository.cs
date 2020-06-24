using System.Collections;
using System.Collections.Generic;

namespace PieShop.Data
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}