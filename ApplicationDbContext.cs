using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<EntityA?> EntityAs { get; set; }
    public DbSet<EntityB?> EntityBs { get; set; }
    public DbSet<EntitiesView> EntitiesView { get; set; } // For the combined view
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntitiesView>().HasNoKey().ToView("v_EntitiesView"); // Name of the SQL view
    }
}