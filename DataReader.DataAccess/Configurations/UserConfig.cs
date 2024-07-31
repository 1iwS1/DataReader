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

    }

    private void BuildRelations(EntityTypeBuilder<UserBase> builder)
    {
      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.AssignedToUserSK);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ChangedByUserSK);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.CreatedByUserSK);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ActivatedByUserSK);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ClosedByUserSK);

      builder
        .HasMany(u => u.WorkItems)
        .WithOne(w => w.User)
        .HasPrincipalKey(p => p.UserSK)
        .HasForeignKey(f => f.ResolvedByUserSK);
    }
  }
}
