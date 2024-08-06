using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Enums;
using DataReader.Core.Models;
using DataReader.Core.Queries.Logs;
using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;


namespace DataReader.DataAccess.Handlers.Logs
{
  public class GetLastSuccessfulLogQueryHandler : IQueryHandler<Task<Result<Log>>, GetLastSuccessfulLogQuery>
  {
    private readonly DataAzureContext _dbContext;

    public GetLastSuccessfulLogQueryHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<Log>> Handle(GetLastSuccessfulLogQuery query)
    {
      var logBase = await _dbContext.Logs
        .AsNoTracking()
        .Where(r => r.SyncResult == Results.Succeed.ToString())
        .OrderByDescending(r => r.LastSyncTime)
        .FirstOrDefaultAsync();

      if (logBase == null)
      {
        return Result.Failure<Log>(nameof(Log));
      }

      Result<Log> log = Log.Create(new LogParam(
        DataReaderGuid.Create(logBase.Id.ToString()).Value,
        AnalyticsUpdatedDate.Create(logBase.LastSyncTime!).Value,
        (Results)Enum.Parse(typeof(Results), logBase.SyncResult!)
      ));

      return log;
    }
  }
}
