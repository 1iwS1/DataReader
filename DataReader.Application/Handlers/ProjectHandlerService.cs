using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;


namespace DataReader.Application.Handlers
{
  public class ProjectHandlerService : IProjectHandlerService
  {
    private readonly IServiceProcess<Task<Result>, ProjectsRequest> _projectsService;
    private readonly IProjectsJsonParserService _projectsJsonParserService;

    public ProjectHandlerService(
      IServiceProcess<Task<Result>, ProjectsRequest> projectsService,
      IProjectsJsonParserService projectsJsonParserService
      )
    {
      _projectsService = projectsService;
      _projectsJsonParserService = projectsJsonParserService;
    }

    public async Task<Result> Parsing(string json)
    {
      Result<List<ProjectsDTOParam>?> projects = _projectsJsonParserService.ParseProject(json);

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
      ProjectsRequest projectsRequest = new ProjectsRequest();
      projectsRequest.AddProjectRequests(projects);

      return await _projectsService.SyncProcess(projectsRequest);
      //throw new NotImplementedException();
    }
  }
}
