using CSharpFunctionalExtensions;

using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Abstractions.Repositories
{
  public interface IProjectsRepository
  {
    Task<Result<bool>> Create(Project project);
    Task<Result<bool>> GetById(DataReaderGuid id);
    Task<Result<bool>> Update(DataReaderGuid targetId, Project project);
  }
}
