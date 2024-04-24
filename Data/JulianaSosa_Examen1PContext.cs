using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JulianaSosa_Examen1P.Models;

    public class JulianaSosa_Examen1PContext : DbContext
    {
        public JulianaSosa_Examen1PContext (DbContextOptions<JulianaSosa_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<JulianaSosa_Examen1P.Models.JS_Medicinas> JS_Medicinas { get; set; } = default!;
    //Update Data Base 
    }
