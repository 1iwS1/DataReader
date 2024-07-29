using CSharpFunctionalExtensions;

using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Abstractions.Services.Parsers
{
  public interface IProjectsJsonParserService
  {
    Result<List<ProjectsDTOParam>?> ParseProject(string json);
  }
}