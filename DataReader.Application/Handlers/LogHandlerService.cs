using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Models;


namespace DataReader.Application.Handlers
{
  public class LogHandlerService : ILogHandlerService
  {
    private readonly ILogsService _logsService;

    public LogHandlerService(ILogsService logsService)
    {
      _logsService = logsService;
    }

    public async Task<Result> Get()
    {
      return await _logsService.GetLastSuccessfulLog();
    }

    public async Task<Result> Create(Log log)
    {
      return await _logsService.CreateLog(log);
    }
  }
}
