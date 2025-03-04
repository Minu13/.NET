﻿using EmployeeCRUDAppWithDB.Domain;
using EmployeeCRUDAppWithDB.DTOs;
using EmployeeCRUDAppWithDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUDAppWithDB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        //via DI
        public EmployeeController(IEmployeeService employeeService)
        {

            _employeeService = employeeService;
        }
        public IActionResult DisplayAll()
        {
            var dto = new DisplayAllDto();
            dto.Count = _employeeService.HeadCount();
            dto.HeaderTitle = "Displaying all Employee information";
            dto.Employees = _employeeService.Get().ToList();

            return View(dto);
        }


        public IActionResult Add()
        {
            var dto = new EmployeeAddDto();
            dto.HeaderTitle = "Employee Add form";

            return View(dto);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddDto dto)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee();
                emp.Id = _employeeService.HeadCount() + 1;
                emp.Name = dto.Name;
                emp.Salary = dto.Salary;
                _employeeService.Add(emp);
                return RedirectToAction("DisplayAll");

            }
            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var dto = new EmployeeEditDto();
            dto.HeaderTitle = "Employee edit form";

            var emp = _employeeService.GetById(id);
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Salary = emp.Salary;

            return View(dto);

        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditDto dto)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee();
                emp.Id = dto.Id;
                emp.Name = dto.Name;
                emp.Salary = dto.Salary;
                _employeeService.Update(emp);
                return RedirectToAction("DisplayAll");

            }

            return View(dto);

        }
        public IActionResult Delete(int id)
        {
            var emp = _employeeService.GetById(id);
            if (emp == null)
            {
                return NotFound();
            }


            var dto = new EmployeeDeleteDto
            {
                Id = emp.Id,
                Name = emp.Name,
                Salary = emp.Salary,
                HeaderTitle = "Delete Employee"
            };

            return View(dto);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _employeeService.Remove(id);
            return RedirectToAction("DisplayAll");
        }
    }
}