using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using DataReader.DataAccess.BaseModels;


namespace DataReader.DataAccess.Configurations
{
  public class UserConfig : IEntityTypeConfiguration<UserBase>
  {
    public void Configure(EntityTypeBuilder<UserBase> builder)
    {
      BuildRelations(builder);
      BuildProperties(builder);
    }

    private void BuildProperties(EntityTypeBuilder<UserBase> builder)
    {
      builder.ComplexProperty(u => u.UserSK, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired();
      })
        .HasKey(u => u.UserSK);

      builder.ComplexProperty(u => u.UserId, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired(false);
      });

      builder.ComplexProperty(u => u.UserName, b =>
      {
        b.Property(n => n!.Name).IsRequired(false);
      });

      builder.ComplexProperty(u => u.UserEmail, b =>
      {
        b.Property(e => e!.Email).IsRequired(false);
      });

      builder.ComplexProperty(u => u.AnalyticsUpdatedDate, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder.ComplexProperty(u => u.UserId, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired(false);
      });

      builder
        .Property(g => g.GitHubUserId)
        .IsRequired(false);

      builder
        .Property(u => u.UserType)
        .IsRequired(false);
    }

    private void BuildRelations(EntityTypeBuilder<UserBase> builder)
    {
      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.AssignedToUserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ChangedByUserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.CreatedByUserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ActivatedByUserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ClosedByUserSK)
        .IsRequired(false);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ResolvedByUserSK)
        .IsRequired(false);
    }
  }
}
