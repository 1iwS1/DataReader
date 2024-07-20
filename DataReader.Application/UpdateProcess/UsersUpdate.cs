using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases.Users;
using DataReader.Core.Models;
using System.Net.NetworkInformation;


namespace DataReader.Application.UpdateProcess
{
  public class UsersUpdate : IUsersUpdate
  {
    private readonly IUsersRepository _usersRepository;

    public UsersUpdate(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task UpdateUser(User user)
    {
      // вызов Update интерфейса репозитория
    }
  }
}
