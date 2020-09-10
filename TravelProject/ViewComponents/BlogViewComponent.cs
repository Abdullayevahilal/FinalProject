using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.BlogRepositories;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Models;
using Travel.Models.Blog;

namespace Travel.ViewComponents
{
    public class BlogViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;
        public BlogViewComponent(IMapper mapper,
                                IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
        }
        public IViewComponentResult Invoke()
        {
            var blog = _blogRepository.GetBlogs(8);
            var model = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogViewModel>>(blog);
            return View(model);
        }
    }
}

