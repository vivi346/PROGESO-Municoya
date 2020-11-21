using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROGESO.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Telefono { get; set; }
        public string Distrito { get; set; }

    }
}
