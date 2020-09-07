using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
   public class TravelDbContext :DbContext
    {
        public TravelDbContext(DbContextOptions<TravelDbContext> options) :base(options){ }
                public DbSet<Category> Categories { get; set; }
               public DbSet<Department> Departments  { get; set; }
              public DbSet<Discount> Discounts { get; set; }
             public DbSet<Favorite> Favorites  { get; set; }
             public DbSet<Label> Labels { get; set; }
             public DbSet<Product> Products { get; set; }
             public DbSet<ProductDiscount> ProductDiscounts { get; set; }
             public DbSet<ProductPhoto> ProductPhotos { get; set; }
             public DbSet<ProductReview>ProductReviews  { get; set; }
             public DbSet<Setting> Settings { get; set; }
             public DbSet<Slider> Sliders  { get; set; }         
             public DbSet<User> Users { get; set; }
             public DbSet<Admin> Admins { get; set; }
    }
}
