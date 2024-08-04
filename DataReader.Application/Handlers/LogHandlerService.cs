using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Commands.Logs;
using DataReader.Core.Queries.Logs;


namespace DataReader.Application.Handlers
{
  public class LogHandlerService : ILogHandlerService
  {
    private readonly ILogsService _logsService;

    public LogHandlerService(ILogsService logsService)
    {
      _logsService = logsService;
    }

    public async Task<Result> Get(GetLastSuccessfulLogQuery query)
    {
      return await _logsService.GetLastSuccessfulLog(query);
    }

    public async Task<Result> Create(CreateLogCommand command)
    {
      return await _logsService.CreateLog(command);
    }
  }
}
