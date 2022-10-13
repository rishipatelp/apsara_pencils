using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using apsara_pencils.Data;
using apsara_pencils.Models;

namespace apsara_pencils.Controllers
{
    public class PencilClassesController : Controller
    {
        private readonly apsara_pencilsContext _context;

        public PencilClassesController(apsara_pencilsContext context)
        {
            _context = context;
        }

        // GET: PencilClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.PencilClass.ToListAsync());
        }

        // GET: PencilClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pencilClass = await _context.PencilClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pencilClass == null)
            {
                return NotFound();
            }

            return View(pencilClass);
        }

        // GET: PencilClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PencilClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,productName,Price,Color,Category")] PencilClass pencilClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pencilClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pencilClass);
        }

        // GET: PencilClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pencilClass = await _context.PencilClass.FindAsync(id);
            if (pencilClass == null)
            {
                return NotFound();
            }
            return View(pencilClass);
        }

        // POST: PencilClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,productName,Price,Color,Category")] PencilClass pencilClass)
        {
            if (id != pencilClass.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pencilClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PencilClassExists(pencilClass.ID))
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
            return View(pencilClass);
        }

        // GET: PencilClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pencilClass = await _context.PencilClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pencilClass == null)
            {
                return NotFound();
            }

            return View(pencilClass);
        }

        // POST: PencilClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pencilClass = await _context.PencilClass.FindAsync(id);
            _context.PencilClass.Remove(pencilClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PencilClassExists(int id)
        {
            return _context.PencilClass.Any(e => e.ID == id);
        }
    }
}
