using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;


namespace DataReader.Application.Handlers
{
  public class WorkItemHandlerService : IWorkItemHandlerService
  {
    private readonly IWorkItemsService _workItemsService;
    private readonly IWorkItemsJsonParserService _workItemsJsonParserService;

    public WorkItemHandlerService(
      //IWorkItemsService workItemsService,
      IWorkItemsJsonParserService workItemsJsonParserService
      )
    {
      //_workItemsService = workItemsService;
      _workItemsJsonParserService = workItemsJsonParserService;
    }

    public async Task<Result> Parsing(string json)
    {
      Result<List<WorkItemsDTOParam>?> workItems = _workItemsJsonParserService.ParseWorkItem(json);

      if (workItems.IsFailure)
      {
        return workItems;
      }

      return await Sync(workItems.Value);
    }

    public async Task<Result> Sync(List<WorkItemsDTOParam>? workItems)
    {
      WorkItemsRequest workItemsRequest = new();
      workItemsRequest.AddWorkItemRequests(workItems);

      //return await _workItemsService.SyncWorkItem(workItemsRequest);
      throw new NotImplementedException();
    }
  }
}
