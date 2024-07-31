using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DataReader.DataAccess.BaseModels;


namespace DataReader.DataAccess.Configurations
{
  public class WorkItemConfig : IEntityTypeConfiguration<WorkItemBase>
  {
    public void Configure(EntityTypeBuilder<WorkItemBase> builder)
    {
      BuildRealtions(builder);

    }

    private void BuildRealtions(EntityTypeBuilder<WorkItemBase> builder)
    {
      builder
        .HasOne(w => w.Project)
        .WithMany(p => p.WorkItems)
        .HasForeignKey(f => f.ProjectSK)
        .HasPrincipalKey(p => p.ProjectSK);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.AssignedToUserSK)
        .HasPrincipalKey(p => p.UserSK);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ChangedByUserSK)
        .HasPrincipalKey(p => p.UserSK);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.CreatedByUserSK)
        .HasPrincipalKey(p => p.UserSK);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ActivatedByUserSK)
        .HasPrincipalKey(p => p.UserSK);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ClosedByUserSK)
        .HasPrincipalKey(p => p.UserSK);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ResolvedByUserSK)
        .HasPrincipalKey(p => p.UserSK);
    }
  }
}
