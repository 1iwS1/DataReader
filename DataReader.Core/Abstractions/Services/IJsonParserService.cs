using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Abstractions.Services
{
  public interface IJsonParserService
  {
    List<DTOParam>? ParseUser(string json);
  }
}