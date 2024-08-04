using DataReader.Core.Enums;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Shells
{
  public record LogParam(
    DataReaderGuid id,
    AnalyticsUpdatedDate lastSyncTime,
    Results syncResult
  );
}
