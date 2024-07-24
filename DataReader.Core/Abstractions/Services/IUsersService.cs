using DataReader.Core.Contracts;
using DataReader.Core.Models;


namespace DataReader.Core.Abstractions.Services
{
  public interface IUsersService
  {
    Task CreateUser(User user);
    Task<User> GetUser(User user);
    Task SyncUser(UsersRequest request);
    Task UpdateUser(User user);
  }
}