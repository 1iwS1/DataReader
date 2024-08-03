using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;


namespace DataReader.Application.Handlers
{
  public class WorkItemHandlerService : IHandlerService<Task<Result>, List<WorkItemsDTOParam>>
  {
    private readonly IServiceProcess<Task<Result>, WorkItemsRequest> _workItemsService;
    private readonly IWorkItemsJsonParserService _workItemsJsonParserService;

    public WorkItemHandlerService(
      IServiceProcess<Task<Result>, WorkItemsRequest> workItemsService,
      IWorkItemsJsonParserService workItemsJsonParserService
      )
    {
      _workItemsService = workItemsService;
      _workItemsJsonParserService = workItemsJsonParserService;
    }

    public async Task<Result> Parsing(string json)
    {
      Result<List<WorkItemsDTOParam>?> workItems = _workItemsJsonParserService.ParseWorkItem(json);

      if (workItems.IsFailure)
      {
        return workItems;
      }

      if (workItems.Value?.Count == 0)
      {
        return new Result();
      }

      return await Sync(workItems.Value!);
    }

    public async Task<Result> Sync(List<WorkItemsDTOParam> workItems)
    {
      WorkItemsRequest workItemsRequest = new();
      workItemsRequest.AddWorkItemRequests(workItems);

      return await _workItemsService.SyncProcess(workItemsRequest);
      //throw new NotImplementedException();
    }
  }
}
