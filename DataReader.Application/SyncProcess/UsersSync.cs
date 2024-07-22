using DataReader.Core.Contracts.Users;
using DataReader.Core.Abstractions.UseCases.Users;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync : IUsersSync
  {
    private readonly IUsersRead _usersRead;
    private readonly IUsersWrite _usersWrite;
    private readonly IUsersUpdate _usersUpdate;

    public UsersSync(IUsersRead usersRead, IUsersWrite usersWrite, IUsersUpdate usersUpdate)
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
