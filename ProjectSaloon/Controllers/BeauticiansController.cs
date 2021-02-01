using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectSaloon.Data;
using ProjectSaloon.Models;

namespace ProjectSaloon.Controllers
{
    [Authorize]
    public class BeauticiansController : Controller
    {
        private readonly ProjectSaloonContext _context;

        public BeauticiansController(ProjectSaloonContext context)
        {
            _context = context;
        }

        // GET: Beauticians
        public async Task<IActionResult> Index()
        {
            var projectSaloonContext = _context.Beautician.Include(b => b.Saloon_obj);
            return View(await projectSaloonContext.ToListAsync());
        }

        // GET: Beauticians/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beautician = await _context.Beautician
                .Include(b => b.Saloon_obj)
                .FirstOrDefaultAsync(m => m.BeauticianID == id);
            if (beautician == null)
            {
                return NotFound();
            }

            return View(beautician);
        }
        [Authorize]
        // GET: Beauticians/Create
        public IActionResult Create()
        {
            ViewData["SaloonID"] = new SelectList(_context.Saloon, "SaloonID", "SaloonName");
            return View();
        }

        // POST: Beauticians/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BeauticianID,BeauticianName,ContactNumber,JoiningDate,Salary,SaloonID")] Beautician beautician)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beautician);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SaloonID"] = new SelectList(_context.Saloon, "SaloonID", "SaloonName", beautician.SaloonID);
            return View(beautician);
        }
        [Authorize]
        // GET: Beauticians/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beautician = await _context.Beautician.FindAsync(id);
            if (beautician == null)
            {
                return NotFound();
            }
            ViewData["SaloonID"] = new SelectList(_context.Saloon, "SaloonID", "SaloonName", beautician.SaloonID);
            return View(beautician);
        }

        // POST: Beauticians/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BeauticianID,BeauticianName,ContactNumber,JoiningDate,Salary,SaloonName")] Beautician beautician)
        {
            if (id != beautician.BeauticianID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beautician);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeauticianExists(beautician.BeauticianID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["SaloonID"] = new SelectList(_context.Saloon, "SaloonID", "SaloonID", beautician.SaloonID);
            return View(beautician);
        }

        // GET: Beauticians/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beautician = await _context.Beautician
                .Include(b => b.Saloon_obj)
                .FirstOrDefaultAsync(m => m.BeauticianID == id);
            if (beautician == null)
            {
                return NotFound();
            }

            return View(beautician);
        }

        // POST: Beauticians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var beautician = await _context.Beautician.FindAsync(id);
            _context.Beautician.Remove(beautician);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BeauticianExists(int id)
        {
            return _context.Beautician.Any(e => e.BeauticianID == id);
        }
    }
}
