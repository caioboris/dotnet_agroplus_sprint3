using FIAP.Agroplus.Sprint3.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FIAP.Agroplus.Sprint3.Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<RegiaoEntity> Regioes { get; set; }
    public DbSet<PlantacaoEntity> Plantacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RegiaoEntity>()
            .Property(x => x.RegiaoBR)
            .HasConversion<string>();
    }
}
