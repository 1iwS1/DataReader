using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Logs;
using DataReader.DataAccess.Models;


namespace DataReader.DataAccess.Handlers.Logs
{
  public class CreateLogCommandHandler : ICommandHandler<Task<Result>, CreateLogCommand>
  {
    private readonly DataAzureContext _dbContext;

    public CreateLogCommandHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result> Handle(CreateLogCommand command)
    {
      var logBase = new Log
      {
        Id = (Guid)command.log.Id.CustomGuid!,
        LastSyncTime = command.log.LastSyncTime.Date,
        SyncResult = command.log.SyncResult.ToString()
      };

      await _dbContext.AddAsync(logBase);
      await _dbContext.SaveChangesAsync();

      return Result.Success<Core.Models.Log>(command.log);
    }
  }
}
