using ChatterServiceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatterServiceApi.DbContext;

public class ChatterServiceDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ChatterServiceDbContext(DbContextOptions<ChatterServiceDbContext> options) : base(options)
    {
    }
    
    public DbSet<ChatterIdentity>? Identities { get; set; }
    
    public DbSet<AbstractChatter>? Chatters { get; set; }
    
    public DbSet<ChatterOrganization>? Organizations { get; set; }
    
    public DbSet<ChatterPerson>? People { get; set; }
    
    public DbSet<ContactInformation>? ContactInformation { get; set; }
    
    public DbSet<ChatterCredentials>? Credentials { get; set; }
}