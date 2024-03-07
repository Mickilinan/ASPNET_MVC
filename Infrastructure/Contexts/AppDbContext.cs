using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<UserEntity>(options)
{
    public DbSet <AddressEntity> Addresses { get; set; }
}
