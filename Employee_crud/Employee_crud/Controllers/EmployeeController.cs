using Employee_crud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_crud.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> employees = new List<Employee>();
        public IActionResult Index()
        {

            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var _employee = employees.FirstOrDefault(p => p.IdEmployee == employee.IdEmployee);
            if (_employee == null)
            {
                employees.Add(employee);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit (int id)
        {
            var employee = employees.FirstOrDefault(p => p.IdEmployee == id);
            if(employee != null)
            {
                return View(employee);
            }

            return RedirectToAction("Index", "Employee");
        }
        [HttpPost]
        public IActionResult Edit (Employee employee)
        {
            var _employee = employees.FirstOrDefault(p => p.IdEmployee == employee.IdEmployee);
            if (_employee != null)
            {
                _employee.NameEmployee = employee.NameEmployee;
                _employee.AgeEmployee = employee.AgeEmployee;
                _employee.DailySalary = employee.DailySalary;
                _employee.NumberDay = employee.NumberDay;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var _employee = employees.FirstOrDefault(p => p.IdEmployee == id);
            if (_employee != null)
            {
                employees.Remove(_employee);
            }
            return RedirectToAction("Index");
        }
    }
}
