using CSharpFunctionalExtensions;

using DataReader.Core.ValueObjects.User;


namespace DataReader.Core.ValueObjects.Extensions
{
  public static class UserNameExtension
  {
    public static Result<UserName> Validate(this Result<UserName> userName)
    {
      if (userName.IsFailure)
      {
        throw new ArgumentException(userName.Error);
      }

      return userName;
    }
  }
}
