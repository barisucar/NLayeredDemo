using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredDemo.Core.Models;

namespace NLayeredDemo.Repository.Configurations;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>

{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        // fluent api ayarlamasi

        builder.ToTable("UserProfileTable"); // Table name
        
        builder.HasKey(u => u.Id); // Primary key
        builder.Property(u => u.Id).UseIdentityColumn(); // Auto-increment
        
        builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50); // Not nullable, max length 50
        builder.Property(u => u.LastName).IsRequired().HasMaxLength(50); // Not nullable, max length 50

    }
}