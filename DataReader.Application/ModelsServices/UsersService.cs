using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts;
using DataReader.Core.Models;


namespace DataReader.Application.Services
{
  public class UsersService : IUsersService
  {
    private readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task SyncUser(UsersRequest request)
    {

    }

    public async Task<User> GetUser(User user)
    {

    }

    public async Task UpdateUser(User user)
    {

    }

    public async Task CreateUser(User user)
    {

    }
  }
}
