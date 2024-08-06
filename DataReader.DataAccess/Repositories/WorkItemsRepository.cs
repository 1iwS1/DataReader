//using Microsoft.EntityFrameworkCore;
//using CSharpFunctionalExtensions;

//using DataReader.Core.Abstractions.Repositories;
//using DataReader.Core.Models;
//using DataReader.DataAccess.BaseModels;


//namespace DataReader.DataAccess.Repositories
//{
//  public class WorkItemsRepository : IWorkItemsRepository
//  {
//    private readonly DataDbContext _dbContext;

//    public WorkItemsRepository(DataDbContext dbContext)
//    {
//      _dbContext = dbContext;
//    }

//    public async Task<Result<bool>> GetById(int? id)
//    {
//      var workItemBase = await _dbContext.WorkItems
//        .AsNoTracking()
//        .FirstOrDefaultAsync(w => w.WorkItemId == id);

//      if (workItemBase == null)
//      {
//        return false;
//      }

//      return true;
//    }

//    public async Task<Result<bool>> Create(WorkItem workItem)
//    {
//      var workItemBase = new WorkItemBase
//      {
//        WorkItemId = workItem.WorkItemId,
//        InProgressDate = workItem.InProgressDate,
//        CompletedDate = workItem.CompletedDate,
//        InProgressDateSK = workItem.InProgressDateSK,
//        CompletedDateSK = workItem.CompletedDateSK,
//        AnalyticsUpdatedDate = workItem.AnalyticsUpdatedDate,
//        WorkItemRevisionSK = workItem.WorkItemRevisionSK,
//        AreaSK = workItem.AreaSK,
//        IterationSK = workItem.IterationSK,
//        ActivatedDateSK = workItem.ActivatedDateSK,
//        ChangedDateSK = workItem.ChangedDateSK,
//        ClosedDateSK = workItem.ClosedDateSK,
//        CreatedDateSK = workItem.CreatedDateSK,
//        ResolvedDateSK = workItem.ResolvedDateSK,
//        StateChangeDateSK = workItem.StateChangeDateSK,
//        WorkItemType = workItem.WorkItemType,
//        ChangedDate = workItem.ChangedDate,
//        CreatedDate = workItem.CreatedDate,
//        State = workItem.State,
//        ActivatedDate = workItem.ActivatedDate,
//        ClosedDate = workItem.ClosedDate,
//        Priority = workItem.Priority,
//        ResolvedDate = workItem.ResolvedDate,
//        CompletedWork = workItem.CompletedWork,
//        Effort = workItem.Effort,
//        FinishDate = workItem.FinishDate,
//        OriginalEstimate = workItem.OriginalEstimate,
//        RemainingWork = workItem.RemainingWork,
//        StartDate = workItem.StartDate,
//        StoryPoints = workItem.StoryPoints,
//        TargetDate = workItem.TargetDate,
//        ParentWorkItemId = workItem.ParentWorkItemId,
//        TagNames = workItem.TagNames,
//        StateChangeDate = workItem.StateChangeDate,
//        Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 =
//          workItem.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
//        Custom_Company = workItem.Custom_Company,
//        Custom_Eksternareferenca = workItem.Custom_Eksternareferenca,
//        Custom_ITServiceorApplication = workItem.Custom_ITServiceorApplication,
//        Custom_Statusprojekta = workItem.Custom_Statusprojekta,
//        Custom_TicketNo = workItem.Custom_TicketNo,
//        AssignedToUserSK = workItem.AssignedToUserSK,
//        ChangedByUserSK = workItem.ChangedByUserSK,
//        CreatedByUserSK = workItem.CreatedByUserSK,
//        ActivatedByUserSK = workItem.ActivatedByUserSK,
//        ClosedByUserSK = workItem.ClosedByUserSK,
//        ResolvedByUserSK = workItem.ResolvedByUserSK,
//        ProjectSK = workItem.ProjectSK
//      };

//      await _dbContext.AddAsync(workItemBase);
//      await _dbContext.SaveChangesAsync();

//      return true;
//    }

