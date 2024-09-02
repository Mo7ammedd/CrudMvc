using System;
using BLL.Interfaces;
using BLL.Repositries;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartemntRepository _departemntRepo;

        public DepartmentController(IDepartemntRepository departemntRepo)
        {
            _departemntRepo = departemntRepo;
        }

        public IActionResult Index()
        {
            var dapartments = _departemntRepo.GetAll();
            return View(dapartments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _departemntRepo.Add(department);
                return RedirectToAction("Index");
            }

            return View(department);
        }

        [HttpGet]
        public IActionResult Details(int? id, string viewName = "Details")
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            var department = _departemntRepo.Get(id.Value);
            if (department == null)
            {
                return NotFound(); //404
            }

            return View(department);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            var department = _departemntRepo.Get(id.Value);
            if (department == null)
            {
                return NotFound(); //404
            }

            return View(department);
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int id, Department department)

        {
            if (id != department.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid) return View(department);
            try
            {
                _departemntRepo.Update(department);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }

            return View(department);
        }

        public IActionResult Delete(int? id)
        {
            return Details(id, "Delete");

        }

        [HttpPost]
        public IActionResult Delete(Department department)
        {
            try
            {
                _departemntRepo.Delete(department);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
               ModelState.AddModelError("", e.Message);
               return View("Details", department);
            }
        }
    }
}