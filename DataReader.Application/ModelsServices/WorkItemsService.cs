using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Application.Services
{
  public class WorkItemsService : IWorkItemsService
  {
    private readonly IWorkItemsRepository _workItemsRepository;

    public WorkItemsService(IWorkItemsRepository workItemsRepository)
    {
      _workItemsRepository = workItemsRepository;
    }

    public async Task<Result> SyncWorkItem(WorkItemsRequest workItemsRequest)
    {
      if (workItemsRequest.WorkItemsRequestCollection.Count != 0)
      {
        foreach (var request in workItemsRequest.WorkItemsRequestCollection)
        {
          Result<WorkItem> workItem = WorkItem.Create(request.shell);
          //Result<WorkItem> workItemCheck = await GetWorkItem(workItem.Value.WorkItemId);

          //if (workItemCheck.Value != null)
          //{
          //  return await UpdateWorkItem(workItem.Value.WorkItemId);
          //}

          //else
          //{
          //  return await CreateWorkItem(workItem.Value);
          //}
        }
      }

      return new Result<WorkItem>();
    }

    //public async Task<Result<WorkItem>> GetWorkItem(int? workItemId)
    //{
    //  return await _workItemsRepository.
    //}

    //public async Task<Result> UpdateWorkItem(int? workItemId)
    //{
    //  return await _workItemsRepository.
    //}

    //public async Task<Result> CreateWorkItem(WorkItem workItem)
    //{
    //  return await _workItemsRepository.
    //}
  }
}
