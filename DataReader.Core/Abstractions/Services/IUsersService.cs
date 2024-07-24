using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Abstractions.Services
{
    public interface IUsersService
  {
    Task CreateUser(User user);
    Task<User> GetUser(DataReaderGuid user);
    Task SyncUser(UsersRequest request);
    Task UpdateUser(User user);
  }
}