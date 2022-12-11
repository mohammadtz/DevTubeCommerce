using DevTubeCommerce.Domain.Core.Catalogs.Categories;
using DevTubeCommerce.Domain.Core.Catalogs.Features;
using DevTubeCommerce.Domain.Core.Catalogs.Products;
using Microsoft.EntityFrameworkCore;

namespace DevTubeCommerce.Infrastructure.Database.Context;

public class CommerceContext : DbContext
{
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Feature> Features { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;

    public CommerceContext(DbContextOptions<CommerceContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommerceContext).Assembly);
    }
}
