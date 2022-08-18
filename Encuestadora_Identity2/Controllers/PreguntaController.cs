using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Encuestadora_Identity2.Data;
using Encuestadora_Identity2.Models;

namespace Encuestadora_Identity2.Controllers
{
    public class PreguntaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PreguntaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pregunta
        public async Task<IActionResult> Index(int EncuestaId)
        {
            //var encuestadoraDBContext = _context.preguntas.Include(p => p.Encuesta);
            ViewBag.Encuesta = _context.encuestas.Single(e => e.EncuestaId == EncuestaId);
            var encuestadoraDBContext = _context.preguntas.Include(e => e.opciones).Where(e => e.EncuestaId == EncuestaId);
            return View(await encuestadoraDBContext.ToListAsync());
        }

        // GET: Pregunta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.preguntas
                .Include(e => e.opciones)
                .FirstOrDefaultAsync(m => m.PreguntaId == id);
            if (pregunta == null)
            {
                return NotFound();
            }

            return View(pregunta);
        }

        // GET: Pregunta/Create
        public IActionResult Create(int EncuestaId)
        {
            var encuesta = _context.encuestas.Single(i => i.EncuestaId == EncuestaId);
            ViewBag.encuesta = encuesta;
            ViewBag.EncuestaId = encuesta.EncuestaId;
            return View();
        }

        // POST: Pregunta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PreguntaId,tituloPregunta,EncuestaId")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pregunta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Pregunta", new { EncuestaId = pregunta.EncuestaId });
            }
            ViewBag.EncuestaId = pregunta.Encuesta.EncuestaId;
            return View(pregunta);
        }

        // GET: Pregunta/Edit/5
        public async Task<IActionResult> Edit(int? id, int EncuestaId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.preguntas.FindAsync(id);
            if (pregunta == null)
            {
                return NotFound();
            }
            var encuesta = _context.encuestas.Single(i => i.EncuestaId == EncuestaId);
            ViewBag.encuesta = encuesta;
            return View(pregunta);
        }

        // POST: Pregunta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PreguntaId,tituloPregunta,EncuestaId")] Pregunta pregunta)
        {
            //if (id != pregunta.PreguntaId)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pregunta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreguntaExists(pregunta.PreguntaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Pregunta", new { EncuestaId = pregunta.EncuestaId });
            }
            ViewBag.EncuestaId = pregunta.EncuestaId;
            return View(pregunta);
        }

        // GET: Pregunta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pregunta = await _context.preguntas
                .Include(o => o.Encuesta)
                .FirstOrDefaultAsync(m => m.PreguntaId == id);
            if (pregunta == null)
            {
                return NotFound();
            }

            return View(pregunta);
        }

        // POST: Pregunta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pregunta = await _context.preguntas.FindAsync(id);
            _context.preguntas.Remove(pregunta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Pregunta", new { EncuestaId = pregunta.EncuestaId });
        }

        private bool PreguntaExists(int id)
        {
            return _context.preguntas.Any(e => e.PreguntaId == id);
        }
    }
}
