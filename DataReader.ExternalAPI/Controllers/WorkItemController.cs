using CSharpFunctionalExtensions;
using System.Text;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.ExternalAPI.Controllers.Common;
using DataReader.ExternalAPI.Properties;
using DataReader.Core.Contracts.Params;


namespace DataReader.ExternalAPI.Controllers
{
  public class WorkItemController
  {
    private readonly IHandlerService<Task<Result>, List<WorkItemsDTOParam>> _workItemsHandler;

    public WorkItemController(IHandlerService<Task<Result>, List<WorkItemsDTOParam>> workItemsHandler)
    {
      _workItemsHandler = workItemsHandler;
    }

    public async Task<Result> GetDataByODataProtocol(string pat, string? dateToCompareWith)
    {
      try
      {
        string result = "";
        string dataObject = "WorkItems";

        string filter = $"?$filter=ChangedDate ge {dateToCompareWith}&$orderby=WorkItemId asc&$select=";
        string withoutFilter = $"?$orderby=WorkItemId asc&$select=";

        StringBuilder query = new StringBuilder($"{dataObject}{(string.IsNullOrWhiteSpace(dateToCompareWith) ? withoutFilter : filter)}");

        foreach (string column in WorkItemsColumnsList.columns)
        {
          query.AppendLine(column + ", ");
        }

        result = await HttpSender.GetFromAzure(query.ToString(), pat);

        return await DoWorkItemsParsing(result);
      }

      catch (Exception ex)
      {
        return Result.Failure(ex.Message);
      }
    }

    private async Task<Result> DoWorkItemsParsing(string json)
    {
      return await _workItemsHandler.Parsing(json);
    }
  }

}
