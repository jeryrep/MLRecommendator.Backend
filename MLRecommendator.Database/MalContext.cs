using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MLRecommendator.Database.Models;

namespace MLRecommendator.Database; 

public class MalContext : DbContext {
    public DbSet<Anime> Animes { get; set; }
    public DbSet<UserSerie> UserSeries { get; set; }
    public DbSet<UserScoring> UserScorings { get; set; }
    private readonly IConfiguration _configuration;
    public MalContext(IConfiguration configuration) {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Postgresql"), options => options.SetPostgresVersion(9, 6));
}