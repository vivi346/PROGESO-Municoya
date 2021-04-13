using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROGESO.Models;

namespace PROGESO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Departament> Departament { get; set; }
        public DbSet<EncDepartamento> EncDepartamento { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<ProductoProveedor> ProductoProveedor { get; set; }





    }
}
