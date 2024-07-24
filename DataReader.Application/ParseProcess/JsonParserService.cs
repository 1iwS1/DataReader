using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Params;


namespace DataReader.Application.ParseProcess
{
    public class JsonParserService : IJsonParserService
  {
    public JsonParserService() { }

    public List<Param> ParseUser(string json)
    {
      return new List<Param> { };
    }
  }
}
