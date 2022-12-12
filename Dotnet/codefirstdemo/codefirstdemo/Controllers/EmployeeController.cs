using codefirstdemo.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codefirstdemo.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly employeeDbContext _context;

        public EmployeeController(employeeDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()

        {
            //linq queries
            //get name  of employee with salary 50000
            ViewBag.Salname = _context.Employees.Where(d => d.Salary == 50000).FirstOrDefault().Name;
            //designation whose address is new delhi

            ViewBag.add = _context.Employees.Where(d => d.Address == "New Delhi").FirstOrDefault().Designation;
            return View(await _context.Employees.ToListAsync());

            
            
        }
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Create([Bind("EmployeeId,Name,Age,Address,CompanyName,Designation,Salary")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                

            }
            return View();
        }

        public async Task<IActionResult> Details(int id)

        {
            var employee = await _context.Employees.FirstOrDefaultAsync(m => m.EmployeeId == id);
            return View(employee);
        }


        public async Task<IActionResult> Edit(int? id)

        {
            var employee = await _context.Employees.FindAsync(id);
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,Age,Address,CompanyName,Designation,Salary")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }


        public async Task<IActionResult> Delete(int? id)

        {
            var employee = await _context.Employees.FindAsync(id);
            return View(employee);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
            
        }

    }
}
