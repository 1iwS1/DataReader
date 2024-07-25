﻿using CSharpFunctionalExtensions;
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

    public string? UserSK { get; }
    public string? UserId { get; }
    public string? UserName { get; }
    public string? UserEmail { get; }
    public string? AnalyticsUpdatedDate { get; }
    public string? GitHubUserId { get; }
    public string? UserType { get; } = string.Empty;

    public static Result<User> Create(UserParam shell)
    {
      User user = new User(shell);

      return Result.Success(user);
    }
  }
}
