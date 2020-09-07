using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filter;
using Admin.Models.Shopping;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;

namespace Admin.Controllers
{ 
    //[TypeFilter(typeof(Auth))]
    public class CategoriesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryRepository categoryRepository,
                                   IMapper mapper)
        {
            _mapper = mapper;
            _categoryRepository= categoryRepository;
        }
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetCategories();

            var model = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Category category = _mapper.Map<CategoryViewModel, Category>(model);
                category.AddedBy = _admin.Fulname;

                _categoryRepository.CreateCategory(category);

                return RedirectToAction("index");
            }

            return View(model);
        }
        public IActionResult Edit(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);

            if (category == null) return NotFound();

            var model = _mapper.Map<Category, CategoryViewModel>(category);

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Category category = _mapper.Map<CategoryViewModel, Category>(model);
                category.ModifiedBy = _admin.Fulname;

                Category categoryToUpdate = _categoryRepository.GetCategoryById(model.Id);

                if (categoryToUpdate == null) return NotFound();

                _categoryRepository.UpdateCategory(categoryToUpdate, category);

                return RedirectToAction("index");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);

            if (category == null) return NotFound();

            _categoryRepository.DeleteCategory(category);

            return RedirectToAction("index");
        }
    }
}