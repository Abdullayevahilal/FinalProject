using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TravelDbContext _context;
        public ProductRepository(TravelDbContext context)
        {

            _context = context;
        }

        public IEnumerable<Product> GetAwesomePackages(int limit)
        {
            return _context.Products.Include("Photos")
                                   .Include("Label")
                                   .Include("Discounts")
                                    .Include("Discounts.Discount")
                                   .Where(p => p.Status)
                                   .Where(p => p.IsTopSelling)
                                   .OrderByDescending(p => p.AddedDate)
                                   .Take(limit)
                                   .ToList();

        }

        public IEnumerable<Product> GetHoneymoonProducts(int limit)
        {
            return _context.Products.Include("Photos")
                                     .Include("Label")
                                     .Include("Discounts")
                                      .Include("Discounts.Discount")
                                     .Where(p => p.Status)
                                     .Where(p => p.IsTopSelling)
                                     .OrderByDescending(p => p.AddedDate)
                                     .Take(limit)
                                     .ToList();
        }

        public IEnumerable<Product> GetTopSellingProducts(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Include("Label")
                                    .Include("Discounts")
                                     .Include("Discounts.Discount")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsTopSelling)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();

        }
        public IEnumerable<Product> GetSpecialNatureProducts(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Include("Label")
                                    .Include("Discounts")
                                     .Include("Discounts.Discount")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsTopSelling)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();

        }

        public IEnumerable<Product> GetExploreProducts(int limit)
        {
              return _context.Products.Include("Photos")
                                    .Include("Label")
                                    .Include("Discounts")
                                     .Include("Discounts.Discount")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsTopSelling)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }

        public IEnumerable<Product> GetPopularDestination(int limit)
        {
            return _context.Products.Include("Photos")
                                     .Include("Label")
                                     .Include("Discounts")
                                      .Include("Discounts.Discount")
                                     .Where(p => p.Status)
                                     .Where(p => p.IsTopSelling)
                                     .OrderByDescending(p => p.AddedDate)
                                     .Take(limit)
                                     .ToList();
        }

        public IEnumerable<Product> GetBlog(int limit)
        {
            return _context.Products.Include("Photos")
                                  .Include("Label")
                                  .Include("Discounts")
                                   .Include("Discounts.Discount")
                                  .Where(p => p.Status)
                                  .Where(p => p.IsTopSelling)
                                  .OrderByDescending(p => p.AddedDate)
                                  .Take(limit)
                                  .ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId, int take, int skip)
        {
            return _context.Products.Include("Photos")
                                    .Include("Label")
                                    .Include("Discounts")
                                     .Include("Discounts.Discount")
                                    .Where(p => p.CategoryId == categoryId)
                                    .Where(p => p.Status)
                                    .Where(p => p.IsTopSelling)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(take)
                                    .Skip(skip)
                                    .ToList();
        }

        public object GetProductsByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetProductsById(int id)
        {
            return _context.Products.Include("Photos")
                                     .Include("Label")
                                     .Include("Discounts")
                                     .Include("Discounts.Discount")
                                     .Include("Category")
                                     .Include("Category.Department")
                                     .Include("Reviews")
                                     .FirstOrDefault(p => p.Status && p.Id == id);
                                   //.Include("Options")

        }
    }
}
