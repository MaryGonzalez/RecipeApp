﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeApplication.Models;

namespace RecipeApplication.Migrations
{
    [DbContext(typeof(RecipeContext))]
    [Migration("20201212211909_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("RecipeApplication.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "B",
                            Name = "Breakfast"
                        },
                        new
                        {
                            CategoryId = "D",
                            Name = "Desserts"
                        },
                        new
                        {
                            CategoryId = "V",
                            Name = "Main Dishes-Vegetarian"
                        },
                        new
                        {
                            CategoryId = "M",
                            Name = "Main Dishes-Meat"
                        },
                        new
                        {
                            CategoryId = "BR",
                            Name = "Breads"
                        },
                        new
                        {
                            CategoryId = "S",
                            Name = "Soups"
                        });
                });

            modelBuilder.Entity("RecipeApplication.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Directions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrepTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Servings")
                        .HasColumnType("int");

                    b.Property<string>("TotalTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            Author = "Betty Crocker Kitchens",
                            CategoryId = "D",
                            Directions = "Test Data",
                            Image = "ChocolateChip.jpg",
                            Ingredients = "Test",
                            Name = "Ultimate Chocolate Chip Cookies",
                            PrepTime = "15 minutes",
                            Servings = 48,
                            TotalTime = "1 HR 30 MIN"
                        },
                        new
                        {
                            RecipeId = 2,
                            Author = "The Salty Marshmallow",
                            CategoryId = "B",
                            Directions = "Test Data",
                            Image = "BelgianWaffles.jpg",
                            Ingredients = "Test",
                            Name = "Homemade Belgian Waffles",
                            PrepTime = "15 minutes",
                            Servings = 8,
                            TotalTime = "35 minutes"
                        });
                });

            modelBuilder.Entity("RecipeApplication.Models.Recipe", b =>
                {
                    b.HasOne("RecipeApplication.Models.Category", "Category")
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
