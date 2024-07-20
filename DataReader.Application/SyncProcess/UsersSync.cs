using DataReader.Core.Abstractions.UseCases;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync
  {
    private readonly IUsersRead _usersRead;

    public UsersSync(IUsersRead usersRead)
    {
      _usersRead = usersRead;
    }


  }
}
