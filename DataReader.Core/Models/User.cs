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

    private DataReaderGuid UserSK { get; }
    private DataReaderGuid UserId { get; }
    private UserName UserName { get; }
    private UserEmail UserEmail { get; }
    private AnalyticsUpdatedDate AnalyticsUpdatedDate { get; }
    private DataReaderGuid GitHubUserId { get; }
    private string? UserType { get; } = string.Empty;

    public static Result<User> Create(UserParam shell)
    {
      User user = new User(shell);

      return Result.Success(user);
    }
  }
}
