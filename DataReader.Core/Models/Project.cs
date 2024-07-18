using CSharpFunctionalExtensions;

using DataReader.Core.ValueObjects;


namespace DataReader.Core.Models
{
  public class Project
  {
    private Project(
      DataReaderGuid projectSK,
      DataReaderGuid projectId,
      string projectName,
      AnalyticsUpdatedDate analyticsUpdatedDate,
      string projectVisibility
      )
    {
      ProjectSK = projectSK;
      ProjectID = projectId;
      ProjectName = projectName;
      AnalyticsUpdatedDate = analyticsUpdatedDate;
      ProjectVisibility = projectVisibility;
    }

    public DataReaderGuid ProjectSK {  get; }
    public DataReaderGuid ProjectID { get; }
    public string? ProjectName {  get; }
    public AnalyticsUpdatedDate AnalyticsUpdatedDate { get; }
    public string? ProjectVisibility { get; }

    public static Result<Project> Create(
      DataReaderGuid projectSK,
      DataReaderGuid projectId,
      string projectName,
      AnalyticsUpdatedDate analyticsUpdatedDate,
      string projectVisibility
      )
    {
      Project project = new Project(projectSK, projectId, projectName, analyticsUpdatedDate, projectVisibility);

      return Result.Success(project);
    }
  }
}
