using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases;
using DataReader.Core.Models;


namespace DataReader.Application.ReadProcess
{
  public class UsersRead : IRead
  {
    private readonly IUsersRepository _usersRepository;

    public UsersRead(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task<User> GetUser(User user)
    {
      // вызывает метод Get из интерфейса репозитория
    }
  }
}
