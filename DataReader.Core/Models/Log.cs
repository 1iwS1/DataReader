using CSharpFunctionalExtensions;

using DataReader.Core.Enums;
using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Models
{
  public class Log
  {
    private Log(LogParam shell)
    {
      Id = shell.id;
      LastSyncTime = shell.lastSyncTime;
      SyncResult = shell.syncResult;
    }

    public DataReaderGuid Id { get; }
    public AnalyticsUpdatedDate LastSyncTime { get; }
    public Results SyncResult { get; }

    public static Result<Log> Create(LogParam shell)
    {
      Log log = new Log(shell);

      return Result.Success(log);
    }
  }
}
