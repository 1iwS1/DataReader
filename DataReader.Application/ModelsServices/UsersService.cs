using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Application.ModelsServices
{
  public class UsersService : IServiceProcess<Task<Result>, UsersRequest>
  {
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task<Result> SyncProcess(UsersRequest userRequests)
    {
      foreach (var request in userRequests.UsersRequestCollection)
      {
        Result<User> user = User.Create(request.shell);
        Result<bool> userToCompareWith = await GetUser(user.Value.UserId);

        if (userToCompareWith.Value)
        {
          await UpdateUser(user.Value.UserId, user.Value);
        }

        else
        {
          await CreateUser(user.Value);
        }
      }

      return Result.Success();
    }

    private async Task<Result<bool>> GetUser(DataReaderGuid userId)
    {
      return await _usersRepository.GetById(userId);
    }

    private async Task<Result<bool>> UpdateUser(DataReaderGuid userId, User user)
    {
      return await _usersRepository.Update(userId, user);
    }

    private async Task<Result<bool>> CreateUser(User user)
    {
      return await _usersRepository.Create(user);
    }
  }
}
