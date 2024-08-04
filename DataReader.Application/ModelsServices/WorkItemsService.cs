using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.Commands.WorkItems;
using DataReader.Core.Queries.WorkItems;


namespace DataReader.Application.Services
{
    public class WorkItemsService : IServiceProcess<Task<Result>, WorkItemsRequest>
  {
    private readonly ICommandHandler<Task<Result<bool>>, CreateWorkItemCommand> _createCommandHandler;
    private readonly ICommandHandler<Task<Result<bool>>, UpdateWorkItemCommand> _updateCommandHandler;

    private readonly IQueryHandler<Task<Result<bool>>, GetByIdWorkItemQuery> _getByIdQueryHandler;

    public WorkItemsService(
      ICommandHandler<Task<Result<bool>>, CreateWorkItemCommand> createCommandHandler,
      ICommandHandler<Task<Result<bool>>, UpdateWorkItemCommand> updateCommandHandler,
      IQueryHandler<Task<Result<bool>>, GetByIdWorkItemQuery> getByIdQueryHandler
      )
    {
      _createCommandHandler = createCommandHandler;
      _updateCommandHandler = updateCommandHandler;
      _getByIdQueryHandler = getByIdQueryHandler;
    }

    public async Task<Result> SyncProcess(WorkItemsRequest workItemsRequest)
    {
      foreach (var request in workItemsRequest.WorkItemsRequestCollection)
      {
        Result<WorkItem> workItem = WorkItem.Create(request.shell);
        Result<bool> workItemToCompareWith = await GetWorkItem(new() { id = workItem.Value.WorkItemId });


        if (workItemToCompareWith.Value)
        {
          UpdateWorkItemCommand updateCommand = new()
          {
            targetId = workItem.Value.WorkItemId,
            workItem = workItem.Value
          };

          await UpdateWorkItem(updateCommand);
        }

        else
        {
          CreateWorkItemCommand createCommand = new() { workItem = workItem.Value };
          await CreateWorkItem(createCommand);
        }
      }

      return Result.Success();
    }

    private async Task<Result<bool>> GetWorkItem(GetByIdWorkItemQuery command)
    {
      return await _getByIdQueryHandler.Handle(command);
    }

    private async Task<Result<bool>> UpdateWorkItem(UpdateWorkItemCommand command)
    {
      return await _updateCommandHandler.Handle(command);
    }

    private async Task<Result<bool>> CreateWorkItem(CreateWorkItemCommand command)
    {
      return await _createCommandHandler.Handle(command);
    }
  }
}
