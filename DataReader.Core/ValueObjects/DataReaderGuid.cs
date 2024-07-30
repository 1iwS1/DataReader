using CSharpFunctionalExtensions;

using System.Text.RegularExpressions;


namespace DataReader.Core.ValueObjects
{
  public class DataReaderGuid : ValueObject
  {
    private const string REGEX_FOR_GUID = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";
    public Guid? CustomGuid { get; }

    private DataReaderGuid(Guid? customGuid)
    {
      CustomGuid = customGuid;
    }

    public static Result<DataReaderGuid> Create(string customGuid)
    {
      if (!string.IsNullOrEmpty(customGuid))
      {
        if (!Regex.IsMatch(customGuid, REGEX_FOR_GUID))
        {
          return Result.Failure<DataReaderGuid>($"'{nameof(customGuid)}' must be Guid");
        }
      }

      return new DataReaderGuid(!string.IsNullOrEmpty(customGuid) ? new Guid(customGuid) : null);
    }

    protected override IEnumerable<IComparable?> GetEqualityComponents()
    {
      yield return CustomGuid;
    }
  }
}
