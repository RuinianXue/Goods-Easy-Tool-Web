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
        public DbSet<GoodsWebApp.Models.Goods> Goods { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.GoodsBatch> GoodsBatch { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.GoodsType> GoodsType { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.BatchToType> BatchToType { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.BlockList> BlockList { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.Character> Character { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.CharacterPriority> CharacterPriority { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.DeliveryCheckList> DeliveryCheckList { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.MoneyCheckList> MoneyCheckList { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.Order> Order { get; set; } = default!;
        public DbSet<GoodsWebApp.Models.PromoteCheckList> PromoteCheckList { get; set; } = default!;
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(u => new { u.QQ, u.CN });

            base.OnModelCreating(modelBuilder);
        }*/
    }
}