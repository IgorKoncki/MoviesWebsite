using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia9.Models
{
    public class Cwiczenia9Context : DbContext
    {
        public Cwiczenia9Context (DbContextOptions<Cwiczenia9Context> options)
            : base(options)
        {
        }

        public DbSet<Cwiczenia9.Models.Movie> Movie { get; set; }
    }
}
