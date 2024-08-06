using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Models;


namespace DataReader.ExternalAPI.Controllers
{
  public class WorkItemController
  {
    private readonly IHandlerService<Task<Result>, List<WorkItemsDTOParam>> _workItemsHandler;

    public WorkItemController(IHandlerService<Task<Result>, List<WorkItemsDTOParam>> workItemsHandler)
    {
      _workItemsHandler = workItemsHandler;
    }

    public async Task<Result> GetDataByODataProtocol()
    {
      return new Result<Log>();
    }

    private async Task<Result> DoWorkItemsParsing(string json)
    {
      return new Result<Log>();
    }
  }

}
