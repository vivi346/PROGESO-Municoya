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
    public class ProductoProveedorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoProveedorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ProductoProveedors
        public async Task<IActionResult> Index()
        {
            var pROGESOContext = _context.ProductoProveedor.Include(p => p.Producto).Include(p => p.Proveedores);
            return View(await pROGESOContext.ToListAsync());
        }

        // GET: Admin/ProductoProveedors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoProveedor = await _context.ProductoProveedor
                .Include(p => p.Producto)
                .Include(p => p.Proveedores)
                .FirstOrDefaultAsync(m => m.id == id);
            if (productoProveedor == null)
            {
                return NotFound();
            }

            return View(productoProveedor);
        }

        // GET: Admin/ProductoProveedors/Create
        public IActionResult Create()
        {
            ViewData["cod_prod"] = new SelectList(_context.Set<Producto>(), "cod_prod", "descripcion");
            ViewData["ced_juridica"] = new SelectList(_context.Set<Proveedores>(), "ced_juridica", "nombre");
            return View();
        }

        // POST: Admin/ProductoProveedors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ced_juridica,cod_prod,precio,cantidad,FechaCompra")] ProductoProveedor productoProveedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productoProveedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["cod_prod"] = new SelectList(_context.Set<Producto>(), "cod_prod", "descripcion", productoProveedor.cod_prod);
            ViewData["ced_juridica"] = new SelectList(_context.Set<Proveedores>(), "ced_juridica", "nombre", productoProveedor.ced_juridica);
            return View(productoProveedor);
        }

      

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productoProveedor = await _context.ProductoProveedor.FindAsync(id);
            if (productoProveedor == null)
            {
                return NotFound();
            }
            ViewData["cod_prod"] = new SelectList(_context.Set<Producto>(), "cod_prod", "descripcion", productoProveedor.cod_prod);
            ViewData["ced_juridica"] = new SelectList(_context.Set<Proveedores>(), "ced_juridica", "nombre", productoProveedor.ced_juridica);
            return View(productoProveedor);

        }


        //POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductoProveedor productoProveedor)
        {
            if (ModelState.IsValid)
            {
                _context.Update(productoProveedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["cod_prod"] = new SelectList(_context.Set<Producto>(), "cod_prod", "descripcion", productoProveedor.cod_prod);
            ViewData["ced_juridica"] = new SelectList(_context.Set<Proveedores>(), "ced_juridica", "nombre", productoProveedor.ced_juridica);
            return View(productoProveedor);
        }

        // GET: Admin/ProductoProveedors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoProveedor = await _context.ProductoProveedor
                .Include(p => p.Producto)
                .Include(p => p.Proveedores)
                .FirstOrDefaultAsync(m => m.id == id);
            if (productoProveedor == null)
            {
                return NotFound();
            }

            return View(productoProveedor);
        }

        // POST: Admin/ProductoProveedors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productoProveedor = await _context.ProductoProveedor.FindAsync(id);
            _context.ProductoProveedor.Remove(productoProveedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoProveedorExists(int id)
        {
            return _context.ProductoProveedor.Any(e => e.id == id);
        }
    }
}
