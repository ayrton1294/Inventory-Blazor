using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEnitity> InOuts { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WareHouseEntity> WareHouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server = localhost; Database = InventoryDb; Trusted_Connection = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumeria" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );
            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity() { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Main WareHouse", WareHouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540" },
                new WareHouseEntity() { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Second WareHouse", WareHouseAddress = "4447 Dane Street, Yakima, WA 98908" },
                new WareHouseEntity() { WareHouseId = Guid.NewGuid().ToString(), WareHouseName = "Third WareHouse", WareHouseAddress = "3003 Arrowood Drive, Jacksonville, FL 32257" }
                );
        }
    }
}