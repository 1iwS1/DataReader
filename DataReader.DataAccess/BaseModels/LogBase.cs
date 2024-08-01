using DataReader.Core.ValueObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataReader.DataAccess.BaseModels
{
  public class LogBase
  {
    [Column("Id")]
    public DataReaderGuid? Id { get; }

    [Column("LastSyncTime")]
    public AnalyticsUpdatedDate? LastSyncTime { get; }
    public string? SyncResult { get; }
  }
}
