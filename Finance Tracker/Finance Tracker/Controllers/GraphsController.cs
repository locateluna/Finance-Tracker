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
    public class GraphsController : Controller
    {
        private readonly Finance_TrackerContext _context;

        public GraphsController(Finance_TrackerContext context)
        {
            _context = context;
        }

        // GET: Graphs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Graph.ToListAsync());
        }

        // GET: Graphs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graph = await _context.Graph
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graph == null)
            {
                return NotFound();
            }

            return View(graph);
        }

        // GET: Graphs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Graphs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GraphNum,StartDt,EndDt,AcctNum")] Graph graph)
        {
            if (ModelState.IsValid)
            {
                _context.Add(graph);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(graph);
        }

        // GET: Graphs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graph = await _context.Graph.FindAsync(id);
            if (graph == null)
            {
                return NotFound();
            }
            return View(graph);
        }

        // POST: Graphs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GraphNum,StartDt,EndDt,AcctNum")] Graph graph)
        {
            if (id != graph.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(graph);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GraphExists(graph.Id))
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
            return View(graph);
        }

        // GET: Graphs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graph = await _context.Graph
                .FirstOrDefaultAsync(m => m.Id == id);
            if (graph == null)
            {
                return NotFound();
            }

            return View(graph);
        }

        // POST: Graphs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var graph = await _context.Graph.FindAsync(id);
            if (graph != null)
            {
                _context.Graph.Remove(graph);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GraphExists(int id)
        {
            return _context.Graph.Any(e => e.Id == id);
        }
    }
}
