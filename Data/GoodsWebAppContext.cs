using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoodsWebApp.Models;

namespace GoodsWebApp.Data
{
    public class GoodsWebAppContext : DbContext
    {
        public GoodsWebAppContext (DbContextOptions<GoodsWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<GoodsWebApp.Models.Users> Users { get; set; } = default!;
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(u => new { u.QQ, u.CN });

            base.OnModelCreating(modelBuilder);
        }*/
    }
}