﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Oyun.Entities;

namespace Oyun.DataAccess;

public class GameDbContext : DbContext
{
    public GameDbContext(DbContextOptions opt) : base(opt) {}

    public DbSet<Language> Languages { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>(model =>
        {
            model.HasKey(x => x.Code);

            model.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(2);

            model.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(64);

            model.Property(x => x.Icon)
                .IsRequired()
                .HasMaxLength(128);
        });

        base.OnModelCreating(modelBuilder);
    }
}
