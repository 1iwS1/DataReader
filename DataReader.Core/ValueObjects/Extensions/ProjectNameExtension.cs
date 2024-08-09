using CSharpFunctionalExtensions;

using DataReader.Core.ValueObjects.Project;


namespace DataReader.Core.ValueObjects.Extensions
{
  public static class ProjectNameExtension
  {
    public static Result<ProjectName> Validate(this Result<ProjectName> projectName)
    {
      if (projectName.IsFailure)
      {
        throw new ArgumentException(projectName.Error);
      }

      return projectName;
    }
  }
}
