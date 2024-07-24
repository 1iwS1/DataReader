using DataReader.Core.ValueObjects;


namespace DataReader.Core.Shells
{
  public record LogParam(
    AnalyticsUpdatedDate lastSyncTime,
    string syncResult
  );
}
