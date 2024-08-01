using Microsoft.EntityFrameworkCore;

using DataReader.DataAccess.BaseModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataReader.DataAccess.Configurations
{
  public class LogConfig : IEntityTypeConfiguration<LogBase>
  {
    public void Configure(EntityTypeBuilder<LogBase> builder)
    {
      BuildPropeties(builder);
    }

    private void BuildPropeties(EntityTypeBuilder<LogBase> builder)
    {
      builder.ComplexProperty(l => l.Id, b =>
      {
        b.Property(g => g!.CustomGuid).IsRequired();
      })
        .HasKey(p => p.Id);

      builder.ComplexProperty(p => p.LastSyncTime, b =>
      {
        b.Property(d => d!.Date).IsRequired(false);
      });

      builder
        .Property(p => p.SyncResult)
        .IsRequired(false);
    }
  }
}
