﻿using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;


namespace DataReader.Core.ValueObjects
{
  public class AnalyticsUpdatedDate : ValueObject
  {
    private const string REGEX_FOR_DATE = "^\\d{4}-\\d{2}-\\d{2}T\\d{2}:\\d{2}:\\d{2}(\\.\\d+)?Z$";
    public string? Date { get; }

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
