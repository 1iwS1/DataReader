using CSharpFunctionalExtensions;

namespace DataReader.Core.ValueObjects.Project
{
  public class ProjectName : ValueObject
  {
    private const int MAX_PROJECTNAME_LENGHT = 1000;
    public string? Name { get; }

    private ProjectName(string name)
    {
      Name = name;
    }

    public static Result<ProjectName> Create(string name)
    {
      if (name.Length > MAX_PROJECTNAME_LENGHT)
      {
        return Result.Failure<ProjectName>($"'{nameof(name)}' can't be more than {MAX_PROJECTNAME_LENGHT}");
      }

      return new ProjectName(name);
    }

    protected override IEnumerable<IComparable?> GetEqualityComponents()
    {
      yield return Name;
    }
  }
}
