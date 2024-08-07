using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Commands.Logs;
using DataReader.Core.Models;
using DataReader.Core.Queries.Logs;


namespace DataReader.ExternalAPI.Controllers
{
  public class LogController
  {
    private readonly ILogHandlerService _logHandler;

    public LogController(ILogHandlerService logHandler)
    {
      _logHandler = logHandler;
    }

    public async Task<Result<Log>> GetLog()
    {
      GetLastSuccessfulLogQuery query = new();

      return await _logHandler.Get(query);
    }

    public async Task<Result> CreateLog(Log log)
    {
      CreateLogCommand command = new() { log = log };

      return await _logHandler.Create(command);
    }
  }
}
