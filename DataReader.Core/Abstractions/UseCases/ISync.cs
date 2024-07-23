using DataReader.Core.Contracts.Users;


namespace DataReader.Core.Abstractions.UseCases
{
    public interface ISync
    {
        Task Synchronisation(List<UsersRequest> requests);
    }
}