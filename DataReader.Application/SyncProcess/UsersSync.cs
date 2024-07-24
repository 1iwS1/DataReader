using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.UseCases;
using DataReader.Core.Contracts;
using DataReader.Core.Models;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync : ISync
  {


    public UsersSync()
    {

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
