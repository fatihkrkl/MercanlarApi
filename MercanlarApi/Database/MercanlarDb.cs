using MercanlarApi.Database.Entities;

namespace MercanlarApi.Database;

using Microsoft.EntityFrameworkCore;

public class MercanDb : DbContext
{
    public MercanDb(DbContextOptions<MercanDb> options)
        : base(options)
    {
    }

    public DbSet<Arac> AracList { get; set; } // Change this to match your actual entity name

    // Optionally, override OnModelCreating if you need to customize your model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // You can define model relationships and constraints here
    }
}