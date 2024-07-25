using CSharpFunctionalExtensions;
using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Abstractions.Services.Parsers
{
  public interface IJsonParserService
  {
    Result<List<UsersDTOParam>?> ParseUser(string json);
  }
}