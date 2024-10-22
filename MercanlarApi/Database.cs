using Microsoft.EntityFrameworkCore;

namespace MercanlarApi.Model;

public class MercanDB : DbContext
{
    public MercanDB(DbContextOptions<MercanDB> options) : base(options) { }

    public DbSet<AracModel> Araclar { get; set; }
    public DbSet<KargoModel> Kargolar { get; set; }
}