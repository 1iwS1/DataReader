using CSharpFunctionalExtensions;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Abstractions.Services
{
  public interface IUsersService
  {
    //Task<Result> CreateUser(User user);
    //Task<Result<User>> GetUser(DataReaderGuid userId);
    //Task<Result> UpdateUser(DataReaderGuid userId);
    Task<Result> SyncUser(UsersRequest userRequests);
  }
}