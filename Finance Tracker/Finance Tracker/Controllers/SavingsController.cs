using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Finance_Tracker.Data;
using Finance_Tracker.Models;

namespace Finance_Tracker.Controllers
{
    public class SavingsController : Controller
    {
        private readonly Finance_TrackerContext _context;

        public SavingsController(Finance_TrackerContext context)
        {
            _context = context;
        }

        // GET: Savings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saving.ToListAsync());
        }

        // GET: Savings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saving = await _context.Saving
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saving == null)
            {
                return NotFound();
            }

            return View(saving);
        }

        // GET: Savings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Savings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InterestRate,Id,Name,Value")] Saving saving)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saving);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saving);
        }

        // GET: Savings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saving = await _context.Saving.FindAsync(id);
            if (saving == null)
            {
                return NotFound();
            }
            return View(saving);
        }

        // POST: Savings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InterestRate,Id,Name,Value")] Saving saving)
        {
            if (id != saving.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saving);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SavingExists(saving.Id))
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
            return View(saving);
        }

        // GET: Savings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saving = await _context.Saving
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saving == null)
            {
                return NotFound();
            }

            return View(saving);
        }

        // POST: Savings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saving = await _context.Saving.FindAsync(id);
            if (saving != null)
            {
                _context.Saving.Remove(saving);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SavingExists(int id)
        {
            return _context.Saving.Any(e => e.Id == id);
        }
    }
}
