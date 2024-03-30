using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayeredDemo.Core.Models;

namespace NLayeredDemo.Repository;

public class AppDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


    }
}