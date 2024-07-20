using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases.Users;


namespace DataReader.Application.ReadProcess
{
  public class UsersRead : IUsersWrite
  {
    private readonly IUsersRepository _usersRepository;

    public UsersRead(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }


  }
}
