using Newtonsoft.Json.Linq;
using CSharpFunctionalExtensions;

using DataReader.Core.Contracts.Params;
using DataReader.Core.Shells;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.ValueObjects;
using DataReader.Core.ValueObjects.User;


namespace DataReader.Application.ParseProcess
{
  public class UsersJsonParserService : IUsersJsonParserService
  {
    public UsersJsonParserService() { }

    public Result<List<UsersDTOParam>?> ParseUser(string json)
    {
      try
      {
        List<UsersDTOParam>? result = new();
        List<UserParam>? userParam = new();

        JObject obj = JObject.Parse(json);
        JArray array = (JArray)obj["value"];

        if (array.Count != 0)
        {
          userParam = FillUserParamList(array);
          result = FillResultList(userParam);
        }

        return Result.Success<List<UsersDTOParam>?>(result);
      }

      catch (Exception ex)
      {
        return Result.Failure<List<UsersDTOParam>?>(ex.Message);
      }
    }

    private List<UserParam> FillUserParamList(JArray array)
    {
      List<UserParam>? temp = new();

      foreach (var item in array)
      {
        DataReaderGuid userSK = DataReaderGuid.Create(item["UserSK"].ToString()).Value;
        DataReaderGuid userID = DataReaderGuid.Create(item["UserId"].ToString()).Value;
        UserName userName = UserName.Create(item["UserName"].ToString()).Value;
        UserEmail userEmail = UserEmail.Create(item["UserEmail"].ToString()).Value;

        AnalyticsUpdatedDate analytics =
          AnalyticsUpdatedDate.
          Create(item["AnalyticsUpdatedDate"]).
          Value;

        string? gitHubUserId = item["GitHubUserId"].ToString();
        string? userType = item["UserType"].ToString();

        UserParam param = new(userSK, userID, userName, userEmail, analytics, gitHubUserId, userType);
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
