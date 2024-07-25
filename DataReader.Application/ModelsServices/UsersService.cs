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

    public async Task SyncUser(UsersRequest userRequests)
    {
      foreach (var request in userRequests.UsersRequestCollection)
      {
        Result<User> user = User.Create(request.shell);
        //User userCheck = await GetUser(user.Value.UserId);

        //if (userCheck != null)
        //{
        //  await UpdateUser(user.Value);
        //}

        //else
        //{
        //  await CreateUser(user.Value);
        //}
      }
    }

    //public async Task<User> GetUser(string userId)
    //{
    //  return await _usersRepository.
    //}

    //public async Task UpdateUser(User user)
    //{
    //  await _usersRepository.
    //}

    //public async Task CreateUser(User user)
    //{
    //  await _usersRepository.
    //}
  }
}
