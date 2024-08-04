using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Users;


namespace DataReader.DataAccess.Handlers.Users
{
  public class UpdateUserCommandHandler : ICommandHandler<Task<Result<bool>>, UpdateUserCommand>
  {
    private readonly DataDbContext _dbContext;

    public UpdateUserCommandHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(UpdateUserCommand command)
    {
      await _dbContext.Users
        .Where(u => u.UserId == command.targetId)
        .ExecuteUpdateAsync(u => u
          .SetProperty(x => x.UserName, x => command.user.UserName)
          .SetProperty(x => x.UserEmail, x => command.user.UserEmail)
          .SetProperty(x => x.AnalyticsUpdatedDate, x => command.user.AnalyticsUpdatedDate)
          .SetProperty(x => x.GitHubUserId, x => command.user.GitHubUserId)
          .SetProperty(x => x.UserType, x => command.user.UserType));

      return true;
    }
  }
}
