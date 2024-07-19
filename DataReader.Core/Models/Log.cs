using CSharpFunctionalExtensions;

using DataReader.Core.ValueObjects;


namespace DataReader.Core.Models
{
  public class Log
  {
    private Log(
      AnalyticsUpdatedDate lastSyncTime,
      string syncResult
      )
    {
      LastSyncTime = lastSyncTime;
      SyncResult = syncResult;
    }

    public AnalyticsUpdatedDate LastSyncTime { get; }
    public string? SyncResult { get; }

    public static Result<Log> Create(
      AnalyticsUpdatedDate lastSyncTime,
      string result
      )
    {
      Log log = new Log(lastSyncTime, result);

      return Result.Success(log);
    }
  }
}
