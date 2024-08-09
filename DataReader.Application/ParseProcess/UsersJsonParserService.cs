using Newtonsoft.Json.Linq;
using CSharpFunctionalExtensions;

using DataReader.Core.Contracts.Params;
using DataReader.Core.Shells;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.ValueObjects;
using DataReader.Core.ValueObjects.User;
using DataReader.Core.ValueObjects.Extensions;


namespace DataReader.Application.ParseProcess
{
  public class UsersJsonParserService : IJsonParserService<Result<List<UsersDTOParam>?>>
  {
    public UsersJsonParserService() { }

    public Result<List<UsersDTOParam>?> Parse(string json)
    {
      try
      {
        List<UsersDTOParam>? result = new();
        List<UserParam>? userParam = new();

        JObject obj = JObject.Parse(json);
        JArray? array = (JArray?)obj["value"];

        if (array?.Count != 0)
        {
          userParam = FillParamList(array!);
          result = FillResultList(userParam);
        }

        return Result.Success<List<UsersDTOParam>?>(result);
      }

      catch (Exception ex)
      {
        return Result.Failure<List<UsersDTOParam>?>(ex.Message);
      }
    }

    private List<UserParam> FillParamList(JArray array)
    {
      List<UserParam>? temp = new();

      foreach (var item in array)
      {
        Result<DataReaderGuid> userSK = DataReaderGuid.Create(item["UserSK"].ToString()).Validate();
        Result<DataReaderGuid> userID = DataReaderGuid.Create(item["UserId"].ToString()).Validate();
        Result<UserName> userName = UserName.Create(item["UserName"].ToString()).Validate();
        Result<UserEmail> userEmail = UserEmail.Create(item["UserEmail"].ToString()).Validate();

        Result<AnalyticsUpdatedDate> analytics = AnalyticsUpdatedDate
          .Create(item["AnalyticsUpdatedDate"])
          .Validate();

        string? gitHubUserId = item["GitHubUserId"].ToString();
        string? userType = item["UserType"].ToString();

        UserParam param = new(
          userSK.Value, 
          userID.Value, 
          userName.Value, 
          userEmail.Value, 
          analytics.Value, 
          gitHubUserId, 
          userType
        );

        temp.Add(param);
      }

      return temp;
    }

    private List<UsersDTOParam> FillResultList(List<UserParam> userParam)
    {
      List<UsersDTOParam>? temp = new();

      foreach (var param in userParam)
      {
        UsersDTOParam dto = new(param);
        temp.Add(dto);
      }

      return temp;
    }
  }
}
