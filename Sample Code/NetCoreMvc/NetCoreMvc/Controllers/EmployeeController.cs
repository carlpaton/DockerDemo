using Microsoft.AspNetCore.Mvc;
using NetCoreMvc.Common;

namespace NetCoreMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IGetEmployee _context;

        public EmployeeController(IGetEmployee context)
        {
            _context = context;
        }

        // GET: Employee
        public ActionResult Index()
        {
            var dbModel = _context.SelectList();
            return View(dbModel);
        }

        // GET: Employee/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var employeeViewModel = await _context.EmployeeViewModel
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (employeeViewModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employeeViewModel);
        //}

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Surname,Title,JobRole,StartDate")] EmployeeViewModel employeeViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(employeeViewModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(employeeViewModel);
        //}

        // GET: Employee/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var employeeViewModel = await _context.EmployeeViewModel.SingleOrDefaultAsync(m => m.Id == id);
        //    if (employeeViewModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(employeeViewModel);
        //}

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Title,JobRole,StartDate")] EmployeeViewModel employeeViewModel)
        //{
        //    if (id != employeeViewModel.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(employeeViewModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EmployeeViewModelExists(employeeViewModel.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(employeeViewModel);
        //}

        // GET: Employee/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var employeeViewModel = await _context.EmployeeViewModel
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (employeeViewModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employeeViewModel);
        //}

        // POST: Employee/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var employeeViewModel = await _context.EmployeeViewModel.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.EmployeeViewModel.Remove(employeeViewModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EmployeeViewModelExists(int id)
        //{
        //    return _context.EmployeeViewModel.Any(e => e.Id == id);
        //}
    }
}
