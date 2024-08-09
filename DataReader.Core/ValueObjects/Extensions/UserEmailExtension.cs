using CSharpFunctionalExtensions;

using DataReader.Core.ValueObjects.User;


namespace DataReader.Core.ValueObjects.Extensions
{
  public static class UserEmailExtension
  {
    public static Result<UserEmail> Validate(this Result<UserEmail> userEmail)
    {
      if (userEmail.IsFailure)
      {
        throw new ArgumentException(userEmail.Error);
      }

      return userEmail;
    }
  }
}
