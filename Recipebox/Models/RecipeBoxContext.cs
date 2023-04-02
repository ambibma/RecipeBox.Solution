using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : DbContext
  {
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Tag> Tags { get; set; }
    // public DbSet<Ingredient> Ingredients {get;set;}
    public DbSet<RecipeTag> RecipeTags { get; set; }

    public RecipeBoxContext(DbContextOptions options) : base(options) { }
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //   modelBuilder.Entity<Recipe>().HasNoKey();
    // }

    
  }
}