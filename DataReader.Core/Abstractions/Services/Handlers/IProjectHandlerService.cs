using CSharpFunctionalExtensions;
using DataReader.Core.Contracts.Params;

namespace DataReader.Core.Abstractions.Services.Handlers
{
  public interface IProjectHandlerService
  {
    Task<Result> Parsing(string json);
    Task<Result> Sync(List<ProjectsDTOParam>? projects);
  }
}