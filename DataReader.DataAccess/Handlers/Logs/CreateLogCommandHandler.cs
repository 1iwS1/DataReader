using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Logs;
using DataReader.Core.Models;
using DataReader.DataAccess.BaseModels;


namespace DataReader.DataAccess.Handlers.Logs
{
  public class CreateLogCommandHandler : ICommandHandler<Task<Result>, CreateLogCommand>
  {
    private readonly DataDbContext _dbContext;

    public CreateLogCommandHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result> Handle(CreateLogCommand command)
    {
      var logBase = new LogBase
      {
        Id = command.log.Id,
        LastSyncTime = command.log.LastSyncTime,
        SyncResult = command.log.SyncResult!
      };

      await _dbContext.AddAsync(logBase);
      await _dbContext.SaveChangesAsync();

      return Result.Success<Log>(command.log);
    }
  }
}
