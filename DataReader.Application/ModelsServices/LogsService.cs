using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Models;


namespace DataReader.Application.Services
{
  public class LogsService : ILogsService
  {
    private readonly ILogsRepository _logsRepository;

    public LogsService(ILogsRepository logsRepository)
    {
      _logsRepository = logsRepository;
    }

    //public async Task<Result> GetLog()
    //{
    //  return await _logsRepository.
    //}

    //public async Task<Result> CreateLog(Log log)
    //{
    //  return await _logsRepository.
    //}
  }
}
