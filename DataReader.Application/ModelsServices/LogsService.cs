using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
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

    public async Task<Result<Log>> GetLastSuccessfulLog()
    {
      return await _logsRepository.Get();
    }

    public async Task<Result> CreateLog(Log log)
    {
      return await _logsRepository.Create(log);
    }
  }
}
