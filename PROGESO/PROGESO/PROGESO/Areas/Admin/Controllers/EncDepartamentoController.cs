using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROGESO.Data;
using PROGESO.Models;
using PROGESO.Utility;

namespace PROGESO.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Manager)]
    public class EncDepartamentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EncDepartamentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/EncDepartamento
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EncDepartamento.Include(e => e.Departament);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/EncDepartamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encDepartamento = await _context.EncDepartamento
                .Include(e => e.Departament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (encDepartamento == null)
            {
                return NotFound();
            }

            return View(encDepartamento);
        }

        // GET: Admin/EncDepartamento/Create
        public IActionResult Create()
        {
            ViewData["DepartamentID"] = new SelectList(_context.Departament, "Id", "Name");
            return View();
        }

        // POST: Admin/EncDepartamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Correo,Nombre,Apellido1,Apellido2,DepartamentID")] EncDepartamento encDepartamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(encDepartamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartamentID"] = new SelectList(_context.Departament, "Id", "Name", encDepartamento.DepartamentID);
            return View(encDepartamento);
        }

        // GET: Admin/EncDepartamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encDepartamento = await _context.EncDepartamento.FindAsync(id);
            if (encDepartamento == null)
            {
                return NotFound();
            }
            ViewData["DepartamentID"] = new SelectList(_context.Departament, "Id", "Name", encDepartamento.DepartamentID);
            return View(encDepartamento);
        }

        // POST: Admin/EncDepartamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EncDepartamento model)
        {
            if (ModelState.IsValid)
            {
                var EncExist = _context.EncDepartamento.Include(s => s.Departament).Where(s => s.Correo == model.Correo
                                  && s.Nombre == model.Nombre && s.Apellido1 == model.Apellido1 && s.Apellido2 == model.Apellido2);

                var EncDepartFromDB = await _context.EncDepartamento.FindAsync(id);
                EncDepartFromDB.Correo = model.Correo;
                EncDepartFromDB.Nombre = model.Nombre;
                EncDepartFromDB.Apellido1 = model.Apellido1;
                EncDepartFromDB.Apellido2 = model.Apellido2;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            };

            return View(model);
        }

        // GET: Admin/EncDepartamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var encDepartamento = await _context.EncDepartamento
                .Include(e => e.Departament)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (encDepartamento == null)
            {
                return NotFound();
            }

            return View(encDepartamento);
        }

        // POST: Admin/EncDepartamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var encDepartamento = await _context.EncDepartamento.FindAsync(id);
            _context.EncDepartamento.Remove(encDepartamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EncDepartamentoExists(int id)
        {
            return _context.EncDepartamento.Any(e => e.Id == id);
        }
    }
}
