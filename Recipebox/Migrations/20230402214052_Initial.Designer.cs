﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBox.Models;

#nullable disable

namespace RecipeBox.Migrations
{
    [DbContext(typeof(RecipeBoxContext))]
    [Migration("20230402214052_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RecipeBox.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ingredients")
                        .HasColumnType("longtext");

                    b.Property<string>("Instructions")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeBox.Models.RecipeTag", b =>
                {
                    b.Property<int>("RecipeTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("RecipeTagId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("TagId");

                    b.ToTable("RecipeTags");
                });

            modelBuilder.Entity("RecipeBox.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("RecipeBox.Models.RecipeTag", b =>
                {
                    b.HasOne("RecipeBox.Models.Recipe", "Recipe")
                        .WithMany("JoinEntities")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBox.Models.Tag", "Tag")
                        .WithMany("JoinEntities")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("RecipeBox.Models.Recipe", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("RecipeBox.Models.Tag", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
