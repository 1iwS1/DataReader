using CSharpFunctionalExtensions;
using System.Text.RegularExpressions;

namespace DataReader.Core.Value_Objects
{
  public class AnalyticsUpdatedDate : ValueObject
  {
    private const string REGEX_FOR_DATE = "";
    public string? Date { get;}

    private AnalyticsUpdatedDate(string date)
    {
      Date = date;
    }

    public static Result<AnalyticsUpdatedDate> Create(string date)
    {
      if (!Regex.IsMatch(date, REGEX_FOR_DATE))
      {
        return Result.Failure<AnalyticsUpdatedDate>($"'{nameof(date)}' must be correct");
      }

      return new AnalyticsUpdatedDate(date);
    }

    protected override IEnumerable<IComparable?> GetEqualityComponents()
    {
      yield return Date;
    }
  }
}
