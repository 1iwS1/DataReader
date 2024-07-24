using Newtonsoft.Json;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Params;


namespace DataReader.Application.ParseProcess
{
  public class JsonParserService : IJsonParserService
  {
    public JsonParserService() { }

    public List<DTOParam>? ParseUser(string json)
    {
      try
      {
        List<DTOParam>? result = new List<DTOParam>();

        result = JsonConvert.DeserializeObject<List<DTOParam>>(json);

        return result;
      }

      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}
