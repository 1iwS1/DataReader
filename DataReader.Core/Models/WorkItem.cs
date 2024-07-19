using CSharpFunctionalExtensions;

using DataReader.Core.Enums;
using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Models
{
  public class WorkItem
  {
    private WorkItem(WorkItemParam shell)
    {
      WorkItemId = shell.workItemId;
      InProgressDate = shell.inProgressDate;
      CompletedDate = shell.completedDate;
      InProgressDateSK = shell.inProgressDateSK;
      CompletedDateSK = shell.completedDateSK;
      AnalyticsUpdatedDate = shell.analyticsUpdatedDate;
      ProjectSK = shell.projectSK;
      WorkItemRevisionSK = shell.workItemRevisionSK;
      AreaSK = shell.areaSK;
      IterationSK = shell.iterationSK;
      AssignedToUserSK = shell.assignedToUserSK;
      ChangedByUserSK = shell.changedByUserSK;
      CreatedByUserSK = shell.createdByUserSK;
      ActivatedByUserSK = shell.activatedByUserSK;
      ClosedByUserSK = shell.closedByUserSK;
      ResolvedByUserSK = shell.resolvedByUserSK;
      ActivatedDateSK = shell.activatedDateSK;
      ChangedDateSK = shell.changedDateSK;
      ClosedDateSK = shell.сlosedDateSK;
      CreatedDateSK = shell.createdDateSK;
      ResolvedDateSK = shell.resolvedDateSK;
      StateChangeDateSK = shell.stateChangeDateSK;
      WorkItemType = shell.workItemType;
      ChangedDate = shell.changedDate;
      CreatedDate = shell.createdDate;
      State = shell.state;
      ActivatedDate = shell.activatedDate;
      ClosedDate = shell.closedDate;
      Priority = shell.priority;
      ResolvedDate = shell.resolvedDate;
      CompletedWork = shell.completedWork;
      Effort = shell.effort;
      FinishDate = shell.finishDate;
      OriginalEstimate = shell.originalEstimate;
      RemainingWork = shell.remainingWork;
      StartDate = shell.startDate;
      StoryPoints = shell.storyPoints;
      TargetDate = shell.targetDate;
      ParentWorkItemId = shell.parentWorkItemId;
      TagNames = shell.tagNames;
      StateChangeDate = shell.stateChangeDate;
      Custom_Company = shell.custom_Company;
      Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 = 
        shell.custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3;
      Custom_Eksternareferenca = shell.custom_Eksternareferenca;
      Custom_ITServiceorApplication = shell.custom_ITServiceorApplication;
      Custom_TicketNo = shell.custom_TicketNo;
    }

    public int? WorkItemId { get; }
    public AnalyticsUpdatedDate InProgressDate { get; }
    public AnalyticsUpdatedDate CompletedDate { get; }
    public string? InProgressDateSK { get; }
    public string? CompletedDateSK { get; }
    public AnalyticsUpdatedDate AnalyticsUpdatedDate { get; }
    public DataReaderGuid ProjectSK { get; }
    public int? WorkItemRevisionSK { get; }
    public DataReaderGuid AreaSK { get; }
    public DataReaderGuid IterationSK { get; }
    public DataReaderGuid AssignedToUserSK { get; }
    public DataReaderGuid ChangedByUserSK { get; }
    public DataReaderGuid CreatedByUserSK { get; }
    public DataReaderGuid ActivatedByUserSK { get; }
    public DataReaderGuid ClosedByUserSK { get; }
    public DataReaderGuid ResolvedByUserSK { get; }
    public string? ActivatedDateSK { get; }
    public string? ChangedDateSK { get; }
    public string? ClosedDateSK { get; }
    public string? CreatedDateSK { get; }
    public string? ResolvedDateSK { get; }
    public string? StateChangeDateSK { get; }
    public WorkItemTypeEnum WorkItemType { get; }
    public AnalyticsUpdatedDate ChangedDate { get; }
    public AnalyticsUpdatedDate CreatedDate { get; }
    public StateEnum State { get; }
    public AnalyticsUpdatedDate ActivatedDate { get; }
    public AnalyticsUpdatedDate ClosedDate { get; }
    public int? Priority { get; }
    public AnalyticsUpdatedDate ResolvedDate { get; }
    public double? CompletedWork { get; }
    public string? Effort { get; }
    public AnalyticsUpdatedDate FinishDate { get; }
    public string? OriginalEstimate { get; }
    public string? RemainingWork { get; }
    public string? StartDate { get; }
    public string? StoryPoints { get; }
    public string? TargetDate { get; }
    public int? ParentWorkItemId { get; }
    public string? TagNames { get; }
    public AnalyticsUpdatedDate StateChangeDate { get; }
    public string? Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 { get; }
    public string? Custom_Company { get; }
    public string? Custom_Eksternareferenca { get; }
    public string? Custom_ITServiceorApplication { get; }
    public string? Custom_Statusprojekta { get; }
    public string? Custom_TicketNo { get; }

    public static Result<WorkItem> Create(WorkItemParam shell)
    {
      WorkItem workItem = new WorkItem(shell);

      return Result.Success(workItem);
    }
  }
}
