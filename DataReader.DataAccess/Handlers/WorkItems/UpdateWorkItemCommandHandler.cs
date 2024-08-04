using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.WorkItems;


namespace DataReader.DataAccess.Handlers.WorkItems
{
    public class UpdateWorkItemCommandHandler : ICommandHandler<Task<Result<bool>>, UpdateWorkItemCommand>
    {
        private readonly DataDbContext _dbContext;

        public UpdateWorkItemCommandHandler(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<bool>> Handle(UpdateWorkItemCommand command)
        {
            await _dbContext.WorkItems
              .Where(w => w.WorkItemId == command.targetId)
              .ExecuteUpdateAsync(u => u
                .SetProperty(x => x.InProgressDate, x => command.workItem.InProgressDate)
                .SetProperty(x => x.CompletedDate, x => command.workItem.CompletedDate)
                .SetProperty(x => x.InProgressDateSK, x => command.workItem.InProgressDateSK)
                .SetProperty(x => x.CompletedDateSK, x => command.workItem.CompletedDateSK)
                .SetProperty(x => x.AnalyticsUpdatedDate, x => command.workItem.AnalyticsUpdatedDate)
                .SetProperty(x => x.WorkItemRevisionSK, x => command.workItem.WorkItemRevisionSK)
                .SetProperty(x => x.AreaSK, x => command.workItem.AreaSK)
                .SetProperty(x => x.IterationSK, x => command.workItem.IterationSK)
                .SetProperty(x => x.ActivatedDateSK, x => command.workItem.ActivatedDateSK)
                .SetProperty(x => x.ChangedDateSK, x => command.workItem.ChangedDateSK)
                .SetProperty(x => x.ClosedDateSK, x => command.workItem.ClosedDateSK)
                .SetProperty(x => x.CreatedDateSK, x => command.workItem.CreatedDateSK)
                .SetProperty(x => x.ResolvedDateSK, x => command.workItem.ResolvedDateSK)
                .SetProperty(x => x.StateChangeDateSK, x => command.workItem.StateChangeDateSK)
                .SetProperty(x => x.WorkItemType, x => command.workItem.WorkItemType)
                .SetProperty(x => x.ChangedDate, x => command.workItem.ChangedDate)
                .SetProperty(x => x.CreatedDate, x => command.workItem.CreatedDate)
                .SetProperty(x => x.State, x => command.workItem.State)
                .SetProperty(x => x.ActivatedDate, x => command.workItem.ActivatedDate)
                .SetProperty(x => x.ClosedDate, x => command.workItem.ClosedDate)
                .SetProperty(x => x.Priority, x => command.workItem.Priority)
                .SetProperty(x => x.ResolvedDate, x => command.workItem.ResolvedDate)
                .SetProperty(x => x.CompletedWork, x => command.workItem.CompletedWork)
                .SetProperty(x => x.Effort, x => command.workItem.Effort)
                .SetProperty(x => x.FinishDate, x => command.workItem.FinishDate)
                .SetProperty(x => x.OriginalEstimate, x => command.workItem.OriginalEstimate)
                .SetProperty(x => x.RemainingWork, x => command.workItem.RemainingWork)
                .SetProperty(x => x.StartDate, x => command.workItem.StartDate)
                .SetProperty(x => x.StoryPoints, x => command.workItem.StoryPoints)
                .SetProperty(x => x.TargetDate, x => command.workItem.TargetDate)
                .SetProperty(x => x.ParentWorkItemId, x => command.workItem.ParentWorkItemId)
                .SetProperty(x => x.TagNames, x => command.workItem.TagNames)
                .SetProperty(x => x.StateChangeDate, x => command.workItem.StateChangeDate)
                .SetProperty(x => x.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
                  x => command.workItem.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3)
                .SetProperty(x => x.Custom_Company, x => command.workItem.Custom_Company)
                .SetProperty(x => x.Custom_Eksternareferenca, x => command.workItem.Custom_Eksternareferenca)
                .SetProperty(x => x.Custom_ITServiceorApplication, x => command.workItem.Custom_ITServiceorApplication)
                .SetProperty(x => x.Custom_Statusprojekta, x => command.workItem.Custom_Statusprojekta)
                .SetProperty(x => x.Custom_TicketNo, x => command.workItem.Custom_TicketNo)
                .SetProperty(x => x.AssignedToUserSK, x => command.workItem.AssignedToUserSK)
                .SetProperty(x => x.ChangedByUserSK, x => command.workItem.ChangedByUserSK)
                .SetProperty(x => x.CreatedByUserSK, x => command.workItem.CreatedByUserSK)
                .SetProperty(x => x.ActivatedByUserSK, x => command.workItem.ActivatedByUserSK)
                .SetProperty(x => x.ClosedByUserSK, x => command.workItem.ClosedByUserSK)
                .SetProperty(x => x.ResolvedByUserSK, x => command.workItem.ResolvedByUserSK)
                .SetProperty(x => x.ProjectSK, x => command.workItem.ProjectSK)
                );

            return true;
        }
    }
}
