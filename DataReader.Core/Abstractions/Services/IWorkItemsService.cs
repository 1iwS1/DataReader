using CSharpFunctionalExtensions;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;

namespace DataReader.Core.Abstractions.Services
{
  public interface IWorkItemsService
  {
    //Task<Result> CreateWorkItem(WorkItem workItem);
    //Task<Result<WorkItem>> GetWorkItem(int? workItemId);
    //Task<Result> UpdateWorkItem(int? workItemId);
    Task<Result> SyncWorkItem(WorkItemsRequest workItemsRequest);
  }
}