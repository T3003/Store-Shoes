using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

class DataContext: DbContext
{
public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

public DbSet<Color> Color { get; set; }

public DbSet<Size> Size { get; set; }

public DbSet<Product> Product { get; set; }

} 