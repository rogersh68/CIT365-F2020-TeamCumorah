using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MegaDeskRazorApp.Models
{
    public class MegaDeskRazorAppContext : DbContext
    {
        public MegaDeskRazorAppContext (DbContextOptions<MegaDeskRazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskRazorApp.Models.Quote> Quote { get; set; }
    }
}
