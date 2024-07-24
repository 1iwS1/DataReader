using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases;
using DataReader.Core.Models;


namespace DataReader.Application.UpdateProcess
{
  public class UsersUpdate : IUpdate
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
