using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.DataAccess.BaseModels;
using DataReader.Core.Commands.WorkItems;


namespace DataReader.DataAccess.Handlers.WorkItems
{
    public class CreateWorkItemCommandHandler : ICommandHandler<Task<Result<bool>>, CreateWorkItemCommand>
    {
        private readonly DataDbContext _dbContext;

        public CreateWorkItemCommandHandler(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<bool>> Handle(CreateWorkItemCommand command)
        {
            var workItemBase = new WorkItemBase
            {
                WorkItemId = command.workItem.WorkItemId,
                InProgressDate = command.workItem.InProgressDate,
                CompletedDate = command.workItem.CompletedDate,
                InProgressDateSK = command.workItem.InProgressDateSK,
                CompletedDateSK = command.workItem.CompletedDateSK,
                AnalyticsUpdatedDate = command.workItem.AnalyticsUpdatedDate,
                WorkItemRevisionSK = command.workItem.WorkItemRevisionSK,
                AreaSK = command.workItem.AreaSK,
                IterationSK = command.workItem.IterationSK,
                ActivatedDateSK = command.workItem.ActivatedDateSK,
                ChangedDateSK = command.workItem.ChangedDateSK,
                ClosedDateSK = command.workItem.ClosedDateSK,
                CreatedDateSK = command.workItem.CreatedDateSK,
                ResolvedDateSK = command.workItem.ResolvedDateSK,
                StateChangeDateSK = command.workItem.StateChangeDateSK,
                WorkItemType = command.workItem.WorkItemType,
                ChangedDate = command.workItem.ChangedDate,
                CreatedDate = command.workItem.CreatedDate,
                State = command.workItem.State,
                ActivatedDate = command.workItem.ActivatedDate,
                ClosedDate = command.workItem.ClosedDate,
                Priority = command.workItem.Priority,
                ResolvedDate = command.workItem.ResolvedDate,
                CompletedWork = command.workItem.CompletedWork,
                Effort = command.workItem.Effort,
                FinishDate = command.workItem.FinishDate,
                OriginalEstimate = command.workItem.OriginalEstimate,
                RemainingWork = command.workItem.RemainingWork,
                StartDate = command.workItem.StartDate,
                StoryPoints = command.workItem.StoryPoints,
                TargetDate = command.workItem.TargetDate,
                ParentWorkItemId = command.workItem.ParentWorkItemId,
                TagNames = command.workItem.TagNames,
                StateChangeDate = command.workItem.StateChangeDate,
                Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 =
                command.workItem.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
                Custom_Company = command.workItem.Custom_Company,
                Custom_Eksternareferenca = command.workItem.Custom_Eksternareferenca,
                Custom_ITServiceorApplication = command.workItem.Custom_ITServiceorApplication,
                Custom_Statusprojekta = command.workItem.Custom_Statusprojekta,
                Custom_TicketNo = command.workItem.Custom_TicketNo,
                AssignedToUserSK = command.workItem.AssignedToUserSK,
                ChangedByUserSK = command.workItem.ChangedByUserSK,
                CreatedByUserSK = command.workItem.CreatedByUserSK,
                ActivatedByUserSK = command.workItem.ActivatedByUserSK,
                ClosedByUserSK = command.workItem.ClosedByUserSK,
                ResolvedByUserSK = command.workItem.ResolvedByUserSK,
                ProjectSK = command.workItem.ProjectSK
            };

            await _dbContext.AddAsync(workItemBase);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
