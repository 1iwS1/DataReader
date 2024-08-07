using CSharpFunctionalExtensions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Contracts.Params;


namespace DataReader.ExternalAPI.Controllers
{
  public class UserController
  {
    private readonly IHandlerService<Task<Result>, List<UsersDTOParam>> _usersHandler;

    public UserController(IHandlerService<Task<Result>, List<UsersDTOParam>> usersHandler)
    {
      _usersHandler = usersHandler;
    }

    public async Task<Result> GetDataByODataProtocol(string pat)
    {
      try
      {
        string result = "";
        string dataObject = "Users";
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

        return await DoUsersParsing(result);
      }

      catch (Exception ex)
      {
        return Result.Failure(ex.Message);
      } 
    }

    private async Task<Result> DoUsersParsing(string json)
    {
      return await _usersHandler.Parsing(json);
    }
  }
}
