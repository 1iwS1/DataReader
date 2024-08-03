using CSharpFunctionalExtensions;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;

namespace DataReader.Core.Abstractions.Services
{
  public interface IWorkItemsService
  {
    Task<Result> SyncWorkItem(WorkItemsRequest workItemsRequest);
  }
}