using CSharpFunctionalExtensions;

namespace DataReader.Core.Models
{
  public class Project
  {
    private Project(
      Guid projectSK,
      Guid projectId,
      string projectName,
      string analyticsUpdatedDate,
      string projectVisibility
      )
    {
      ProjectSK = projectSK;
      ProjectID = projectId;
      ProjectName = projectName;
      AnalyticsUpdatedDate = analyticsUpdatedDate;
      ProjectVisibility = projectVisibility;
    }

    public Guid? ProjectSK {  get; }
    public Guid? ProjectID { get; }
    public string? ProjectName {  get; }
    public string? AnalyticsUpdatedDate { get; }
    public string? ProjectVisibility { get; }

    public static Result<Project> Create(
      Guid projectSK,
      Guid projectId,
      string projectName,
      string analyticsUpdatedDate,
      string projectVisibility
      )
    {
      Project project = new Project(projectSK, projectId, projectName, analyticsUpdatedDate, projectVisibility);

      return Result.Success(project);
    }
  }
}
