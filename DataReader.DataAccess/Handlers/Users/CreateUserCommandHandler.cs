using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Users;
using DataReader.DataAccess.Models;


namespace DataReader.DataAccess.Handlers.Users
{
  public class CreateUserCommandHandler : ICommandHandler<Task<Result<bool>>, CreateUserCommand>
  {
    private readonly DataAzureContext _dbContext;

    public CreateUserCommandHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(CreateUserCommand command)
    {
      var userBase = new User
      {
        UserSk = (Guid)command.user.UserSK.CustomGuid!,
        UserId = command.user.UserId.CustomGuid.ToString(),
        UserName = command.user.UserName.Name,
        UserEmail = command.user.UserEmail.Email,
        AnalyticsUpdatedDate = command.user.AnalyticsUpdatedDate.Date,
        GitHubUserId = command.user.GitHubUserId,
        UserType = command.user.UserType
      };

      await _dbContext.AddAsync(userBase);
      await _dbContext.SaveChangesAsync();

      return true;
    }
  }
}
