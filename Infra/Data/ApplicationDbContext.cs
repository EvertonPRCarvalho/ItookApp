﻿using Flunt.Notifications;
using ItookApp.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace ItookApp.Infra.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<Notification>();
        modelBuilder.Entity<Product>()
            .Property(p => p.Description).HasMaxLength(255);
        modelBuilder.Entity<Product>()
         .Property(p => p.Name).IsRequired();

        modelBuilder.Entity<Category>()
         .Property(c => c.Name).IsRequired();
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<string>()
            .HaveMaxLength(100); 
    }
}
