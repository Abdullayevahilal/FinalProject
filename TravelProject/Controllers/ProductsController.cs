using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using Travel.Models;

namespace Travel.Controllers
{
    public class ProductsController : Controller
    {
        public readonly IMapper _mapper;
        public readonly IProductRepository _productRepository;
        //public readonly IAuth _auth;
        //public readonly IFileManager _fileManager;
        public ProductsController(IMapper mapper,
                                  IProductRepository productRepository)
                                  //IAuth _auth,
                                  //IFileManager _fileManager)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            //_auth = auth;
            //_fileManager = _fileManager;

        }

        public IActionResult Index(int id)
        {
            var product = _productRepository.GetProductsById(id);
            if (product == null) return NotFound();
            var model = _mapper.Map<Product, ProductViewModel>(product);
            return View(model);

        }
       
    }
}