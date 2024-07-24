using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.UseCases;
using DataReader.Core.Contracts;
using DataReader.Core.Models;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync : ISync
  {
    private readonly IRead _usersRead;
    private readonly IWrite _usersWrite;
    private readonly IUpdate _usersUpdate;

    public UsersSync(IRead usersRead, IWrite usersWrite, IUpdate usersUpdate)
    {
      _usersRead = usersRead;
      _usersWrite = usersWrite;
      _usersUpdate = usersUpdate;
    }

    public async Task Synchronisation(ContractsWrapper requests)
    {
      foreach (var request in requests.UsersRequestCollection)
      {
        Result<User> user = User.Create(request.shell);
      }
    }
  }
}
