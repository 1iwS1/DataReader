using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases.Users;


namespace DataReader.Application.WriteProcess
{
  public class UsersWrite : IUsersWrite
  {
    private readonly IUsersRepository _usersRepository;

    public UsersWrite(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }


  }
}
