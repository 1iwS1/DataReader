using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Application.ModelsServices
{
  public class UsersService : IUsersService
  {
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task<Result> SyncUser(UsersRequest userRequests)
    {
      if (userRequests.UsersRequestCollection.Count != 0)
      {
        foreach (var request in userRequests.UsersRequestCollection)
        {
          Result<User> user = User.Create(request.shell);
          Result<User> userToCompareWith = await GetUser(user.Value.UserId);

          if (userToCompareWith.IsFailure)
          {
            return await CreateUser(user.Value);
          }

          else
          {
            return await UpdateUser(user.Value.UserId, user.Value);
          }
        }
      }

      return new Result<User>();
    }

    public async Task<Result<User>> GetUser(DataReaderGuid userId)
    {
      return await _usersRepository.GetById(userId);
    }

    public async Task<Result> UpdateUser(DataReaderGuid userId, User user)
    {
      return await _usersRepository.Update(userId, user);
    }

    public async Task<Result> CreateUser(User user)
    {
      return await _usersRepository.Create(user);
    }
  }
}
