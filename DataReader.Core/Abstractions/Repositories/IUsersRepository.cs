using CSharpFunctionalExtensions;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;

namespace DataReader.Core.Abstractions.Repositories
{
  public interface IUsersRepository
  {
    Task<Result> Create(User user);
    Task<Result<User>> GetById(DataReaderGuid id);
    Task<Result> Update(DataReaderGuid targetId, User user);
  }
}
