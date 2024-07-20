using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases.Users;
using DataReader.Core.Models;


namespace DataReader.Application.WriteProcess
{
  public class UsersWrite : IUsersWrite
  {
    private readonly IUsersRepository _usersRepository;

    public UsersWrite(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task CreateUser(User user)
    {
      // вызов Create интерфейса репозитория
    }
  }
}
