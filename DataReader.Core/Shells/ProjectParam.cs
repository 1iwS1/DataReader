using DataReader.Core.ValueObjects.Project;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Shells
{
  public record ProjectParam(
    DataReaderGuid projectSK,
    DataReaderGuid projectId,
    ProjectName projectName,
    AnalyticsUpdatedDate analyticsUpdatedDate,
    string projectVisibility
  );
}
