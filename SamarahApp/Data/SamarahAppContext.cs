using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SamarahApp.Model;

namespace SamarahApp.Data
{
    public class SamarahAppContext : DbContext
    {
        public SamarahAppContext (DbContextOptions<SamarahAppContext> options)
            : base(options)
        {
        }

        public DbSet<SamarahApp.Model.Product> Product { get; set; } = default!;

        public DbSet<SamarahApp.Model.User>? User { get; set; }
    }
}
