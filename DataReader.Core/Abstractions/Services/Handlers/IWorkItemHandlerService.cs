using CSharpFunctionalExtensions;
using DataReader.Core.Contracts.Params;

namespace DataReader.Core.Abstractions.Services.Handlers
{
  public interface IWorkItemHandlerService
  {
    Task<Result> Parsing(string json);
    Task<Result> Sync(List<WorkItemsDTOParam> workItems);
  }
}