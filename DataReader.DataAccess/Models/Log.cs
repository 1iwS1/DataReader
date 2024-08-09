namespace DataReader.DataAccess.Models
{
  public partial class Log
  {
    public Guid Id { get; set; }
    public string? LastSyncTime { get; set; }
    public string? SyncResult { get; set; }
  }
}
