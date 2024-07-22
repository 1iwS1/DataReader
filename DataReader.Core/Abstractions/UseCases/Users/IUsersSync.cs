using DataReader.Core.Contracts.Users;

namespace DataReader.Application.SyncProcess
{
  public interface IUsersSync
  {
    Task Synchronisation(List<UsersRequest> requests);
  }
}