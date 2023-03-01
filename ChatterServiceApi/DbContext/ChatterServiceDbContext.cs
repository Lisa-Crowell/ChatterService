using ChatterServiceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatterServiceApi.DbContext;

public class ChatterServiceDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ChatterServiceDbContext(DbContextOptions<ChatterServiceDbContext> options) : base(options)
    {
    }
    
    public DbSet<ChatterIdentity> Identities { get; set; }
}