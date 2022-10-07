using Domain;
using Microsoft.EntityFrameworkCore;

namespace Presistence;
public class DataDbContext : DbContext
{
    

    public DataDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Value>Values{ get; set; }

}
