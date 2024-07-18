using CSharpFunctionalExtensions;
using DataReader.Core.Value_Objects;

namespace DataReader.Core.Models
{
    public class User
    {
        private User(
          Guid userSK,
          Guid userId,
          UserName userName,
          string userEmail,
          DateTime analyticsUpdatedDate,
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

        private Guid? UserSK { get; } // VO
        private Guid? UserId { get; } // VO
        private UserName UserName { get; }
        private string? UserEmail { get; } = string.Empty; // VO
        private DateTime? AnalyticsUpdatedDate { get; } // VO
        private Guid? GitHubUserId { get; } = null;
        private string? UserType { get; } = string.Empty;

        public static Result<User> Create(
          Guid userSK,
          Guid userId,
          string userName,
          string userEmail,
          DateTime analyticsUpdatedDate,
          Guid gitHubUserId,
          string userType
          )
        {
            User user = new User(userSK, userId, userName, userEmail, analyticsUpdatedDate, gitHubUserId, userType);

            return Result.Success(user);
        }
    }
}
