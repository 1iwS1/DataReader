using DataReader.Core.Contracts;

namespace DataReader.Core.Abstractions.UseCases
{
    public interface ISync
    {
        Task Synchronisation(List<UsersRequest> requests);
    }
}