using Newtonsoft.Json;
using CSharpFunctionalExtensions;

using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;
using DataReader.Core.ValueObjects.User;


namespace DataReader.Core.Models
{
  public class User
  {
    private User(UserParam shell)
    {
      UserSK = shell.userSK;
      UserId = shell.userId;
      UserName = shell.userName;
      UserEmail = shell.userEmail;
      AnalyticsUpdatedDate = shell.analyticsUpdatedDate;
      GitHubUserId = shell.gitHubUserId;
      UserType = shell.userType;
    }

    [JsonProperty("UserSK")]
    public DataReaderGuid UserSK { get; }

    [JsonProperty("UserId")]
    public DataReaderGuid UserId { get; }

    [JsonProperty("UserName")]
    public UserName UserName { get; }

    [JsonProperty("UserEmail")]
    public UserEmail UserEmail { get; }

    [JsonProperty("AnalyticsUpdatedDate")]
    public AnalyticsUpdatedDate AnalyticsUpdatedDate { get; }
    public string? GitHubUserId { get; }
    public string? UserType { get; } = string.Empty;

    public static Result<User> Create(UserParam shell)
    {
      User user = new User(shell);

      return Result.Success(user);
    }
  }
}
