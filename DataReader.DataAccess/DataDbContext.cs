using Microsoft.EntityFrameworkCore;

using DataReader.DataAccess.BaseModels;
using DataReader.DataAccess.Configurations;


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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new UserConfig());
      modelBuilder.ApplyConfiguration(new ProjectConfig());
      modelBuilder.ApplyConfiguration(new WorkItemConfig());

      base.OnModelCreating(modelBuilder);
    }
  }
}
