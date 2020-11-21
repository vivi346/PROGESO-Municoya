using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROGESO.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PROGESO.Models;
using PROGESO.Utility;

namespace PROGESO.Areas.Admin.Controllers

{
    [Area("Admin")]
    [Authorize(Roles = SD.Manager)]
    public class DepartamentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DepartamentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _db.Departament.ToListAsync());
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Index(string dato)
        //{
        //    if (dato == null)
        //    {
        //        // return View(await _db.Category.AsNoTracking().ToListAsync());
        //        return View(await _db.Departament.ToListAsync());
        //    }
        //    else
        //    {
        //        var dep = await _db.Departament.Where(c => c.Name == dato).ToListAsync();
        //        return View(dep);
        //    }
        //}

        public ActionResult Create()
        {
            return View();
        }
        //POST - CREATE

        [HttpPost]
        public ActionResult Create(Departament departament)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var Depart = new Departament();
                    Depart.Name = departament.Name;

                    _db.Departament.Add(Depart);
                    _db.SaveChanges();


                }
                return Redirect("Index");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        // GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var departament = await _db.Departament.FindAsync(id);
            if (departament == null)
            {
                return NotFound();
            }
            return View(departament);
        }
        // POST - EDIT
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Departament departament)
        {
            if (ModelState.IsValid)
            {
                _db.Update(departament);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departament);
        }
        //GET - DELETE
        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    var departament = _db.Departament.Find(id);
        //    if (departament == null)
        //    {
        //        return View();
        //    }
        //    _db.Departament.Remove(departament);
        //    _db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));

        //}

        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var departament = await _db.Departament.FindAsync(id);
            if (departament == null)
            {
                return NotFound();
            }
            return View(departament);
        }

        //POST DELETE

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var departament = await _db.Departament.FindAsync(id);
            if (departament == null)
            {
                return View();
            }
            _db.Departament.Remove(departament);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        // GET - DETAILS 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var departament = await _db.Departament.FindAsync(id);
            if (departament == null)
            {
                return NotFound();

            }
            return View(departament);
        }
    }
}