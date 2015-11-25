namespace ControleGames.Dal
{
    using Models;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .ToTable("Games")
                .HasKey(x => x.GameId);
        }

        public virtual DbSet<Game> Games { get; set; }
    }
}