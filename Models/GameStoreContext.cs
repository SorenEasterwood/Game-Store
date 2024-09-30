using Microsoft.EntityFrameworkCore;
namespace Game_Store.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 1,
                Title = "Final Fantasy XVI",
                Year = 2023,
                Rating = 9,
                Cost = 49.99
            },
            new Game
            {
                GameId = 2,
                Title = "Red Dead Redemption 2",
                Year = 2018,
                Rating = 10,
                Cost = 39.99
            },
            new Game
            {
                GameId = 3,
                Title = "Baldurs Gate 3",
                Year = 2023,
                Rating = 10,
                Cost = 59.99
            },
            new Game
            {
                GameId = 4,
                Title = "God of War (2018)",
                Year = 2018,
                Rating = 9,
                Cost = 19.99
            }
            );
        }
    }
}
