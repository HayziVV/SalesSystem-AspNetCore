using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVCProject.Models;

namespace SalesWebMVCProject.Data;

public class SalesWebMVCProjectContext : DbContext
{
    public SalesWebMVCProjectContext (DbContextOptions<SalesWebMVCProjectContext> options)
        : base(options)
    {
    }

    public DbSet<Department> Department { get; set; }
    public DbSet<Seller> Seller { get; set; } 
    public DbSet<SalesRecord> SalesRecord { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

       
        builder.Entity<SalesRecord>()
            .HasOne(sr => sr.Seller)
            .WithMany(s => s.Sales)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Seller>()
            .HasOne(s => s.Department)
            .WithMany()
            .HasForeignKey(s => s.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
