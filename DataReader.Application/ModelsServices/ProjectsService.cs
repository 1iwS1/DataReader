using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Application.Services
{
  public class ProjectsService : IServiceProcess<Task<Result>, ProjectsRequest>
  {
    private readonly IProjectsRepository _projectsRepository;

    public ProjectsService(IProjectsRepository projectsRepository)
    {
      _projectsRepository = projectsRepository;
    }

    public async Task<Result> SyncProcess(ProjectsRequest projectsRequest)
    {
      if (projectsRequest.ProjectsRequestCollection.Count != 0)
      {
        foreach (var request in projectsRequest.ProjectsRequestCollection)
        {
          Result<Project> project = Project.Create(request.shell);
          Result<bool> projectToCompareWith = await GetProject(project.Value.ProjectID);

          if (projectToCompareWith.Value)
          {
            await UpdateProject(project.Value.ProjectID, project.Value);
          }

          else
          {
            await CreateProject(project.Value);
          }
        }
      }

      return Result.Success();
    }

    private async Task<Result<bool>> GetProject(DataReaderGuid projectId)
    {
      return await _projectsRepository.GetById(projectId);
    }

    private async Task<Result<bool>> CreateProject(Project user)
    {
      return await _projectsRepository.Create(user);
    }

    private async Task<Result<bool>> UpdateProject(DataReaderGuid projectId, Project project)
    {
      return await _projectsRepository.Update(projectId, project);
    }
  }
}
