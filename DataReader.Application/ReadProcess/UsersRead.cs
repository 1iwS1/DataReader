using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases.Users;
using DataReader.Core.Models;


namespace DataReader.Application.ReadProcess
{
  public class UsersRead : IUsersWrite
  {
    private readonly IUsersRepository _usersRepository;

    public UsersRead(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task GetUser(User user)
    {
      // вызывает метод Get из интерфейса репозитория
    }
  }
}
