using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.BlogRepositories
{
   public class BlogRepository:IBlogRepository
    {

        private readonly TravelDbContext _context;
        public BlogRepository(TravelDbContext context)
        {

            _context = context;
        }

        public IEnumerable<Blog> GetBlogs(int limit)
        {
            return _context.Blogs/*Include("Photo")*/
                                  .Where(b => b.Status)
                                  .OrderByDescending(b => b.AddedDate)
                                  .Take(limit)
                                  .ToList();
        }
        }
    }