//    public async Task<Result<bool>> Update(int? targetId, WorkItem workItem)
//    {
//      await _dbContext.WorkItems
//        .Where(w => w.WorkItemId == targetId)
//        .ExecuteUpdateAsync(u => u
//          .SetProperty(x => x.InProgressDate, x => workItem.InProgressDate)
//          .SetProperty(x => x.CompletedDate, x => workItem.CompletedDate)
//          .SetProperty(x => x.InProgressDateSK, x => workItem.InProgressDateSK)
//          .SetProperty(x => x.CompletedDateSK, x => workItem.CompletedDateSK)
//          .SetProperty(x => x.AnalyticsUpdatedDate, x => workItem.AnalyticsUpdatedDate)
//          .SetProperty(x => x.WorkItemRevisionSK, x => workItem.WorkItemRevisionSK)
//          .SetProperty(x => x.AreaSK, x => workItem.AreaSK)
//          .SetProperty(x => x.IterationSK, x => workItem.IterationSK)
//          .SetProperty(x => x.ActivatedDateSK, x => workItem.ActivatedDateSK)
//          .SetProperty(x => x.ChangedDateSK, x => workItem.ChangedDateSK)
//          .SetProperty(x => x.ClosedDateSK, x => workItem.ClosedDateSK)
//          .SetProperty(x => x.CreatedDateSK, x => workItem.CreatedDateSK)
//          .SetProperty(x => x.ResolvedDateSK, x => workItem.ResolvedDateSK)
//          .SetProperty(x => x.StateChangeDateSK, x => workItem.StateChangeDateSK)
//          .SetProperty(x => x.WorkItemType, x => workItem.WorkItemType)
//          .SetProperty(x => x.ChangedDate, x => workItem.ChangedDate)
//          .SetProperty(x => x.CreatedDate, x => workItem.CreatedDate)
//          .SetProperty(x => x.State, x => workItem.State)
//          .SetProperty(x => x.ActivatedDate, x => workItem.ActivatedDate)
//          .SetProperty(x => x.ClosedDate, x => workItem.ClosedDate)
//          .SetProperty(x => x.Priority, x => workItem.Priority)
//          .SetProperty(x => x.ResolvedDate, x => workItem.ResolvedDate)
//          .SetProperty(x => x.CompletedWork, x => workItem.CompletedWork)
//          .SetProperty(x => x.Effort, x => workItem.Effort)
//          .SetProperty(x => x.FinishDate, x => workItem.FinishDate)
//          .SetProperty(x => x.OriginalEstimate, x => workItem.OriginalEstimate)
//          .SetProperty(x => x.RemainingWork, x => workItem.RemainingWork)
//          .SetProperty(x => x.StartDate, x => workItem.StartDate)
//          .SetProperty(x => x.StoryPoints, x => workItem.StoryPoints)
//          .SetProperty(x => x.TargetDate, x => workItem.TargetDate)
//          .SetProperty(x => x.ParentWorkItemId, x => workItem.ParentWorkItemId)
//          .SetProperty(x => x.TagNames, x => workItem.TagNames)
//          .SetProperty(x => x.StateChangeDate, x => workItem.StateChangeDate)
//          .SetProperty(x => x.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
//            x => workItem.Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3)
//          .SetProperty(x => x.Custom_Company, x => workItem.Custom_Company)
//          .SetProperty(x => x.Custom_Eksternareferenca, x => workItem.Custom_Eksternareferenca)
//          .SetProperty(x => x.Custom_ITServiceorApplication, x => workItem.Custom_ITServiceorApplication)
//          .SetProperty(x => x.Custom_Statusprojekta, x => workItem.Custom_Statusprojekta)
//          .SetProperty(x => x.Custom_TicketNo, x => workItem.Custom_TicketNo)
//          .SetProperty(x => x.AssignedToUserSK, x => workItem.AssignedToUserSK)
//          .SetProperty(x => x.ChangedByUserSK, x => workItem.ChangedByUserSK)
//          .SetProperty(x => x.CreatedByUserSK, x => workItem.CreatedByUserSK)
//          .SetProperty(x => x.ActivatedByUserSK, x => workItem.ActivatedByUserSK)
//          .SetProperty(x => x.ClosedByUserSK, x => workItem.ClosedByUserSK)
//          .SetProperty(x => x.ResolvedByUserSK, x => workItem.ResolvedByUserSK)
//          .SetProperty(x => x.ProjectSK, x => workItem.ProjectSK)
//          );

//      return true;
//    }
//  }
//}
