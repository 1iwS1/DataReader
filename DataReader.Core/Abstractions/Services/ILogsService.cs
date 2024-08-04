using CSharpFunctionalExtensions;

using DataReader.Core.Commands.Logs;
using DataReader.Core.Models;
using DataReader.Core.Queries.Logs;


namespace DataReader.Core.Abstractions.Services
{
  public interface ILogsService
  {
    Task<Result> CreateLog(CreateLogCommand command);
    Task<Result<Log>> GetLastSuccessfulLog(GetLastSuccessfulLogQuery query);
  }
}