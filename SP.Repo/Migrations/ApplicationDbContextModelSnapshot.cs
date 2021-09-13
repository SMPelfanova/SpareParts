﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SP.Repo;

namespace SP.Repo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SP.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageFileName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Caterogories");
                });

            modelBuilder.Entity("SP.Data.Models.CategoryPart", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "PartId");

                    b.HasIndex("PartId");

                    b.ToTable("CategoriesParts");
                });

            modelBuilder.Entity("SP.Data.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("SP.Data.Models.ManufacturerPart", b =>
                {
                    b.Property<int>("ManufaturerId")
                        .HasColumnType("int");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.HasKey("ManufaturerId", "PartId");

                    b.HasIndex("PartId");

                    b.ToTable("ManufacturerParts");
                });

            modelBuilder.Entity("SP.Data.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<int>("CurrentManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.Property<int?>("RelatedPartId")
                        .HasColumnType("int");

                    b.Property<string>("SerialNr")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("PartId");

                    b.HasIndex("CurrentManufacturerId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("SP.Data.Models.PartImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartId");

                    b.ToTable("PartImages");
                });

            modelBuilder.Entity("SP.Data.Models.PartManufacturer", b =>
                {
                    b.Property<int>("ManufacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacId");

                    b.ToTable("PartManufacturers");
                });

            modelBuilder.Entity("SP.Data.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("ModelYearFrom")
                        .HasColumnType("Date");

                    b.Property<DateTime>("ModelYearTo")
                        .HasColumnType("Date");

                    b.Property<int>("PowerHP")
                        .HasColumnType("int");

                    b.Property<int>("VehicleBrandId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleBrandId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("SP.Data.Models.VehicleBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LogoFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleBrands");
                });

            modelBuilder.Entity("SP.Data.Models.VehiclePart", b =>
                {
                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<string>("OEM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId", "PartId");

                    b.HasIndex("PartId");

                    b.ToTable("VehicleParts");
                });

            modelBuilder.Entity("SP.Data.Models.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleTypes");
                });

            modelBuilder.Entity("SP.Data.Models.VehicleTypeCategory", b =>
                {
                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("VehicleTypeId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("VehicleTypeCategories");
                });

            modelBuilder.Entity("SP.Data.Models.Category", b =>
                {
                    b.HasOne("SP.Data.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("SP.Data.Models.CategoryPart", b =>
                {
                    b.HasOne("SP.Data.Models.Category", "Category")
                        .WithMany("CategoryParts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SP.Data.Models.Part", "Part")
                        .WithMany("CategoryParts")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Part");
                });

            modelBuilder.Entity("SP.Data.Models.ManufacturerPart", b =>
                {
                    b.HasOne("SP.Data.Models.Manufacturer", "Manufaturer")
                        .WithMany("ManufacturerParts")
                        .HasForeignKey("ManufaturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SP.Data.Models.Part", "Part")
                        .WithMany("ManufacturerParts")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufaturer");

                    b.Navigation("Part");
                });

            modelBuilder.Entity("SP.Data.Models.Part", b =>
                {
                    b.HasOne("SP.Data.Models.PartManufacturer", "PartManufacturer")
                        .WithMany("Part")
                        .HasForeignKey("CurrentManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PartManufacturer");
                });

            modelBuilder.Entity("SP.Data.Models.PartImage", b =>
                {
                    b.HasOne("SP.Data.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId");

                    b.Navigation("Part");
                });

            modelBuilder.Entity("SP.Data.Models.Vehicle", b =>
                {
                    b.HasOne("SP.Data.Models.VehicleBrand", "VehicleBrand")
                        .WithMany("Vehicle")
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SP.Data.Models.VehicleType", "VehicleType")
                        .WithMany("Vehicle")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleBrand");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("SP.Data.Models.VehiclePart", b =>
                {
                    b.HasOne("SP.Data.Models.Part", "Part")
                        .WithMany("VehicleParts")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SP.Data.Models.Vehicle", "Vehicle")
                        .WithMany("VehicleParts")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Part");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("SP.Data.Models.VehicleTypeCategory", b =>
                {
                    b.HasOne("SP.Data.Models.Category", "Category")
                        .WithMany("VehicleTypeCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SP.Data.Models.VehicleType", "VehicleType")
                        .WithMany("VehicleTypeCategories")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("SP.Data.Models.Category", b =>
                {
                    b.Navigation("CategoryParts");

                    b.Navigation("Children");

                    b.Navigation("VehicleTypeCategories");
                });

            modelBuilder.Entity("SP.Data.Models.Manufacturer", b =>
                {
                    b.Navigation("ManufacturerParts");
                });

            modelBuilder.Entity("SP.Data.Models.Part", b =>
                {
                    b.Navigation("CategoryParts");

                    b.Navigation("ManufacturerParts");

                    b.Navigation("VehicleParts");
                });

            modelBuilder.Entity("SP.Data.Models.PartManufacturer", b =>
                {
                    b.Navigation("Part");
                });

            modelBuilder.Entity("SP.Data.Models.Vehicle", b =>
                {
                    b.Navigation("VehicleParts");
                });

            modelBuilder.Entity("SP.Data.Models.VehicleBrand", b =>
                {
                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("SP.Data.Models.VehicleType", b =>
                {
                    b.Navigation("Vehicle");

                    b.Navigation("VehicleTypeCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
