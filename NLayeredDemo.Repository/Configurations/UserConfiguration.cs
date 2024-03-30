using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredDemo.Core.Models;

namespace NLayeredDemo.Repository.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // fluent api ayarlamasi

        builder.ToTable("UserTable"); // Table name
        
        builder.HasKey(u => u.Id); // Primary key
        builder.Property(u => u.Id).UseIdentityColumn(); // Auto-increment
        builder.Property(u => u.UserName).IsRequired().HasMaxLength(50); // Not nullable, max length 50
        builder.Property(u => u.Password).IsRequired().HasMaxLength(50); // Not nullable, max length 50
        builder.Property(u => u.Email).IsRequired().HasMaxLength(250); // Not nullable, max length 50


    }
}