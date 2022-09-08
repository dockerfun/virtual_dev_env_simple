using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using my_backend.Models;
using System.Linq;
using System.Threading.Tasks; 

namespace MyBackend.DAL;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)  
    {   
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("user"); 

        modelBuilder.Entity<User>().Property(u => u.ID).HasColumnType("int").ValueGeneratedOnAdd().IsRequired();  
        modelBuilder.Entity<User>().Property(u => u.FirstName).HasColumnType("nvarchar(30)");  
        modelBuilder.Entity<User>().Property(u => u.LastName).HasColumnType("nvarchar(30)").IsRequired();  
        modelBuilder.Entity<User>().Property(u => u.DateOfBirth).HasColumnType("datetime");
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; }
}