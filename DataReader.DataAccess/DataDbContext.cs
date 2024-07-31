using DataReader.DataAccess.BaseModels;
using Microsoft.EntityFrameworkCore;


namespace DataReader.DataAccess
{
  public class DataDbContext : DbContext
  {
    public DataDbContext(DbContextOptions<DataDbContext> options)
      : base(options)
    {

    }

    public DbSet<UserBase> Users { get; set; }
    public DbSet<ProjectBase> Projects { get; set; }
    public DbSet<WorkItemBase> WorkItems { get; set; }
  }
}
