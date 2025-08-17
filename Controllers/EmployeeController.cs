using Learning.Models;
using Learning.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learning.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Employee
        // يرجّع EmployeeVM إلى الفيو (Employees + Search)
        [HttpGet]
        public async Task<IActionResult> Index(string? search)
        {
            var q = _context.Employees.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                var s = search.ToLower();

                q = q.Where(e =>
                    e.FName.ToLower().Contains(s) ||
                    e.Department.ToLower().Contains(s) ||
                    e.Email.ToLower().Contains(s) ||
                    e.Id.ToString().Contains(s));
            }

            var vm = new EmployeeVM
            {
                Search = search,
                Employees = await q.OrderBy(e => e.FName).ToListAsync()
            };

            return View(vm);
        }

        // GET: /Employee/Create
        [HttpGet]
        public IActionResult Create()
        {
            var vm = new CreateEmployee();
            return View(vm);

        }

        // POST: /Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateEmployee newEmployee)
        {
            if (!ModelState.IsValid)
                return View(newEmployee);

            var employee = newEmployee.ToEmployee(); // يفترض عندك دالة تحويل في الـ ViewModel
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

