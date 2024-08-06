using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DataReader.DataAccess.BaseModels;


namespace DataReader.DataAccess.Configurations
{
  public class UserConfig : IEntityTypeConfiguration<UserBase>
  {
    public void Configure(EntityTypeBuilder<UserBase> builder)
    {
      BuildProperties(builder);
      BuildRelations(builder);
    }

    private void BuildProperties(EntityTypeBuilder<UserBase> builder)
    {
      builder.ComplexProperty(u => u.UserSK, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired().HasColumnName("UserSK");
      })
        .HasKey("UserSK");
        

      builder.ComplexProperty(u => u.UserId, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired(false).HasColumnName("UserID");
      });

      builder.ComplexProperty(u => u.UserName, b =>
      {
        b.Property(n => n!.Name).IsRequired(false).HasColumnName("UserName");
      });

      builder.ComplexProperty(u => u.UserEmail, b =>
      {
        b.Property(e => e!.Email).IsRequired(false).HasColumnName("UserEmail");
      });

      builder.ComplexProperty(u => u.AnalyticsUpdatedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false).HasColumnName("AnalyticsUpdatedDate");
      });

      builder
        .Property(g => g.GitHubUserId)
        .IsRequired(false)
        .HasColumnName("GitHubUserId");

      builder
        .Property(u => u.UserType)
        .IsRequired(false)
        .HasColumnName("UserType");
    }

    private void BuildRelations(EntityTypeBuilder<UserBase> builder)
    {
      builder
        .HasMany(u => u.AssignedWorkItems)
        .WithOne(w => w.AssignedToUser)
        .HasForeignKey(f => f.AssignedToUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.ChangedWorkItems)
        .WithOne(w => w.ChangedByUser)
        .HasForeignKey(f => f.ChangedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.CreatedWorkItems)
        .WithOne(w => w.CreatedByUser)
        .HasForeignKey(f => f.CreatedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.ActivatedWorkItems)
        .WithOne(w => w.ActivatedByUser)
        .HasForeignKey(f => f.ActivatedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.ClosedWorkItems)
        .WithOne(w => w.ClosedByUser)
        .HasForeignKey(f => f.ClosedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.ResolvedWorkItems)
        .WithOne(w => w.ResolvedByUser)
        .HasForeignKey(f => f.ResolvedByUserSK)
        .HasPrincipalKey(p => p.UserSK)
        .IsRequired(false);
    }
  }
}
