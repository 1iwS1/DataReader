using CSharpFunctionalExtensions;
using DataReader.Core.Models;

namespace DataReader.Core.Abstractions.Repositories
{
  public interface ILogsRepository
  {
    Task<Result> Create(Log log);
    Task<Result<Log>> Get();
  }
}
