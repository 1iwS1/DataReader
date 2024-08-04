using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Commands.Projects;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.Queries.Projects;


namespace DataReader.Application.Services
{
  public class ProjectsService : IServiceProcess<Task<Result>, ProjectsRequest>
  {
    private readonly IQueryHandler<Task<Result<bool>>, GetByIdProjectQuery> _getByIdQueryHandler;
    private readonly ICommandHandler<Task<Result<bool>>, CreateProjectCommand> _createCommandHandler;
    private readonly ICommandHandler<Task<Result<bool>>, UpdateProjectCommand> _updateCommandHandler;

    public ProjectsService(
      IQueryHandler<Task<Result<bool>>, GetByIdProjectQuery> getByIdQueryHandler,
      ICommandHandler<Task<Result<bool>>, CreateProjectCommand> createCommandHandler,
      ICommandHandler<Task<Result<bool>>, UpdateProjectCommand> updateCommandHandler
      )
    {
      _getByIdQueryHandler = getByIdQueryHandler;
      _createCommandHandler = createCommandHandler;
      _updateCommandHandler = updateCommandHandler;
    }

    public async Task<Result> SyncProcess(ProjectsRequest projectsRequest)
    {
      if (projectsRequest.ProjectsRequestCollection.Count != 0)
      {
        foreach (var request in projectsRequest.ProjectsRequestCollection)
        {
          Result<Project> project = Project.Create(request.shell);
          Result<bool> projectToCompareWith = await GetProject(new() { id = project.Value.ProjectID });

          if (projectToCompareWith.Value)
          {
            UpdateProjectCommand updateCommand = new()
            {
              targetId = project.Value.ProjectID,
              project = project.Value
            };

            await UpdateProject(updateCommand);
          }

          else
          {
            CreateProjectCommand createCommand = new() { project = project.Value };
            await CreateProject(createCommand);
          }
        }
      }

      return Result.Success();
    }

    private async Task<Result<bool>> GetProject(GetByIdProjectQuery query)
    {
      return await _getByIdQueryHandler.Handle(query);
    }

    private async Task<Result<bool>> CreateProject(CreateProjectCommand command)
    {
      return await _createCommandHandler.Handle(command);
    }

    private async Task<Result<bool>> UpdateProject(UpdateProjectCommand command)
    {
      return await _updateCommandHandler.Handle(command);
    }
  }
}
