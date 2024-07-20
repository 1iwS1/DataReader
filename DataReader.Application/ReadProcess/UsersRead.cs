using DataReader.Core.Abstractions.Repositories;


namespace DataReader.Application.ReadProcess
{
  public class UsersRead
  {
    private readonly IUsersRepository _usersRepository;

    public UsersRead(IUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }


  }
}
