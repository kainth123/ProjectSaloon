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
    
    public class SaloonsController : Controller
    {
        private readonly ProjectSaloonContext _context;

        public SaloonsController(ProjectSaloonContext context)
        {
            _context = context;
        }

        // GET: Saloons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saloon.ToListAsync());
        }

        // GET: Saloons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saloon = await _context.Saloon
                .FirstOrDefaultAsync(m => m.SaloonID == id);
            if (saloon == null)
            {
                return NotFound();
            }

            return View(saloon);
        }
       
        // GET: Saloons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Saloons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SaloonID,SaloonName,SaloonAddress,Contact_Number")] Saloon saloon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saloon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saloon);
        }
        
        // GET: Saloons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saloon = await _context.Saloon.FindAsync(id);
            if (saloon == null)
            {
                return NotFound();
            }
            return View(saloon);
        }

        // POST: Saloons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SaloonID,SaloonName,SaloonAddress,Contact_Number")] Saloon saloon)
        {
            if (id != saloon.SaloonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saloon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaloonExists(saloon.SaloonID))
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
            return View(saloon);
        }

        // GET: Saloons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saloon = await _context.Saloon
                .FirstOrDefaultAsync(m => m.SaloonID == id);
            if (saloon == null)
            {
                return NotFound();
            }

            return View(saloon);
        }

        // POST: Saloons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saloon = await _context.Saloon.FindAsync(id);
            _context.Saloon.Remove(saloon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaloonExists(int id)
        {
            return _context.Saloon.Any(e => e.SaloonID == id);
        }
    }
}
