using CSharpFunctionalExtensions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Contracts.Params;
using DataReader.ExternalAPI.Properties;


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

        string link = $"https://analytics.dev.azure.com/KAPPASTAR-IT/_odata/v3.0/" + query;

        using (HttpClient client = new HttpClient())
        {
          client.DefaultRequestHeaders.Accept.Add(
             new MediaTypeWithQualityHeaderValue("application/json"));

          client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
              Convert.ToBase64String(
                  ASCIIEncoding.ASCII.GetBytes(
                      string.Format("{0}:{1}", "", pat))));

          using (HttpResponseMessage response = client.GetAsync(link).Result)
          {
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            result = JToken.Parse(responseBody).ToString(Formatting.Indented);

            //Console.WriteLine(result);
          }
        }

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
