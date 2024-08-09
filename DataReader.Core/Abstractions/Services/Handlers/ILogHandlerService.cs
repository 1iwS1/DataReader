using CSharpFunctionalExtensions;

using DataReader.Core.Commands.Logs;
using DataReader.Core.Models;
using DataReader.Core.Queries.Logs;


namespace DataReader.Core.Abstractions.Services.Handlers
{
  public interface ILogHandlerService
  {
    Task<Result> Create(CreateLogCommand command);
    Task<Result<Log>> Get(GetLastSuccessfulLogQuery query);
  }
}