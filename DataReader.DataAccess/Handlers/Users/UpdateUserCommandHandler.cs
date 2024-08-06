using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Users;


namespace DataReader.DataAccess.Handlers.Users
{
  public class UpdateUserCommandHandler : ICommandHandler<Task<Result<bool>>, UpdateUserCommand>
  {
    private readonly DataAzureContext _dbContext;

    public UpdateUserCommandHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(UpdateUserCommand command)
    {
      await _dbContext.Users
        .Where(u => u.UserId == command.targetId.CustomGuid.ToString())
        .ExecuteUpdateAsync(u => u
          .SetProperty(x => x.UserName, x => command.user.UserName.Name)
          .SetProperty(x => x.UserEmail, x => command.user.UserEmail.Email)
          .SetProperty(x => x.AnalyticsUpdatedDate, x => command.user.AnalyticsUpdatedDate.Date)
          .SetProperty(x => x.GitHubUserId, x => command.user.GitHubUserId)
          .SetProperty(x => x.UserType, x => command.user.UserType));

      return true;
    }
  }
}
