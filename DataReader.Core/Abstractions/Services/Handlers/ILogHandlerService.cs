using CSharpFunctionalExtensions;

using DataReader.Core.Commands.Logs;
using DataReader.Core.Queries.Logs;


namespace DataReader.Core.Abstractions.Services.Handlers
{
  public interface ILogHandlerService
  {
    Task<Result> Create(CreateLogCommand command);
    Task<Result> Get(GetLastSuccessfulLogQuery query);
  }
}