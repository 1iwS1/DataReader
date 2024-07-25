using CSharpFunctionalExtensions;

using System.Text.RegularExpressions;


namespace DataReader.Core.ValueObjects
{
  public class DataReaderGuid : ValueObject
  {
    private const string REGEX_FOR_GUID = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";
    public Guid? UserSK { get; }

    private DataReaderGuid(Guid userSK)
    {
      UserSK = userSK;
    }

    public static Result<DataReaderGuid> Create(Guid userG)
    {
      if (!Regex.IsMatch(userG.ToString(), REGEX_FOR_GUID))
      {
        return Result.Failure<DataReaderGuid>($"'{nameof(userG)}' must be Guid");
      }

      return new DataReaderGuid(userG);
    }

    protected override IEnumerable<IComparable?> GetEqualityComponents()
    {
      yield return UserSK;
    }
  }
}
