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
          Result<User> userCheck = await GetUser(user.Value.UserId);

          if (userCheck.Value != null)
          {
            return await UpdateUser(user.Value.UserId);
          }

          else
          {
            return await CreateUser(user.Value);
          }
        }
      }

      return new Result<User>();
    }

    public async Task<Result<User>> GetUser(DataReaderGuid userId)
    {
      return await _usersRepository.
    }

    public async Task<Result> UpdateUser(DataReaderGuid userId)
    {
      return await _usersRepository.
    }

    public async Task<Result> CreateUser(User user)
    {
      return await _usersRepository.
    }
  }
}
