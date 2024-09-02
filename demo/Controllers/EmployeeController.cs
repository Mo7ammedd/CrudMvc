using System;
using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class EmployeeController : Controller
    {
          private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public IActionResult Index()
        {
            var employees = _employeeRepo.GetAll();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeRepo.Add(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        [HttpGet]
        public IActionResult Details(int? id, string viewName="Details")
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            var Employee = _employeeRepo.Get(id.Value);
            if ( Employee == null)
            {
                return NotFound(); //404
            }

            return View( Employee);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {

            return Details(id, "Edit");
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] int id, Employee employee)

        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid) return View(employee);
            try
            {
                _employeeRepo.Update(employee);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }

            return View("Edit", employee);
        }

        public IActionResult Delete(int? id)
        {
            return Details(id, "Delete");

        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            try
            {
                _employeeRepo.Delete(employee);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
               ModelState.AddModelError("", e.Message);
               return View("Delete", employee);
               
            }
        }
    }
}