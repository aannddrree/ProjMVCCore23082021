using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjMVCCore23082021.Models;

namespace ProjMVCCore23082021.Data
{
    public class ProjMVCCore23082021Context : DbContext
    {
        public ProjMVCCore23082021Context (DbContextOptions<ProjMVCCore23082021Context> options)
            : base(options)
        {
        }

        public DbSet<ProjMVCCore23082021.Models.Client> Client { get; set; }

        public DbSet<ProjMVCCore23082021.Models.Venda> Venda { get; set; }

    }
}
