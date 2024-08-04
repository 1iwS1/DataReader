using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Commands.Logs;
using DataReader.Core.Models;
using DataReader.Core.Queries.Logs;


namespace DataReader.Application.Services
{
  public class LogsService : ILogsService
  {
    private readonly ILogsRepository _logsRepository;

    private readonly IQueryHandler<Task<Result<Log>>, GetLastSuccessfulLogQuery> _getLastQueryHandler;
    private readonly ICommandHandler<Task<Result>, CreateLogCommand> _createCommandHandler;

    public LogsService(
      ILogsRepository logsRepository,
      IQueryHandler<Task<Result<Log>>, GetLastSuccessfulLogQuery> getLastQueryHandler,
      ICommandHandler<Task<Result>, CreateLogCommand> createCommandHandler
      )
    {
      _logsRepository = logsRepository;
      _getLastQueryHandler = getLastQueryHandler;
      _createCommandHandler = createCommandHandler;
    }

    public async Task<Result<Log>> GetLastSuccessfulLog(GetLastSuccessfulLogQuery query)
    {
      return await _getLastQueryHandler.Handle(query);
    }

    public async Task<Result> CreateLog(CreateLogCommand command)
    {
      return await _createCommandHandler.Handle(command);
    }
  }
}
