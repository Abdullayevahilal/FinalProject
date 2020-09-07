using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
   public interface IProductRepository
    {
        IEnumerable<Product> GetTopSellingProducts(int limit);
        IEnumerable<Product> GetHoneymoonProducts(int limit);
        IEnumerable<Product> GetAwesomePackages(int limit);
        IEnumerable<Product> GetSpecialNatureProducts(int limit);
        IEnumerable<Product> GetExploreProducts(int limit);
        IEnumerable<Product> GetPopularDestination(int limit);
        IEnumerable<Product> GetBlog(int limit);
        IEnumerable<Product> GetProductsByCategoryId(int categoryId, int take, int skip);
        Product GetProductsById(int id);
        object GetProductsByCategoryId(int id);
    }
}
