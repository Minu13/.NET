using EmployeeCRUDApp.Domain;
using EmployeeCRUDApp.DTOs;
using EmployeeCRUDApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace EmployeeCRUDApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeservice;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeservice = employeeService;
        }


        public IActionResult DisplayAll()
        {
            var dto = new DisplayAllDto();
            dto.count = _employeeservice.Headcount();
            dto.HeaderTitle = "Display all employee information";
            dto.Employees = _employeeservice.Get().ToList();

            return View(dto);
        }

        public ActionResult Add()
        {
            var dto = new EmployeeAddDto();
            dto.HeaderTitle = "Employee add form";
            return View(dto);
        }

        [HttpPost]
        public ActionResult Add(EmployeeAddDto dto)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee();
                emp.Id = _employeeservice.Headcount() + 1;
                emp.Name = dto.Name;
                emp.Salary = dto.Salary;
                _employeeservice.Add(emp);
                return RedirectToAction("DisplayAll");
            }
            return View(dto);
        }
        public IActionResult Edit(int id)
        {
            var dto = new EmployeeEditDto();
            dto.HeaderTitle = "Employee edit form";
            var emp = _employeeservice.GetbyId(id);
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
                _employeeservice.Update(emp);
                return RedirectToAction("DisplayAll");

            }

            return View(dto);

        }
    }
}


    

