using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredDemo.Core.Models;

namespace NLayeredDemo.Repository.Seeds;

public class UserProfileSeed : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.HasData(
            new UserProfile
            {
                Id = 1,
                FirstName = "Baris",
                LastName = "Ucar",
                UserId = 1
            }

        );
    }
}