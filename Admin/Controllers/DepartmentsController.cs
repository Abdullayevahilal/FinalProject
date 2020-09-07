using Admin.Filter;
using Admin.Models.Shopping;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System.Collections.Generic;

namespace Admin.Controllers
{
    //[TypeFilter(typeof(Auth))]
    public class DepartmentsController : Controller

    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public DepartmentsController(IDepartmentRepository departmentRepository,
                                      IMapper mapper)
        {
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var departments = _departmentRepository.GetDepartments();

            var model = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                Department department = _mapper.Map<DepartmentViewModel, Department>(model);
                department.AddedBy = _admin.Fulname;

                _departmentRepository.CreateDepartment(department);

                return RedirectToAction("index");
            }

            return View(model);
        }
        public IActionResult Edit(int id)
        {
            Department department = _departmentRepository.GetDepartmentById(id);

            if (department == null) return NotFound();

            var model = _mapper.Map<Department, DepartmentViewModel>(department);

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                Department department = _mapper.Map<DepartmentViewModel, Department>(model);
                department.ModifiedBy = _admin.Fulname;

                Department deparmentToUpdate = _departmentRepository.GetDepartmentById(model.Id);

                if (deparmentToUpdate == null) return NotFound();

                _departmentRepository.UpdateDepartment(deparmentToUpdate, department);

                return RedirectToAction("index");
            }

            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Department department = _departmentRepository.GetDepartmentById(id);

            if (department == null) return NotFound();

            _departmentRepository.DeleteDepartment(department);

            return RedirectToAction("index");
        }

    }
}