﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Models;

namespace Travel.ViewComponents
{
    public class HoneymoonViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public HoneymoonViewComponent(IMapper mapper,
                                IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productRepository.GetSpecialNatureProducts(8);
            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View (model);
        }
    }
}
