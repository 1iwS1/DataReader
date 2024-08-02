using CSharpFunctionalExtensions;

using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Abstractions.Repositories
{
  public interface IProjectsRepository
  {
    Task<Result> Create(Project project);
    Task<Result<Project>> GetById(DataReaderGuid id);
    Task<Result> Update(DataReaderGuid targetId, Project project);
  }
}
