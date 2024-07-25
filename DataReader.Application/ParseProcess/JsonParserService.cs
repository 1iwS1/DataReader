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

    public Result<List<UsersDTOParam>?> ParseUser(string json)
    {
      try
      {
        List<UsersDTOParam>? result = new();
        List<UserParam>? userParam = new();

        //userParam = JsonConvert.DeserializeObject<List<UserParam>>(json);

        JObject obj = JObject.Parse(json);
        JArray? array = (JArray?)obj["value"];

        if (array == null)
        {
          return Result.Failure<List<UsersDTOParam>?>("empty json");
        }

        userParam = array.ToObject<List<UserParam>>();

        foreach (var param in userParam)
        {
          UsersDTOParam dto = new(param);
          result.Add(dto);
        }

        return Result.Success<List<UsersDTOParam>?>(result);
      }

      catch (Exception ex)
      {
        return Result.Failure<List<UsersDTOParam>?>(ex.Message);
      }
    }
  }
}
