using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace DataReader.Core.ValueObjects
{
  public class AnalyticsUpdatedDate : ValueObject
  {
    // '2023-05-31T11:56:25.2733333Z' or '2024-05-16T11:10:41Z' or '2024-07-18T12:06:11.18+02:00' (ISO 8601)
    private const string REGEX_FOR_DATE = @"^\b\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}(\.\d+)?(Z|\+\d{2}:\d{2})\b$";
    public string? Date { get; }

    private AnalyticsUpdatedDate(string date)
    {
      Date = date;
    }

    public static Result<AnalyticsUpdatedDate> Create(JToken date)
    {
      string newStr = "";

      if (date.Type != JTokenType.Null)
      {
        newStr = date.ToString(Formatting.Indented).Trim('"');

        if (!Regex.IsMatch(newStr, REGEX_FOR_DATE))
        {
          return Result.Failure<AnalyticsUpdatedDate>($"'{nameof(date)}' must be correct");
        }
      }

      return new AnalyticsUpdatedDate(newStr);
    }

    protected override IEnumerable<IComparable?> GetEqualityComponents()
    {
      yield return Date;
    }
  }
}
