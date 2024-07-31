using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DataReader.DataAccess.BaseModels;


namespace DataReader.DataAccess.Configurations
{
  public class ProjectConfig : IEntityTypeConfiguration<ProjectBase>
  {
    public void Configure(EntityTypeBuilder<ProjectBase> builder)
    {
      BuildRealtions(builder);

    }

    private void BuildRealtions(EntityTypeBuilder<ProjectBase> builder)
    {
      builder
        .HasMany(p => p.WorkItems)
        .WithOne(w => w.Project)
        .HasPrincipalKey(p => p.ProjectSK)
        .HasForeignKey(f => f.ProjectSK);
    }
  }
}
