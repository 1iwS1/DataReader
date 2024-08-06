using DataReader.DataAccess.Models;
using Microsoft.EntityFrameworkCore;


namespace DataReader.DataAccess
{
  public partial class DataAzureContext : DbContext
  {
    public DataAzureContext()
    {
    }

    public DataAzureContext(DbContextOptions<DataAzureContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Log> Logs { get; set; }
    public virtual DbSet<Project> Projects { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<WorkItem> WorkItems { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Log>(entity =>
      {
        entity.HasKey(e => e.Id).HasName("PK_Logs_Id");

        entity.Property(e => e.Id).ValueGeneratedNever();
        entity.Property(e => e.LastSyncTime).HasMaxLength(100);
        entity.Property(e => e.SyncResult).HasMaxLength(20);
      });

      modelBuilder.Entity<Project>(entity =>
      {
        entity.HasKey(e => e.ProjectSk).HasName("PK_Projects_Id");

        entity.Property(e => e.ProjectSk)
            .ValueGeneratedNever()
            .HasColumnName("ProjectSK");
        entity.Property(e => e.AnalyticsUpdatedDate).HasMaxLength(100);
        entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
        entity.Property(e => e.ProjectName).HasMaxLength(1000);
        entity.Property(e => e.ProjectVisibility).HasMaxLength(20);
      });

      modelBuilder.Entity<User>(entity =>
      {
        entity.HasKey(e => e.UserSk).HasName("PK_Users_Id");

        entity.Property(e => e.UserSk)
            .ValueGeneratedNever()
            .HasColumnName("UserSK");
        entity.Property(e => e.AnalyticsUpdatedDate).HasMaxLength(100);
        entity.Property(e => e.GitHubUserId).HasMaxLength(100);
        entity.Property(e => e.UserId).HasMaxLength(40);
        entity.Property(e => e.UserName).HasMaxLength(100);
        entity.Property(e => e.UserType).HasMaxLength(100);
      });

      modelBuilder.Entity<WorkItem>(entity =>
      {
        entity.HasKey(e => e.WorkItemId).HasName("PK_WorkItems_Id");

        entity.Property(e => e.ActivatedByUserSk).HasColumnName("ActivatedByUserSK");
        entity.Property(e => e.ActivatedDate).HasMaxLength(100);
        entity.Property(e => e.ActivatedDateSk)
            .HasMaxLength(30)
            .HasColumnName("ActivatedDateSK");
        entity.Property(e => e.AnalyticsUpdatedDate).HasMaxLength(100);
        entity.Property(e => e.AreaSk).HasColumnName("AreaSK");
        entity.Property(e => e.AssignedToUserSk).HasColumnName("AssignedToUserSK");
        entity.Property(e => e.ChangedByUserSk).HasColumnName("ChangedByUserSK");
        entity.Property(e => e.ChangedDate).HasMaxLength(100);
        entity.Property(e => e.ChangedDateSk)
            .HasMaxLength(30)
            .HasColumnName("ChangedDateSK");
        entity.Property(e => e.ClosedByUserSk).HasColumnName("ClosedByUserSK");
        entity.Property(e => e.ClosedDate).HasMaxLength(100);
        entity.Property(e => e.ClosedDateSk)
            .HasMaxLength(30)
            .HasColumnName("ClosedDateSK");
        entity.Property(e => e.CompletedDate).HasMaxLength(100);
        entity.Property(e => e.CompletedDateSk)
            .HasMaxLength(30)
            .HasColumnName("CompletedDateSK");
        entity.Property(e => e.CompletedWork).HasColumnType("decimal(18, 0)");
        entity.Property(e => e.CreatedByUserSk).HasColumnName("CreatedByUserSK");
        entity.Property(e => e.CreatedDate).HasMaxLength(100);
        entity.Property(e => e.CreatedDateSk)
            .HasMaxLength(30)
            .HasColumnName("CreatedDateSK");
        entity.Property(e => e.Custom719f69f1002df7d0002d4baa002db6ce002de77ad5dfcdf3)
            .HasMaxLength(300)
            .HasColumnName("Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3");
        entity.Property(e => e.CustomCompany)
            .HasMaxLength(100)
            .HasColumnName("Custom_Company");
        entity.Property(e => e.CustomEksternareferenca)
            .HasMaxLength(300)
            .HasColumnName("Custom_Eksternareferenca");
        entity.Property(e => e.CustomItserviceorApplication)
            .HasMaxLength(300)
            .HasColumnName("Custom_ITServiceorApplication");
        entity.Property(e => e.CustomStatusprojekta)
            .HasMaxLength(300)
            .HasColumnName("Custom_Statusprojekta");
        entity.Property(e => e.CustomTicketNo)
            .HasMaxLength(100)
            .HasColumnName("Custom_TicketNo");
        entity.Property(e => e.Effort).HasMaxLength(30);
        entity.Property(e => e.FinishDate).HasMaxLength(100);
        entity.Property(e => e.InProgressDate).HasMaxLength(100);
        entity.Property(e => e.InProgressDateSk)
            .HasMaxLength(30)
            .HasColumnName("InProgressDateSK");
        entity.Property(e => e.IterationSk).HasColumnName("IterationSK");
        entity.Property(e => e.OriginalEstimate).HasMaxLength(50);
        entity.Property(e => e.ProjectSk).HasColumnName("ProjectSK");
        entity.Property(e => e.RemainingWork).HasMaxLength(50);
        entity.Property(e => e.ResolvedByUserSk).HasColumnName("ResolvedByUserSK");
        entity.Property(e => e.ResolvedDate).HasMaxLength(100);
        entity.Property(e => e.ResolvedDateSk)
            .HasMaxLength(30)
            .HasColumnName("ResolvedDateSK");
        entity.Property(e => e.StartDate).HasMaxLength(50);
        entity.Property(e => e.State).HasMaxLength(30);
        entity.Property(e => e.StateChangeDate).HasMaxLength(100);
        entity.Property(e => e.StateChangeDateSk)
            .HasMaxLength(30)
            .HasColumnName("StateChangeDateSK");
        entity.Property(e => e.StoryPoints).HasMaxLength(50);
        entity.Property(e => e.TagNames).HasMaxLength(50);
        entity.Property(e => e.TargetDate).HasMaxLength(50);
        entity.Property(e => e.WorkItemRevisionSk).HasColumnName("WorkItemRevisionSK");
        entity.Property(e => e.WorkItemType).HasMaxLength(30);

        entity.HasOne(d => d.ActivatedByUserSkNavigation).WithMany(p => p.WorkItemActivatedByUserSkNavigations)
            .HasForeignKey(d => d.ActivatedByUserSk)
            .HasConstraintName("FK_WorkItems_ActivatedByUserSK");

        entity.HasOne(d => d.AssignedToUserSkNavigation).WithMany(p => p.WorkItemAssignedToUserSkNavigations)
            .HasForeignKey(d => d.AssignedToUserSk)
            .HasConstraintName("FK_WorkItems_AssignedToUserSK");

        entity.HasOne(d => d.ChangedByUserSkNavigation).WithMany(p => p.WorkItemChangedByUserSkNavigations)
            .HasForeignKey(d => d.ChangedByUserSk)
            .HasConstraintName("FK_WorkItems_ChangedByUserSK");

        entity.HasOne(d => d.ClosedByUserSkNavigation).WithMany(p => p.WorkItemClosedByUserSkNavigations)
            .HasForeignKey(d => d.ClosedByUserSk)
            .HasConstraintName("FK_WorkItems_ClosedByUserSK");

        entity.HasOne(d => d.CreatedByUserSkNavigation).WithMany(p => p.WorkItemCreatedByUserSkNavigations)
            .HasForeignKey(d => d.CreatedByUserSk)
            .HasConstraintName("FK_WorkItems_CreatedByUserSK");

        entity.HasOne(d => d.ProjectSkNavigation).WithMany(p => p.WorkItems)
            .HasForeignKey(d => d.ProjectSk)
            .HasConstraintName("FK_WorkItems_ProjectSK");

        entity.HasOne(d => d.ResolvedByUserSkNavigation).WithMany(p => p.WorkItemResolvedByUserSkNavigations)
            .HasForeignKey(d => d.ResolvedByUserSk)
            .HasConstraintName("FK_WorkItems_ResolvedByUserSK");
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}

