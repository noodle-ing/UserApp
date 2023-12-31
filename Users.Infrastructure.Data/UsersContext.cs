using Microsoft.EntityFrameworkCore;
using Users.Domain.Core.Entities;

namespace Users.Infrastructure.Data;

public class UsersContext : DbContext

{
    public DbSet<User> Users { get; set; }

    public UsersContext(DbContextOptions options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }
}