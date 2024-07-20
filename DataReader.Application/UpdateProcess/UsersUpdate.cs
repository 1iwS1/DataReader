using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.UseCases.Users;
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


  }
}
