using CSharpFunctionalExtensions;

using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Abstractions.Services
{
  public interface IJsonParserService
  {
    Result<List<UsersDTOParam>?> ParseUser(string json);
  }
}