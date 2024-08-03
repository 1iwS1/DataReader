﻿using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;


namespace DataReader.Application.Services
{
  public class WorkItemsService : IServiceProcess<Task<Result>, WorkItemsRequest>
  {
    private readonly IWorkItemsRepository _workItemsRepository;

    public WorkItemsService(IWorkItemsRepository workItemsRepository)
    {
      _workItemsRepository = workItemsRepository;
    }

    public async Task<Result> SyncProcess(WorkItemsRequest workItemsRequest)
    {
      if (workItemsRequest.WorkItemsRequestCollection.Count != 0)
      {
        foreach (var request in workItemsRequest.WorkItemsRequestCollection)
        {
          Result<WorkItem> workItem = WorkItem.Create(request.shell);
          Result<bool> workItemToCompareWith = await GetWorkItem(workItem.Value.WorkItemId);

          if (workItemToCompareWith.Value)
          {
            return await UpdateWorkItem(workItem.Value.WorkItemId, workItem.Value);
          }

          else
          {
            return await CreateWorkItem(workItem.Value);
          }
        }
      }

      return new Result<WorkItem>();
    }

    private async Task<Result<bool>> GetWorkItem(int? workItemId)
    {
      return await _workItemsRepository.GetById(workItemId);
    }

    private async Task<Result> UpdateWorkItem(int? workItemId, WorkItem workItem)
    {
      return await _workItemsRepository.Update(workItemId, workItem);
    }

    private async Task<Result> CreateWorkItem(WorkItem workItem)
    {
      return await _workItemsRepository.Create(workItem);
    }
  }
}
