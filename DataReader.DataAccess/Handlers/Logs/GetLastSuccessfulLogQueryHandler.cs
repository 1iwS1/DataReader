using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Enums;
using DataReader.Core.Models;
using DataReader.Core.Queries.Logs;
using DataReader.Core.Shells;


namespace DataReader.DataAccess.Handlers.Logs
{
  public class GetLastSuccessfulLogQueryHandler : IQueryHandler<Task<Result<Log>>, GetLastSuccessfulLogQuery>
  {
    private readonly DataDbContext _dbContext;

    public GetLastSuccessfulLogQueryHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<Log>> Handle(GetLastSuccessfulLogQuery query)
    {
      var logBase = await _dbContext.Logs
        .AsNoTracking()
        .Where(r => r.SyncResult == Results.Succeed)
        .OrderByDescending(r => r.LastSyncTime)
        .FirstOrDefaultAsync();

      if (logBase == null)
      {
        return Result.Failure<Log>(nameof(Log));
      }

      Result<Log> log = Log.Create(new LogParam(logBase.Id!, logBase.LastSyncTime!, logBase.SyncResult!));

      return log;
    }
  }
}
