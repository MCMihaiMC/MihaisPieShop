using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MihaisPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        { 
            new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruit pie"},
            new Category{CategoryId=1, CategoryName="Fruit pies", Description="Cheesy all the way"},
            new Category{CategoryId=1, CategoryName="Fruit pies", Description="Seasonal pie"}
        };

    }
}
