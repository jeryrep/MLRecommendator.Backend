using Microsoft.EntityFrameworkCore;
using MLRecommendator.Database.Models;

namespace MLRecommendator.Database; 

public class MalContext : DbContext {
    public DbSet<Anime> Animes { get; set; }
    public DbSet<UserSerie> UserSeries { get; set; }
    public string DbPath { get; }
    public MalContext() {
        DbPath = "mal.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
}