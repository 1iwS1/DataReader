using CSharpFunctionalExtensions;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;

namespace DataReader.Core.Abstractions.Repositories
{
  public interface IUsersRepository
  {
    Task<Result<bool>> Create(User user);
    Task<Result<bool>> GetById(DataReaderGuid id);
    Task<Result<bool>> Update(DataReaderGuid targetId, User user);
  }
}
