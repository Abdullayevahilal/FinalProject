using Repository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly TravelDbContext _context;
        public ContentRepository(TravelDbContext context)
        {

            _context = context;
        }
    }
}
