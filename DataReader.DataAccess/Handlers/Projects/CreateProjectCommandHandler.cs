using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Projects;
using DataReader.DataAccess.BaseModels;

namespace DataReader.DataAccess.Handlers.Projects
{
  public class CreateProjectCommandHandler : ICommandHandler<Task<Result<bool>>, CreateProjectCommand>
  {
    private readonly DataDbContext _dbContext;

    public CreateProjectCommandHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(CreateProjectCommand command)
    {
      var projectBase = new ProjectBase
      {
        ProjectSK = command.project.ProjectSK,
        ProjectID = command.project.ProjectID,
        ProjectName = command.project.ProjectName,
        AnalyticsUpdatedDate = command.project.AnalyticsUpdatedDate,
        ProjectVisibility = command.project.ProjectVisibility
      };

      await _dbContext.AddAsync(projectBase);
      await _dbContext.SaveChangesAsync();

      return true;
    }
  }
}
