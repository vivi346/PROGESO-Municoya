using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROGESO.Data;
using PROGESO.Models;
using PROGESO.Utility;

namespace PROGESO.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Manager)]
    public class ProveedoresController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProveedoresController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.Proveedores.ToListAsync());
        }
        //GET CREATE 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Proveedores proveedores)
        {
            try
            {
                if (ModelState.IsValid)
                {
                  

                        var Provee = new Proveedores();
                    Provee.ced_juridica = proveedores.ced_juridica;
                    Provee.nombre = proveedores.nombre;

                    _db.Proveedores.Add(Provee);
                    _db.SaveChanges();


                }
                return Redirect("Index");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //GET EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var proveedores = await _db.Proveedores.FindAsync(id);
            if (proveedores == null)
            {
                return NotFound();
            }
            return View(proveedores);

        }


        //POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Proveedores proveedores)
        {
            if (ModelState.IsValid)
            {
                _db.Update(proveedores);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proveedores);
        }


        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var proveedores = await _db.Proveedores.FindAsync(id);
            if (proveedores == null)
            {
                return NotFound();
            }
            return View(proveedores);
        }

        //POST DELETE

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var proveedores = await _db.Proveedores.FindAsync(id);
            if (proveedores == null)
            {
                return View();
            }
            _db.Proveedores.Remove(proveedores);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var proveedores = await _db.Proveedores.FindAsync(id);
            if (proveedores == null)
            {
                return NotFound();
            }
            return View(proveedores);
        }
    }
}
