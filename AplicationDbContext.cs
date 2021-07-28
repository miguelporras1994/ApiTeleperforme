using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teleperforme.Models;

namespace Teleperforme
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {



        }

        public DbSet<Business> Business{ get; set; }
     

    }
}
