using CSharpFunctionalExtensions;
using System.Text;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.ExternalAPI.Controllers.Common;
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

        result = await HttpSender.GetFromAzure(query.ToString(), pat);

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
