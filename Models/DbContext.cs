using Microsoft.EntityFrameworkCore;

namespace Final.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<MonsterHabitat>().HasKey(s => new {s.HabitatID, s.MonsterID});

    }

    
    public DbSet<Monster>? Monsters {get; set;}
    public DbSet<Habitat>? Habitats {get; set;}


    public DbSet<Weakness>? Weaknesses {get; set;}
    public DbSet<Countermeasure>? Countermeasures {get; set;}

    public DbSet<MonsterHabitat>? MonsterHabitats {get; set;}
}