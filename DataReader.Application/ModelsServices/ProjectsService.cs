using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Application.Services
{
  public class ProjectsService : IProjectsService
  {
    private readonly IProjectsRepository _projectsRepository;

    public ProjectsService(IProjectsRepository projectsRepository)
    {
      _projectsRepository = projectsRepository;
    }

    public async Task<Result> SyncProject(ProjectsRequest projectsRequest)
    {
      if (projectsRequest.ProjectsRequestCollection.Count != 0)
      {
        foreach (var request in projectsRequest.ProjectsRequestCollection)
        {
          Result<Project> project = Project.Create(request.shell);
          Result<Project> projectToCompareWith = await GetProject(project.Value.ProjectID);

          if (projectToCompareWith.IsFailure)
          {
            return await CreateProject(project.Value);
          }

          else
          {
            return await UpdateProject(project.Value.ProjectID, project.Value);
          }
        }
      }

      return new Result<Project>();
    }

    public async Task<Result<Project>> GetProject(DataReaderGuid projectId)
    {
      return await _projectsRepository.GetById(projectId);
    }

    public async Task<Result> CreateProject(Project user)
    {
      return await _projectsRepository.Create(user);
    }

    public async Task<Result> UpdateProject(DataReaderGuid projectId, Project project)
    {
      return await _projectsRepository.Update(projectId, project);
    }
  }
}
