using CSharpFunctionalExtensions;
using System.Text.RegularExpressions;


namespace DataReader.Core.ValueObjects
{
  public class DataReaderGuid : ValueObject
  {
    private const string REGEX_FOR_GUID = "";
    public Guid? UserG { get; }

    private DataReaderGuid(Guid userG)
    {
      UserG = userG;
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
      yield return UserG;
    }
  }
}
