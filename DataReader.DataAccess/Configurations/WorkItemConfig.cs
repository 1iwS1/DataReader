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
      BuildProperties(builder);
    }

    private void BuildProperties(EntityTypeBuilder<WorkItemBase> builder)
    {
      builder
        .HasKey(w => w.WorkItemId);

      builder.ComplexProperty(w => w.InProgressDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder.ComplexProperty(w => w.CompletedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(i => i.InProgressDateSK)
        .IsRequired(false);

      builder
        .Property(c => c.CompletedDateSK)
        .IsRequired(false);

      builder.ComplexProperty(w => w.AnalyticsUpdatedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(w => w.WorkItemRevisionSK)
        .IsRequired(false);

      builder.ComplexProperty(w => w.AreaSK, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired(false);
      });

      builder.ComplexProperty(w => w.IterationSK, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired(false);
      });

      builder
        .Property(w => w.ActivatedDateSK)
        .IsRequired(false);

      builder
        .Property(w => w.ChangedDateSK)
        .IsRequired(false);

      builder
        .Property(w => w.ClosedDateSK)
        .IsRequired(false);

      builder
        .Property(w => w.CreatedDateSK)
        .IsRequired(false);

      builder
        .Property(w => w.ResolvedDateSK)
        .IsRequired(false);

      builder
        .Property(w => w.StateChangeDateSK)
        .IsRequired(false);

      builder
        .Property(w => w.WorkItemType)
        .IsRequired(false);

      builder.ComplexProperty(w => w.ChangedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder.ComplexProperty(w => w.CreatedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(w => w.State)
        .IsRequired(false);

      builder.ComplexProperty(w => w.ActivatedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder.ComplexProperty(w => w.ClosedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(w => w.Priority)
        .IsRequired(false);

      builder.ComplexProperty(w => w.ResolvedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(w => w.CompletedWork)
        .IsRequired(false);

      builder
        .Property(w => w.Effort)
        .IsRequired(false);

      builder.ComplexProperty(w => w.FinishDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(w => w.OriginalEstimate)
        .IsRequired(false);

      builder
        .Property(w => w.RemainingWork)
        .IsRequired(false);

      builder
        .Property(w => w.StartDate)
        .IsRequired(false);

      builder
        .Property(w => w.StoryPoints)
        .IsRequired(false);

      builder
        .Property(w => w.TargetDate)
        .IsRequired(false);

      builder
        .Property(w => w.ParentWorkItemId)
        .IsRequired(false);

      builder
        .Property(w => w.TagNames)
        .IsRequired(false);

      builder.ComplexProperty(w => w.StateChangeDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(w => w.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3)
        .IsRequired(false);

      builder
        .Property(w => w.Custom_Company)
        .IsRequired(false);

      builder
        .Property(w => w.Custom_Eksternareferenca)
        .IsRequired(false);

      builder
        .Property(w => w.Custom_ITServiceorApplication)
        .IsRequired(false);

      builder
        .Property(w => w.Custom_Statusprojekta)
        .IsRequired(false);

      builder
        .Property(w => w.Custom_TicketNo)
        .IsRequired(false);
    }

    private void BuildRealtions(EntityTypeBuilder<WorkItemBase> builder)
    {
      builder
        .HasOne(w => w.Project)
        .WithMany(p => p.WorkItems)
        .HasForeignKey(f => f.ProjectSK)
        .HasPrincipalKey(p => p.ProjectSK)
        .IsRequired(false);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.AssignedToUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ChangedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.CreatedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ActivatedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ClosedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasOne(w => w.User)
        .WithMany(u => u.WorkItems)
        .HasForeignKey(f => f.ResolvedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);
    }
  }
}
