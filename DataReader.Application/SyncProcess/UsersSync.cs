using DataReader.Core.Abstractions.UseCases.Users;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync
  {
    private readonly IUsersWrite _usersRead;

    public UsersSync(IUsersWrite usersRead)
    {
      _usersRead = usersRead;
    }


  }
}
