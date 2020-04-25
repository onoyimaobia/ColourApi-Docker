using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColourAPI.Model
{
    public class ColourContext: DbContext
    {
        public ColourContext(DbContextOptions<ColourContext> options): base(options)
        {

        }
        public DbSet<Colour> ColourItems { get; set; }
    }
}
