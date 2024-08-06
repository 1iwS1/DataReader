using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Projects;


namespace DataReader.DataAccess.Handlers.Projects
{
  public class UpdateProjectCommandHandler : ICommandHandler<Task<Result<bool>>, UpdateProjectCommand>
  {
    private readonly DataAzureContext _dbContext;

    public UpdateProjectCommandHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(UpdateProjectCommand command)
    {
      await _dbContext.Projects
       .Where(p => p.ProjectId == command.targetId.CustomGuid)
       .ExecuteUpdateAsync(u => u
         .SetProperty(x => x.ProjectName, x => command.project.ProjectName.Name)
         .SetProperty(x => x.AnalyticsUpdatedDate, x => command.project.AnalyticsUpdatedDate.Date)
         .SetProperty(x => x.ProjectVisibility, x => command.project.ProjectVisibility));

      return true;
    }
  }
}
