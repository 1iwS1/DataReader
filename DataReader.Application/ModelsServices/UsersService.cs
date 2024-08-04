using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Commands.Users;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.Queries.Users;


namespace DataReader.Application.ModelsServices
{
  public class UsersService : IServiceProcess<Task<Result>, UsersRequest>
  {
    private readonly IQueryHandler<Task<Result<bool>>, GetByIdUserQuery> _getByIdQueryHandler;

    private readonly ICommandHandler<Task<Result<bool>>, UpdateUserCommand> _updateCommandHandler;
    private readonly ICommandHandler<Task<Result<bool>>, CreateUserCommand> _createCommandHandler;

    public UsersService(
      IQueryHandler<Task<Result<bool>>, GetByIdUserQuery> getByIdQueryHandler,
      ICommandHandler<Task<Result<bool>>, UpdateUserCommand> updateCommandHandler,
      ICommandHandler<Task<Result<bool>>, CreateUserCommand> createCommandHandler
      )
    {
      _getByIdQueryHandler = getByIdQueryHandler;
      _updateCommandHandler = updateCommandHandler;
      _createCommandHandler = createCommandHandler;
    }

    public async Task<Result> SyncProcess(UsersRequest userRequests)
    {
      foreach (var request in userRequests.UsersRequestCollection)
      {
        Result<User> user = User.Create(request.shell);
        Result<bool> userToCompareWith = await GetUser(new() { id = user.Value.UserId });

        if (userToCompareWith.Value)
        {
          UpdateUserCommand updateCommand = new()
          {
            targetId = user.Value.UserId,
            user = user.Value
          };

          await UpdateUser(updateCommand);
        }

        else
        {
          CreateUserCommand createCommand = new() { user = user.Value };
          await CreateUser(createCommand);
        }
      }

      return Result.Success();
    }

    private async Task<Result<bool>> GetUser(GetByIdUserQuery query)
    {
      return await _getByIdQueryHandler.Handle(query);
    }

    private async Task<Result<bool>> UpdateUser(UpdateUserCommand command)
    {
      return await _updateCommandHandler.Handle(command);
    }

    private async Task<Result<bool>> CreateUser(CreateUserCommand command)
    {
      return await _createCommandHandler.Handle(command);
    }
  }
}
