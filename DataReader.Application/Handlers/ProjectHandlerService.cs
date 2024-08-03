using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;


namespace DataReader.Application.Handlers
{
  public class ProjectHandlerService : IHandlerService<Task<Result>, List<ProjectsDTOParam>>
  {
    private readonly IServiceProcess<Task<Result>, ProjectsRequest> _projectsService;
    private readonly IJsonParserService<Result<List<ProjectsDTOParam>?>> _projectsJsonParserService;

    public ProjectHandlerService(
      IServiceProcess<Task<Result>, ProjectsRequest> projectsService,
      IJsonParserService<Result<List<ProjectsDTOParam>?>> projectsJsonParserService
      )
    {
      _projectsService = projectsService;
      _projectsJsonParserService = projectsJsonParserService;
    }

    public async Task<Result> Parsing(string json)
    {
      Result<List<ProjectsDTOParam>?> projects = _projectsJsonParserService.Parse(json);

      if (projects.IsFailure)
      {
        return projects;
      }

      if (projects.Value?.Count == 0)
      {
        return new Result();
      }

      return await Sync(projects.Value!);
    }

    public async Task<Result> Sync(List<ProjectsDTOParam> projects)
    {
      ProjectsRequest projectsRequest = new();
      projectsRequest.AddProjectRequests(projects);

      return await _projectsService.SyncProcess(projectsRequest);
      //throw new NotImplementedException();
    }
  }
}
