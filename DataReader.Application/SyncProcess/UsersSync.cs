using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.UseCases;
using DataReader.Core.Contracts;
using DataReader.Core.Models;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync : ISync
  {
    private readonly IRead _read;
    private readonly IWrite _write;
    private readonly IUpdate _update;

    public UsersSync(IRead read, IWrite write, IUpdate update)
    {
      _read = read;
      _write = write;
      _update = update;
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
