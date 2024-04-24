using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JulianaSosa_Examen1P.Models;

namespace JulianaSosa_Examen1P.Controllers
{
    public class MedicinasController : Controller
    {
        private readonly JulianaSosa_Examen1PContext _context;

        public MedicinasController(JulianaSosa_Examen1PContext context)
        {
            _context = context;
        }

        // GET: Medicinas
        public async Task<IActionResult> Index()
        {
            return View(await _context.JS_Medicinas.ToListAsync());
        }

        // GET: Medicinas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jS_Medicinas = await _context.JS_Medicinas
                .FirstOrDefaultAsync(m => m.JS_MedicinasID == id);
            if (jS_Medicinas == null)
            {
                return NotFound();
            }

            return View(jS_Medicinas);
        }

        // GET: Medicinas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medicinas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JS_MedicinasID,JS_DescripcionMedicina,JS_FechaDeEntrega,JS_ConReceta")] JS_Medicinas jS_Medicinas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jS_Medicinas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jS_Medicinas);
        }

        // GET: Medicinas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jS_Medicinas = await _context.JS_Medicinas.FindAsync(id);
            if (jS_Medicinas == null)
            {
                return NotFound();
            }
            return View(jS_Medicinas);
        }

        // POST: Medicinas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JS_MedicinasID,JS_DescripcionMedicina,JS_FechaDeEntrega,JS_ConReceta")] JS_Medicinas jS_Medicinas)
        {
            if (id != jS_Medicinas.JS_MedicinasID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jS_Medicinas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JS_MedicinasExists(jS_Medicinas.JS_MedicinasID))
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
            return View(jS_Medicinas);
        }

        // GET: Medicinas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jS_Medicinas = await _context.JS_Medicinas
                .FirstOrDefaultAsync(m => m.JS_MedicinasID == id);
            if (jS_Medicinas == null)
            {
                return NotFound();
            }

            return View(jS_Medicinas);
        }

        // POST: Medicinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jS_Medicinas = await _context.JS_Medicinas.FindAsync(id);
            if (jS_Medicinas != null)
            {
                _context.JS_Medicinas.Remove(jS_Medicinas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JS_MedicinasExists(int id)
        {
            return _context.JS_Medicinas.Any(e => e.JS_MedicinasID == id);
        }
    }
}
