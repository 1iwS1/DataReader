using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Projects;
using DataReader.DataAccess.Models;

namespace DataReader.DataAccess.Handlers.Projects
{
  public class CreateProjectCommandHandler : ICommandHandler<Task<Result<bool>>, CreateProjectCommand>
  {
    private readonly DataAzureContext _dbContext;

    public CreateProjectCommandHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(CreateProjectCommand command)
    {
      var projectBase = new Project
      {
        ProjectSk = (Guid)command.project.ProjectSK.CustomGuid!,
        ProjectId = command.project.ProjectID.CustomGuid,
        ProjectName = command.project.ProjectName.Name,
        AnalyticsUpdatedDate = command.project.AnalyticsUpdatedDate.Date,
        ProjectVisibility = command.project.ProjectVisibility
      };

      await _dbContext.AddAsync(projectBase);
      await _dbContext.SaveChangesAsync();

      return true;
    }
  }
}
