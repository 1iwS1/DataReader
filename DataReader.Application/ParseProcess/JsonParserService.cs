using Newtonsoft.Json.Linq;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Shells;


namespace DataReader.Application.ParseProcess
{
  public class JsonParserService : IJsonParserService
  {
    public JsonParserService() { }

    public Result<List<DTOParam>?> ParseUser(string json)
    {
      try
      {
        List<DTOParam>? result = new();
        List<UserParam>? userParam = new();

        //userParam = JsonConvert.DeserializeObject<List<UserParam>>(json);

        JObject obj = JObject.Parse(json);
        JArray? array = (JArray?)obj["value"];

        if (array == null)
        {
          return Result.Failure<List<DTOParam>?>("empty json");
        }

        userParam = array.ToObject<List<UserParam>>();

        foreach (var param in userParam)
        {
          DTOParam dto = new(param);
          result.Add(dto);
        }

        return Result.Success<List<DTOParam>?>(result);
      }

      catch (Exception ex)
      {
        return Result.Failure<List<DTOParam>?>(ex.Message);
      }
    }
  }
}
