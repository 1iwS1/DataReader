using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Models;


namespace DataReader.ExternalAPI.Controllers
{
  public class ProjectController
  {
    private readonly IHandlerService<Task<Result>, List<ProjectsDTOParam>> _projectsHandler;

    public ProjectController(IHandlerService<Task<Result>, List<ProjectsDTOParam>> projectsHandler)
    {
      _projectsHandler = projectsHandler;
    }

    public async Task<Result> GetDataByODataProtocol()
    {
      return new Result<Log>();
    }

    private async Task<Result> DoProjectsParsing(string json)
    {
      return new Result<Log>();
    }
  }
}
