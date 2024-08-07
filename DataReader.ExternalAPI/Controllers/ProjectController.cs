using CSharpFunctionalExtensions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Contracts.Params;


namespace DataReader.ExternalAPI.Controllers
{
  public class ProjectController
  {
    private readonly IHandlerService<Task<Result>, List<ProjectsDTOParam>> _projectsHandler;

    public ProjectController(IHandlerService<Task<Result>, List<ProjectsDTOParam>> projectsHandler)
    {
      _projectsHandler = projectsHandler;
    }

    public async Task<Result> GetDataByODataProtocol(string pat)
    {
      try
      {
        string result = "";
        string dataObject = "Projects";
        string filter = "?$select=*";
        StringBuilder query = new StringBuilder($"{dataObject}{filter}");

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

            Console.WriteLine(result);
          }
        }

        return await DoProjectsParsing(result);
      }

      catch (Exception ex)
      {
        return Result.Failure(ex.Message);
      }
    }

    private async Task<Result> DoProjectsParsing(string json)
    {
      return await _projectsHandler.Parsing(json);
    }
  }
}
