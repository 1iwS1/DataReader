using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Projects;


namespace DataReader.DataAccess.Handlers.Projects
{
  public class UpdateProjectCommandHandler : ICommandHandler<Task<Result<bool>>, UpdateProjectCommand>
  {
    private readonly DataDbContext _dbContext;

    public UpdateProjectCommandHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(UpdateProjectCommand command)
    {
      await _dbContext.Projects
       .Where(p => p.ProjectID == command.targetId)
       .ExecuteUpdateAsync(u => u
         .SetProperty(x => x.ProjectName, x => command.project.ProjectName)
         .SetProperty(x => x.AnalyticsUpdatedDate, x => command.project.AnalyticsUpdatedDate)
         .SetProperty(x => x.ProjectVisibility, x => command.project.ProjectVisibility));

      return true;
    }
  }
}
