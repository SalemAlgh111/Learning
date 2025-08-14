using Learning.Models;
using Learning.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Learning.Controllers
{
    public class EmployeeController : Controller
    {
        public AppDbContext Context;
        public EmployeeVM employeeVM = new EmployeeVM();
        public CreateEmployee Cempolyee = new CreateEmployee();


        public IActionResult Create()
        {
            var vm = new CreateEmployee();
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateEmployee Newemployee)
        {
            if (!ModelState.IsValid)
            {
                return View(Newemployee);
            }
            var employee = Newemployee.ToEmployee();
            Context.Employees.Add(employee);
            Context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
