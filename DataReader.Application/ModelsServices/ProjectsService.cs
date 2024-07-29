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
          //Result<Project> projectCheck = await GetProject(project.Value.ProjectID);

          //if (projectCheck.Value != null)
          //{
          //  return await UpdateProject(project.Value.ProjectID);
          //}

          //else
          //{
          //  return await CreateProject(project.Value);
          //}
        }
      }

      return new Result<Project>();
    }

    //public async Task<Result<Project>> GetProject(DataReaderGuid projectId)
    //{
    //  return await _usersRepository.
    //}

    //public async Task<Result> UpdateProject(DataReaderGuid projectId)
    //{
    //  return await _usersRepository.
    //}

    //public async Task<Result> CreateProject(Project user)
    //{
    //  return await _usersRepository.
    //}
  }
}
