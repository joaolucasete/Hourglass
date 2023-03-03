using Microsoft.EntityFrameworkCore;

namespace Hourglass.Site.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        #region Custom indexes
        #endregion

        #region RelationShips
        #endregion
    }
    
    // Include the DbSet's below

}