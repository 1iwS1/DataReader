using CSharpFunctionalExtensions;
using System.Text.RegularExpressions;

namespace DataReader.Core.Value_Objects
{
  public class UserName : ValueObject
  {
    private const int MAX_USERNAME_LENGHT = 100;
    private const string REGEX_FOR_NAME = "^[^\\d]+$";
    public string? Name { get; } = string.Empty;

    private UserName(string name)
    {
      Name = name;
    }

    public static Result<UserName> Create(string name)
    {
      if (name.Length > MAX_USERNAME_LENGHT)
      {
        Result.Failure($"'{nameof(name)}' can't be more than {MAX_USERNAME_LENGHT}");
      }
      
      if (Regex.IsMatch(name, REGEX_FOR_NAME))
      {
        Result.Failure($"'{nameof(name)}' must not contain numbers");
      }

      return new UserName(name);
    }

    protected override IEnumerable<IComparable?> GetEqualityComponents()
    {
      yield return Name;
    }
  }
}
