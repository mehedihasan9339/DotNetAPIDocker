using DotNetAPIDocker.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetAPIDocker.Context;

public  class dbContext:DbContext
{
    public dbContext(DbContextOptions<dbContext> options):base(options)
    {
        
    }

    public DbSet<Employee> Employees {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>().ToTable("Employees", "public");
    }
}