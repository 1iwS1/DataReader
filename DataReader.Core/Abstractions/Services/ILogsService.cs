using CSharpFunctionalExtensions;
using DataReader.Core.Models;


namespace DataReader.Core.Abstractions.Services
{
  public interface ILogsService
  {
    Task<Result> CreateLog(Log log);
    Task<Result<Log>> GetLastSuccessfulLog();
  }
}