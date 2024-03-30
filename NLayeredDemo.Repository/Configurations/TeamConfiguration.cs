using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredDemo.Core.Models;

namespace NLayeredDemo.Repository.Configurations;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        // fluent api ayarlamasi

        builder.ToTable("TeamTable"); // Table name
        
        builder.HasKey(t => t.Id); // Primary key
        builder.Property(t => t.Id).UseIdentityColumn(); // Auto-increment
        builder.Property(t => t.TeamName).IsRequired().HasMaxLength(50); // Not nullable, max length 50
        
    }
}