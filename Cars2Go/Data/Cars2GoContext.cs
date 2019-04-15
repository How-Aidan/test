using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cars2Go.Models
{
    public class Cars2GoContext : DbContext
    {
        public Cars2GoContext (DbContextOptions<Cars2GoContext> options)
            : base(options)
        {
        }

        public DbSet<Cars2Go.Models.Rental> Rental { get; set; }
    }
}
