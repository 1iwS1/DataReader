using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Models;


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
      return new Result<Log>();
    }

    public async Task<Result> CreateLog()
    {
      return new Result<Log>();
    }
  }
}
