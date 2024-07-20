using DataReader.Application.Contracts.Users;
using DataReader.Core.Abstractions.UseCases.Users;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync
  {
    private readonly IUsersWrite _usersRead;
    private readonly IUsersWrite _usersWrite;
    private readonly IUsersUpdate _usersUpdate;

    public UsersSync(IUsersWrite usersRead, IUsersWrite usersWrite, IUsersUpdate usersUpdate)
    {
      _usersRead = usersRead;
      _usersWrite = usersWrite;
      _usersUpdate = usersUpdate;
    }

    public async Task Synchronisation(List<UsersRequest> requests)
    {

    }
  }
}
