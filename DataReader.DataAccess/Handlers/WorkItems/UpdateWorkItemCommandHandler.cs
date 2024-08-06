using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.WorkItems;


namespace DataReader.DataAccess.Handlers.WorkItems
{
    public class UpdateWorkItemCommandHandler : ICommandHandler<Task<Result<bool>>, UpdateWorkItemCommand>
    {
        private readonly DataAzureContext _dbContext;

        public UpdateWorkItemCommandHandler(DataAzureContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<bool>> Handle(UpdateWorkItemCommand command)
        {
            await _dbContext.WorkItems
              .Where(w => w.WorkItemId == command.targetId)
              .ExecuteUpdateAsync(u => u
                .SetProperty(x => x.InProgressDate, x => command.workItem.InProgressDate.Date)
                .SetProperty(x => x.CompletedDate, x => command.workItem.CompletedDate.Date)
                .SetProperty(x => x.InProgressDateSk, x => command.workItem.InProgressDateSK)
                .SetProperty(x => x.CompletedDateSk, x => command.workItem.CompletedDateSK)
                .SetProperty(x => x.AnalyticsUpdatedDate, x => command.workItem.AnalyticsUpdatedDate.Date)
                .SetProperty(x => x.WorkItemRevisionSk, x => command.workItem.WorkItemRevisionSK)
                .SetProperty(x => x.AreaSk, x => command.workItem.AreaSK.CustomGuid)
                .SetProperty(x => x.IterationSk, x => command.workItem.IterationSK.CustomGuid)
                .SetProperty(x => x.ActivatedDateSk, x => command.workItem.ActivatedDateSK)
                .SetProperty(x => x.ChangedDateSk, x => command.workItem.ChangedDateSK)
                .SetProperty(x => x.ClosedDateSk, x => command.workItem.ClosedDateSK)
                .SetProperty(x => x.CreatedDateSk, x => command.workItem.CreatedDateSK)
                .SetProperty(x => x.ResolvedDateSk, x => command.workItem.ResolvedDateSK)
                .SetProperty(x => x.StateChangeDateSk, x => command.workItem.StateChangeDateSK)
                .SetProperty(x => x.WorkItemType, x => command.workItem.WorkItemType)
                .SetProperty(x => x.ChangedDate, x => command.workItem.ChangedDate.Date)
                .SetProperty(x => x.CreatedDate, x => command.workItem.CreatedDate.Date)
                .SetProperty(x => x.State, x => command.workItem.State)
                .SetProperty(x => x.ActivatedDate, x => command.workItem.ActivatedDate.Date)
                .SetProperty(x => x.ClosedDate, x => command.workItem.ClosedDate.Date)
                .SetProperty(x => x.Priority, x => command.workItem.Priority)
                .SetProperty(x => x.ResolvedDate, x => command.workItem.ResolvedDate.Date)
                .SetProperty(x => x.CompletedWork, x => (decimal?)command.workItem.CompletedWork)
                .SetProperty(x => x.Effort, x => command.workItem.Effort)
                .SetProperty(x => x.FinishDate, x => command.workItem.FinishDate.Date)
                .SetProperty(x => x.OriginalEstimate, x => command.workItem.OriginalEstimate)
                .SetProperty(x => x.RemainingWork, x => command.workItem.RemainingWork)
                .SetProperty(x => x.StartDate, x => command.workItem.StartDate)
                .SetProperty(x => x.StoryPoints, x => command.workItem.StoryPoints)
                .SetProperty(x => x.TargetDate, x => command.workItem.TargetDate)
                .SetProperty(x => x.ParentWorkItemId, x => command.workItem.ParentWorkItemId)
                .SetProperty(x => x.TagNames, x => command.workItem.TagNames)
                .SetProperty(x => x.StateChangeDate, x => command.workItem.StateChangeDate.Date)
                .SetProperty(x => x.Custom719f69f1002df7d0002d4baa002db6ce002de77ad5dfcdf3,
                  x => command.workItem.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3)
                .SetProperty(x => x.CustomCompany, x => command.workItem.Custom_Company)
                .SetProperty(x => x.CustomEksternareferenca, x => command.workItem.Custom_Eksternareferenca)
                .SetProperty(x => x.CustomItserviceorApplication, x => command.workItem.Custom_ITServiceorApplication)
                .SetProperty(x => x.CustomStatusprojekta, x => command.workItem.Custom_Statusprojekta)
                .SetProperty(x => x.CustomTicketNo, x => command.workItem.Custom_TicketNo)
                .SetProperty(x => x.AssignedToUserSk, x => command.workItem.AssignedToUserSK.CustomGuid)
                .SetProperty(x => x.ChangedByUserSk, x => command.workItem.ChangedByUserSK.CustomGuid)
                .SetProperty(x => x.CreatedByUserSk, x => command.workItem.CreatedByUserSK.CustomGuid)
                .SetProperty(x => x.ActivatedByUserSk, x => command.workItem.ActivatedByUserSK.CustomGuid)
                .SetProperty(x => x.ClosedByUserSk, x => command.workItem.ClosedByUserSK.CustomGuid)
                .SetProperty(x => x.ResolvedByUserSk, x => command.workItem.ResolvedByUserSK.CustomGuid)
                .SetProperty(x => x.ProjectSk, x => command.workItem.ProjectSK.CustomGuid)
                );

            return true;
        }
    }
}
