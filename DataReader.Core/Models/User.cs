using CSharpFunctionalExtensions;
using DataReader.Core.ValueObjects.User;

namespace DataReader.Core.Models
{
    public class User
    {
        private User(
          UserGuid userSK,
          UserGuid userId,
          UserName userName,
          UserEmail userEmail,
          AnalyticsUpdatedDate analyticsUpdatedDate,
          Guid gitHubUserId,
          string userType
          )
        {
            UserSK = userSK;
            UserId = userId;
            UserName = userName;
            UserEmail = userEmail;
            AnalyticsUpdatedDate = analyticsUpdatedDate;
            GitHubUserId = gitHubUserId;
            UserType = userType;
        }

        private UserGuid UserSK { get; }
        private UserGuid UserId { get; }
        private UserName UserName { get; }
        private UserEmail UserEmail { get; }
        private AnalyticsUpdatedDate AnalyticsUpdatedDate { get; }
        private Guid? GitHubUserId { get; } = null;
        private string? UserType { get; } = string.Empty;

        public static Result<User> Create(
          UserGuid userSK,
          UserGuid userId,
          UserName userName,
          UserEmail userEmail,
          AnalyticsUpdatedDate analyticsUpdatedDate,
          Guid gitHubUserId,
          string userType
          )
        {
            User user = new User(userSK, userId, userName, userEmail, analyticsUpdatedDate, gitHubUserId, userType);

            return Result.Success(user);
        }
    }
}
