
using CSharpFunctionalExtensions;
using DataReader.Core.Models;

namespace DataReader.Core.Abstractions.Repositories
{
  public interface IWorkItemsRepository
  {
    Task<Result<bool>> Create(WorkItem workItem);
    Task<Result<bool>> GetById(int? id);
    Task<Result<bool>> Update(int? targetId, WorkItem workItem);
  }
}
