using CSharpFunctionalExtensions;

using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Abstractions.Services.Parsers
{
  public interface IWorkItemsJsonParserService
  {
    Result<List<WorkItemsDTOParam>?> ParseWorkItem(string json);
  }
}