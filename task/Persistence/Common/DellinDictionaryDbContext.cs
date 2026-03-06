using System.Reflection;
using Microsoft.EntityFrameworkCore;
using task.Entities;

namespace task.Persistence.Common;

public class DellinDictionaryDbContext : DbContext
{
    public DbSet<Office> Offices { get; set; }
    
    public DellinDictionaryDbContext(DbContextOptions<DellinDictionaryDbContext> options)
        : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        builder.HasPostgresEnum<OfficeType>();
    }
}