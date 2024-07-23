using DataReader.Core.Contracts.Users;


namespace DataReader.Application.SyncProcess
{
  public interface ISync
  {
    Task Synchronisation(List<UsersRequest>  requests);
  }
}