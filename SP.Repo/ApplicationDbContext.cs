using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SP.Data.EntityMapper;
using SP.Data.Models;
using System;

namespace SP.Repo
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VehicleTypeCategory> VehicleTypeCategories { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehiclePart> VehicleParts { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Category> Caterogories { get; set; }
        public DbSet<CategoryPart> CategoriesParts { get; set; }
        public DbSet<PartImage> PartImages { get; set; }
        public DbSet<PartManufacturer> PartManufacturers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new CategoryMap().Configure(modelBuilder.Entity<Category>());
            new PartMap().Configure(modelBuilder.Entity<Part>());
            new VehicleMap().Configure(modelBuilder.Entity<Vehicle>());
            
            SetKeys(modelBuilder);
            SetOneToMany(modelBuilder);
            SetManyToMany(modelBuilder);

        }
        private void SetKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
               .HasKey(x => x.Id);

            modelBuilder.Entity<VehicleType>()
               .HasKey(x => x.Id);

            modelBuilder.Entity<VehicleBrand>()
             .HasKey(x => x.Id);

            modelBuilder.Entity<PartImage>()
             .HasKey(x => x.Id);

            modelBuilder.Entity<PartManufacturer>()
             .HasKey(x => x.ManufacId);

        }
        private void SetOneToMany(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<VehicleType>()
                .HasMany(c => c.Vehicle)
                .WithOne(e => e.VehicleType)
                .IsRequired();

            modelBuilder.Entity<VehicleBrand>()
                .HasMany(c => c.Vehicle)
                .WithOne(e => e.VehicleBrand)
                .IsRequired();

            modelBuilder.Entity<Part>()
                .HasOne(s => s.PartManufacturer)
                .WithMany(e => e.Part)
                .HasForeignKey(s=>s.CurrentManufacturerId);
        }
        private void SetManyToMany(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryPart>().HasKey(cp => new { cp.CategoryId, cp.PartId });

            modelBuilder.Entity<CategoryPart>()
                .HasOne<Category>(cp => cp.Category)
                .WithMany(c => c.CategoryParts)
                .HasForeignKey(cp => cp.CategoryId);

            modelBuilder.Entity<CategoryPart>()
                .HasOne<Part>(cp => cp.Part)
                .WithMany(c => c.CategoryParts)
                .HasForeignKey(cp => cp.PartId);

            modelBuilder.Entity<VehiclePart>().HasKey(vp => new { vp.VehicleId, vp.PartId });

            modelBuilder.Entity<VehiclePart>()
                .HasOne<Vehicle>(mp => mp.Vehicle)
                .WithMany(m => m.VehicleParts)
                .HasForeignKey(mp => mp.VehicleId);

            modelBuilder.Entity<VehiclePart>()
                .HasOne<Part>(mp => mp.Part)
                .WithMany(m => m.VehicleParts)
                .HasForeignKey(mp => mp.PartId);

            modelBuilder.Entity<VehicleTypeCategory>().HasKey(vp => new { vp.VehicleTypeId, vp.CategoryId });

            modelBuilder.Entity<VehicleTypeCategory>()
                .HasOne<VehicleType>(mp => mp.VehicleType)
                .WithMany(m => m.VehicleTypeCategories)
                .HasForeignKey(mp => mp.VehicleTypeId);

            modelBuilder.Entity<VehicleTypeCategory>()
                .HasOne<Category>(mp => mp.Category)
                .WithMany(m => m.VehicleTypeCategories)
                .HasForeignKey(mp => mp.CategoryId);
        
        }
    }
}
