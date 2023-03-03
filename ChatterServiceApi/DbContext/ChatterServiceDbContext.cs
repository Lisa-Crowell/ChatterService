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

    public DbSet<PhoneNumber>? PhoneNumbers { get; set; }

    public DbSet<EmailAddress>? EmailAddresses { get; set; }
    
    public DbSet<PersonalName>? Names { get; set; }
    
    public DbSet<AccountName> EmailAccounts { get; set; }
    
    public DbSet<DomainName> EmailDomains { get; set; }
    
    public DbSet<EmailExtension> EmailExtensions { get; set; }

    public DbSet<ChatterDate> Dates { get; set; }
    
    public DbSet<Username> Usernames { get; set; }
    
    public DbSet<Password> Passwords { get; set; }
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChatterOrganization>().HasBaseType<AbstractChatter>();
        modelBuilder.Entity<ChatterOrganization>().HasMany(e => e.Names);
        modelBuilder.Entity<ChatterOrganization>().HasMany(e => e.Identities);
        
        modelBuilder.Entity<ChatterPerson>().HasBaseType<AbstractChatter>();
        modelBuilder.Entity<ChatterPerson>().HasOne(e => e.Identity);
        
        modelBuilder.Entity<ChatterIdentity>().HasOne(e => e.Credentials);
        modelBuilder.Entity<ChatterIdentity>().HasMany(e => e.ContactInformation);
        modelBuilder.Entity<ChatterIdentity>().HasMany(e => e.GivenNames);
        modelBuilder.Entity<ChatterIdentity>().HasMany(e => e.Surnames);
        modelBuilder.Entity<ChatterIdentity>().HasOne(e => e.DateOfBirth);

        modelBuilder.Entity<EmailAddress>().HasOne(e => e.AccountName);
        modelBuilder.Entity<EmailAddress>().HasOne(e => e.DomainName);
        modelBuilder.Entity<EmailAddress>().HasOne(e => e.DomainExtension);
        
        modelBuilder.Entity<ContactInformation>().HasOne(e => e.EmailAddress);
        modelBuilder.Entity<ContactInformation>().HasOne(e => e.PhoneNumber);
        
        modelBuilder.Entity<ChatterCredentials>().HasOne(e => e.UserName);
        modelBuilder.Entity<ChatterCredentials>().HasOne(e => e.Password);

    }
}