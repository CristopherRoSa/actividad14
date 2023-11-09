using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFeei.Models;

namespace MvcFeei.Data
{
    public class MvcFeeiContext : DbContext
    {
        public MvcFeeiContext (DbContextOptions<MvcFeeiContext> options)
            : base(options)
        {
        }

        public DbSet<MvcFeei.Models.Alumno> Alumno { get; set; } = default!;
    }
}
