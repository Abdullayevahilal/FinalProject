using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int id);
      
        IEnumerable<Category> GetCategories();
        Category CreateCategory(Category category);
        void UpdateCategory(Category categoryToUpdate, Category category);
        void DeleteCategory(Category category);
    }
}
