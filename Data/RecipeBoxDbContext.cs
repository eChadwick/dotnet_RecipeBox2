using Microsoft.EntityFrameworkCore;
using RecipeBox2.Models;

namespace RecipeBox2.Data
{
    public class rb2Context : DbContext
    {
        public rb2Context( DbContextOptions<rb2Context> options )
            : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .HasIndex(e => e.Name)
                .IsUnique();

            modelBuilder.Entity<Recipe>()
                .HasIndex(e => e.Name)
                .IsUnique();

            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(e => new { e.RecipeId, e.IngredientId } );
        }
    }
}