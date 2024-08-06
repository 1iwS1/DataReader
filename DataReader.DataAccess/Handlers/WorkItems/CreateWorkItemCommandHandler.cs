using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Commands.WorkItems;
using DataReader.DataAccess.Models;


namespace DataReader.DataAccess.Handlers.WorkItems
{
    public class CreateWorkItemCommandHandler : ICommandHandler<Task<Result<bool>>, CreateWorkItemCommand>
    {
        private readonly DataAzureContext _dbContext;

        public CreateWorkItemCommandHandler(DataAzureContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<bool>> Handle(CreateWorkItemCommand command)
        {
            var workItemBase = new WorkItem
            {
                WorkItemId = command.workItem.WorkItemId,
                InProgressDate = command.workItem.InProgressDate.Date,
                CompletedDate = command.workItem.CompletedDate.Date,
                InProgressDateSk = command.workItem.InProgressDateSK,
                CompletedDateSk = command.workItem.CompletedDateSK,
                AnalyticsUpdatedDate = command.workItem.AnalyticsUpdatedDate.Date,
                WorkItemRevisionSk = command.workItem.WorkItemRevisionSK,
                AreaSk = command.workItem.AreaSK.CustomGuid,
                IterationSk = command.workItem.IterationSK.CustomGuid,
                ActivatedDateSk = command.workItem.ActivatedDateSK,
                ChangedDateSk = command.workItem.ChangedDateSK,
                ClosedDateSk = command.workItem.ClosedDateSK,
                CreatedDateSk = command.workItem.CreatedDateSK,
                ResolvedDateSk = command.workItem.ResolvedDateSK,
                StateChangeDateSk = command.workItem.StateChangeDateSK,
                WorkItemType = command.workItem.WorkItemType,
                ChangedDate = command.workItem.ChangedDate.Date,
                CreatedDate = command.workItem.CreatedDate.Date,
                State = command.workItem.State,
                ActivatedDate = command.workItem.ActivatedDate.Date,
                ClosedDate = command.workItem.ClosedDate.Date,
                Priority = command.workItem.Priority,
                ResolvedDate = command.workItem.ResolvedDate.Date,
                CompletedWork = (decimal?)command.workItem.CompletedWork,
                Effort = command.workItem.Effort,
                FinishDate = command.workItem.FinishDate.Date,
                OriginalEstimate = command.workItem.OriginalEstimate,
                RemainingWork = command.workItem.RemainingWork,
                StartDate = command.workItem.StartDate,
                StoryPoints = command.workItem.StoryPoints,
                TargetDate = command.workItem.TargetDate,
                ParentWorkItemId = command.workItem.ParentWorkItemId,
                TagNames = command.workItem.TagNames,
                StateChangeDate = command.workItem.StateChangeDate.Date,
                Custom719f69f1002df7d0002d4baa002db6ce002de77ad5dfcdf3 =
                command.workItem.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
                CustomCompany = command.workItem.Custom_Company,
                CustomEksternareferenca = command.workItem.Custom_Eksternareferenca,
                CustomItserviceorApplication = command.workItem.Custom_ITServiceorApplication,
                CustomStatusprojekta = command.workItem.Custom_Statusprojekta,
                CustomTicketNo = command.workItem.Custom_TicketNo,
                AssignedToUserSk = command.workItem.AssignedToUserSK.CustomGuid,
                ChangedByUserSk = command.workItem.ChangedByUserSK.CustomGuid,
                CreatedByUserSk = command.workItem.CreatedByUserSK.CustomGuid,
                ActivatedByUserSk = command.workItem.ActivatedByUserSK.CustomGuid,
                ClosedByUserSk = command.workItem.ClosedByUserSK.CustomGuid,
                ResolvedByUserSk = command.workItem.ResolvedByUserSK.CustomGuid,
                ProjectSk = command.workItem.ProjectSK.CustomGuid
            };

            await _dbContext.AddAsync(workItemBase);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
