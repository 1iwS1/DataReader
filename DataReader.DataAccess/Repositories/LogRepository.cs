using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Models;
using DataReader.Core.Shells;
using DataReader.DataAccess.BaseModels;
using DataReader.Core.Enums;


namespace DataReader.DataAccess.Repositories
{
  public class LogRepository : ILogsRepository
  {
    private readonly DataDbContext _dbContext;

    public LogRepository(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<Log>> Get()
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

    public async Task<Result> Create(Log log)
    {
      var logBase = new LogBase
      {
        Id = log.Id,
        LastSyncTime = log.LastSyncTime,
        SyncResult = log.SyncResult!
      };

      await _dbContext.AddAsync(logBase);
      await _dbContext.SaveChangesAsync();

      return Result.Success<Log>(log);
    }
  }
}
