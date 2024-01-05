using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PokeMaui.Business.Connection;
using PokeMaui.Entity.Entities;

namespace PokeMaui.Business.Context
{
    public class PokemonDbContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Sprite> Sprites { get; set; }
        public DbSet<Entity.Entities.Type> Types { get; set; }
        public DbSet<PokemonAbility> PokemonAbilities { get; set; }
        public DbSet<PokemonMoves> PokemonMoves { get; set; }
        public DbSet<PokemonTypes> PokemonTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder
                    .UseSqlServer(Hidden.GetConnectionString())
                    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
        }

        // Configure Fluent API //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
