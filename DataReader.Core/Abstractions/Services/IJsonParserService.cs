using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Abstractions.Services
{
    public interface IJsonParserService
  {
    List<Param> ParseUser(string json);
  }
}