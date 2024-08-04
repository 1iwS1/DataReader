using System.ComponentModel.DataAnnotations.Schema;

using DataReader.Core.Enums;
using DataReader.Core.ValueObjects;


namespace DataReader.DataAccess.BaseModels
{
  public class LogBase
  {
    [Column("Id")]
    public DataReaderGuid? Id { get; set; }

    [Column("LastSyncTime")]
    public AnalyticsUpdatedDate? LastSyncTime { get; set; }

    [Column("SyncResult")]
    public Results SyncResult { get; set; } = Results.None;
  }
}
