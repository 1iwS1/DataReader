using CSharpFunctionalExtensions;


namespace DataReader.Core.ValueObjects.Extensions
{
  public static class AnalyticsUpdatedDateExtension
  {
    public static Result<AnalyticsUpdatedDate> Validate(this Result<AnalyticsUpdatedDate> analytics)
    {
      if (analytics.IsFailure)
      {
        throw new ArgumentException(analytics.Error);
      }

      return analytics;
    }
  }
}
