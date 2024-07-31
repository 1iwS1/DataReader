using CSharpFunctionalExtensions;

using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;
using DataReader.Core.ValueObjects.Project;


namespace DataReader.Core.Models
{
  public class Project
  {
    private Project(ProjectParam shell)
    {
      ProjectSK = shell.projectSK;
      ProjectID = shell.projectId;
      ProjectName = shell.projectName;
      AnalyticsUpdatedDate = shell.analyticsUpdatedDate;
      ProjectVisibility = shell.projectVisibility;
    }

    public DataReaderGuid ProjectSK { get; }
    public DataReaderGuid ProjectID { get; }
    public ProjectName ProjectName { get; }
    public AnalyticsUpdatedDate AnalyticsUpdatedDate { get; }
    public string? ProjectVisibility { get; }

    public static Result<Project> Create(ProjectParam shell)
    {
      Project project = new Project(shell);

      return Result.Success(project);
    }
  }
}
