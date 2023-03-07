using ChatterServiceApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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
    
    public DbSet<AccountName>? EmailAccounts { get; set; }
    
    public DbSet<DomainName>? EmailDomains { get; set; }
    
    public DbSet<EmailExtension>? EmailExtensions { get; set; }

    public DbSet<ChatterDate>? Dates { get; set; }
    
    public DbSet<Username>? Usernames { get; set; }
    
    public DbSet<Password>? Passwords { get; set; }
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChatterIdentity>()
            .HasOne<ChatterCredentials>(identity => identity.Credentials)
            .WithMany(credentials => credentials.AssociatedIdentities)
            .HasForeignKey("CredentialsId");

        modelBuilder.Entity<ChatterIdentity>()
            .HasMany<PersonalName>(identity => identity.GivenNames)
            .WithMany(name => name.AssociatedIdentities)
            .UsingEntity<ManyToManyJoinEntityTypeConvention>("NamesToIdentities_GivenNames");

        modelBuilder.Entity<ChatterIdentity>()
            .HasMany<PersonalName>(identity => identity.Surnames)
            .WithMany(name => name.AssociatedIdentities)
            .UsingEntity<ManyToManyJoinEntityTypeConvention>("NamesToIdentities_Surnames");
    }
}