using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using telephone_directory.Models;

public class TelephoneDirectoryDbContext : DbContext
{
    public TelephoneDirectoryDbContext(DbContextOptions<TelephoneDirectoryDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Contact>()
            .HasIndex(c => c.PhoneNumber)
            .IsUnique();
    }

    public DbSet<telephone_directory.Models.Contact> Contact { get; set; }
}
