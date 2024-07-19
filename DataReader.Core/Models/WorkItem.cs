using CSharpFunctionalExtensions;

using DataReader.Core.ValueObjects;


namespace DataReader.Core.Models
{
  public class WorkItem
  {
    // может сделать объект-оболочку для параметров? WorkItemParamShell
    private WorkItem(
      int workItemId,                   AnalyticsUpdatedDate inProgressDate,  AnalyticsUpdatedDate completedDate,
      string inProgressDateSK,          string completedDateSK,               AnalyticsUpdatedDate analyticsUpdatedDate,
      DataReaderGuid projectSK,         int workItemRevisionSK,               DataReaderGuid areaSK, 
      DataReaderGuid iterationSK,       DataReaderGuid assignedToUserSK,      DataReaderGuid changedByUserSK,
      DataReaderGuid createdByUserSK,   DataReaderGuid activatedByUserSK,     DataReaderGuid closedByUserSK,
      DataReaderGuid resolvedByUserSK,  string activatedDateSK,               string changedDateSK,
      string сlosedDateSK,              string createdDateSK,                 string resolvedDateSK,
      string stateChangeDateSK,         string workItemType,                  AnalyticsUpdatedDate changedDate,
      AnalyticsUpdatedDate createdDate, string state,                         AnalyticsUpdatedDate activatedDate,
      AnalyticsUpdatedDate closedDate,  int priority,                         AnalyticsUpdatedDate resolvedDate,
      double completedWork,             string effort,                        AnalyticsUpdatedDate finishDate,
      string originalEstimate,          string remainingWork,                 string startDate,
      string storyPoints,               string targetDate,                    int parentWorkItemId,
      string tagNames,                  AnalyticsUpdatedDate stateChangeDate, string custom_Company,
      string custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
      string custom_Eksternareferenca,  string custom_ITServiceorApplication, string custom_Statusprojekta,
      string custom_TicketNo
      )
    {
      WorkItemId = workItemId;
      InProgressDate = inProgressDate;
      CompletedDate = completedDate;
      InProgressDateSK = inProgressDateSK;
      CompletedDateSK = completedDateSK;
      AnalyticsUpdatedDate = analyticsUpdatedDate;
      ProjectSK = projectSK;
      WorkItemRevisionSK = workItemRevisionSK;
      AreaSK = areaSK;
      IterationSK = iterationSK;
      AssignedToUserSK = assignedToUserSK;
      ChangedByUserSK = changedByUserSK;
      CreatedByUserSK = createdByUserSK;
      ActivatedByUserSK = activatedByUserSK;
      ClosedByUserSK = closedByUserSK;
      ResolvedByUserSK = resolvedByUserSK;
      ActivatedDateSK = activatedDateSK;
      ChangedDateSK = changedDateSK;
      ClosedDateSK = сlosedDateSK;
      CreatedDateSK = createdDateSK;
      ResolvedDateSK = resolvedDateSK;
      StateChangeDateSK = stateChangeDateSK;
      WorkItemType = workItemType;
      ChangedDate = changedDate;
      CreatedDate = createdDate;
      State = state;
      ActivatedDate = activatedDate;
      ClosedDate = closedDate;
      Priority = priority;
      ResolvedDate = resolvedDate;
      CompletedWork = completedWork;
      Effort = effort;
      FinishDate = finishDate;
      OriginalEstimate = originalEstimate;
      RemainingWork = remainingWork;
      StartDate = startDate;
      StoryPoints = storyPoints;
      TargetDate = targetDate;
      ParentWorkItemId = parentWorkItemId;
      TagNames = tagNames;
      StateChangeDate = stateChangeDate;
      Custom_Company = custom_Company;
      Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 = 
        custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3;
      Custom_Eksternareferenca = custom_Eksternareferenca;
      Custom_ITServiceorApplication = custom_ITServiceorApplication;
      Custom_TicketNo = custom_TicketNo;
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
    public string? WorkItemType { get; } // может enum?
    public AnalyticsUpdatedDate ChangedDate { get; }
    public AnalyticsUpdatedDate CreatedDate { get; }
    public string? State { get; } // может enum?
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

    public static Result<WorkItem> Create(
      int workItemId,                   AnalyticsUpdatedDate inProgressDate,  AnalyticsUpdatedDate completedDate,
      string inProgressDateSK,          string completedDateSK,               AnalyticsUpdatedDate analyticsUpdatedDate,
      DataReaderGuid projectSK,         int workItemRevisionSK,               DataReaderGuid areaSK,
      DataReaderGuid iterationSK,       DataReaderGuid assignedToUserSK,      DataReaderGuid changedByUserSK,
      DataReaderGuid createdByUserSK,   DataReaderGuid activatedByUserSK,     DataReaderGuid closedByUserSK,
      DataReaderGuid resolvedByUserSK,  string activatedDateSK,               string changedDateSK,
      string сlosedDateSK,              string createdDateSK,                 string resolvedDateSK,
      string stateChangeDateSK,         string workItemType,                  AnalyticsUpdatedDate changedDate,
      AnalyticsUpdatedDate createdDate, string state,                         AnalyticsUpdatedDate activatedDate,
      AnalyticsUpdatedDate closedDate,  int priority,                         AnalyticsUpdatedDate resolvedDate,
      double completedWork,             string effort,                        AnalyticsUpdatedDate finishDate,
      string originalEstimate,          string remainingWork,                 string startDate,
      string storyPoints,               string targetDate,                    int parentWorkItemId,
      string tagNames,                  AnalyticsUpdatedDate StateChangeDate, string custom_Company,
      string custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
      string custom_Eksternareferenca,  string custom_ITServiceorApplication, string custom_Statusprojekta,
      string custom_TicketNo
      )
    {
      WorkItem workItem = new WorkItem(
        
        );

      return Result.Success(workItem);
    }
  }
}
