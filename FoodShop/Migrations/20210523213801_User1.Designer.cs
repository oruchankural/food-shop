﻿// <auto-generated />
using FoodShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodShop.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210523213801_User1")]
    partial class User1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodShop.Data.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminRole")
                        .HasMaxLength(1);

                    b.Property<string>("Password")
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .HasMaxLength(20);

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("FoodShop.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDesc");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<bool>("Status");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FoodShop.Data.Models.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Desc");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.HasKey("FoodID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("FoodShop.Data.Models.Food", b =>
                {
                    b.HasOne("FoodShop.Data.Models.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}