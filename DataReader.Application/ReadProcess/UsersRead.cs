using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases.Users;


namespace DataReader.Application.ReadProcess
{
    public class UsersRead : IUsersRead
  {
    private readonly IUsersRepository _usersRepository;

    public UsersRead(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }


  }
}
