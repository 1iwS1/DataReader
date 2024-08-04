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
      BuildPropeties(builder);
    }

    private void BuildPropeties(EntityTypeBuilder<ProjectBase> builder)
    {
      builder.ComplexProperty(p => p.ProjectSK, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired();
      })
        .HasKey(p => p.ProjectSK);

      builder.ComplexProperty(p => p.ProjectID, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired(false);
      });

      builder.ComplexProperty(p => p.ProjectName, b =>
      {
        b.Property(g => g!.Name).IsRequired(false);
      });

      builder.ComplexProperty(p => p.AnalyticsUpdatedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(p => p.ProjectVisibility)
        .IsRequired(false);
    }

    private void BuildRealtions(EntityTypeBuilder<ProjectBase> builder)
    {
      builder
        .HasMany(p => p.WorkItems)
        .WithOne(w => w.Project)
        .HasPrincipalKey(p => p.ProjectSK)
        .HasForeignKey(f => f.ProjectSK)
        .IsRequired(false);
    }
  }
}
