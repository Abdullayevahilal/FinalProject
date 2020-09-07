using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using Travel.Models;

namespace Travel.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public CategoriesController(IMapper mapper,
                                    ICategoryRepository categoryRepository,
                                    IProductRepository productRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

      
    }
    //public IActionResult Index()
    //    {
    //        return View();
    //    }
    }
