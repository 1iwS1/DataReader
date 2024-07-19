﻿using CSharpFunctionalExtensions;

using DataReader.Core.ValueObjects;
using DataReader.Core.ValueObjects.User;


namespace DataReader.Core.Models
{
  public class User
  {
    private User(
      DataReaderGuid userSK,
      DataReaderGuid userId,
      UserName userName,
      UserEmail userEmail,
      AnalyticsUpdatedDate analyticsUpdatedDate,
      DataReaderGuid gitHubUserId,
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

    private DataReaderGuid UserSK { get; }
    private DataReaderGuid UserId { get; }
    private UserName UserName { get; }
    private UserEmail UserEmail { get; }
    private AnalyticsUpdatedDate AnalyticsUpdatedDate { get; }
    private DataReaderGuid GitHubUserId { get; }
    private string? UserType { get; } = string.Empty;

    public static Result<User> Create(
      DataReaderGuid userSK,
      DataReaderGuid userId,
      UserName userName,
      UserEmail userEmail,
      AnalyticsUpdatedDate analyticsUpdatedDate,
      DataReaderGuid gitHubUserId,
      string userType
      )
    {
      User user = new User(userSK, userId, userName, userEmail, analyticsUpdatedDate, gitHubUserId, userType);

      return Result.Success(user);
    }
  }
}
