﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApp.Data;

#nullable disable

namespace MyWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyWebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 1,
                            Name = "ScienceFiction"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 10,
                            Name = "Gaming"
                        });
                });

            modelBuilder.Entity("MyWebApp.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productId"));

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            productId = 1,
                            ProductDescription = "Fountain pen",
                            ProductName = "Pen"
                        },
                        new
                        {
                            productId = 2,
                            ProductDescription = "Comic Books",
                            ProductName = "Books"
                        },
                        new
                        {
                            productId = 3,
                            ProductDescription = "Microsoft Mouse",
                            ProductName = "Mouse"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
