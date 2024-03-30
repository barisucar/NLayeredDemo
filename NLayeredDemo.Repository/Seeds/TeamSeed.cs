using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredDemo.Core.Models;

namespace NLayeredDemo.Repository.Seeds;

public class TeamSeed : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasData(
            new Team
            {
                Id = 1,
                TeamName = "Development Team"
            },
            new Team
            {
                Id = 2,
                TeamName = "Sales Team"
            },
            new Team
            {
                Id = 3,
                TeamName = "Management Team"
            }
        );
    }
}