﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop_PV016.Data;

namespace Shop_PV016.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220815173424_Create seed")]
    partial class Createseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop_PV016.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShowOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Proccessor",
                            ShowOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Motherboard",
                            ShowOrder = 1
                        });
                });

            modelBuilder.Entity("Shop_PV016.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Proccessor",
                            Name = "Ryzen 5 2600",
                            Price = 300.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Proccessor",
                            Name = "Ryzen 5 1600",
                            Price = 200.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Proccessor",
                            Name = "Intel core i5 9400f",
                            Price = 350.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Motherboard",
                            Name = "Asus Prime H510M-K",
                            Price = 190.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Motherboard",
                            Name = "MSI MPG Z490 Gaming Plus",
                            Price = 210.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Motherboard",
                            Name = "Gigabyte Z690 UD",
                            Price = 400.0
                        });
                });

            modelBuilder.Entity("Shop_PV016.Models.Product", b =>
                {
                    b.HasOne("Shop_PV016.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
