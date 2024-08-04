using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.Users;
using DataReader.DataAccess.BaseModels;


namespace DataReader.DataAccess.Handlers.Users
{
  public class CreateUserCommandHandler : ICommandHandler<Task<Result<bool>>, CreateUserCommand>
  {
    private readonly DataDbContext _dbContext;

    public CreateUserCommandHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(CreateUserCommand command)
    {
      var userBase = new UserBase
      {
        UserSK = command.user.UserSK,
        UserId = command.user.UserId,
        UserName = command.user.UserName,
        UserEmail = command.user.UserEmail,
        AnalyticsUpdatedDate = command.user.AnalyticsUpdatedDate,
        GitHubUserId = command.user.GitHubUserId,
        UserType = command.user.UserType
      };

      await _dbContext.AddAsync(userBase);
      await _dbContext.SaveChangesAsync();

      return true;
    }
  }
}
