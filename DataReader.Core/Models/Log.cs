using CSharpFunctionalExtensions;

using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Models
{
  public class Log
  {
    private Log(LogParam shell)
    {
      LastSyncTime = shell.lastSyncTime;
      SyncResult = shell.syncResult;
    }

    public AnalyticsUpdatedDate LastSyncTime { get; }
    public string? SyncResult { get; }

    public static Result<Log> Create(LogParam shell)
    {
      Log log = new Log(shell);

      return Result.Success(log);
    }
  }
}
