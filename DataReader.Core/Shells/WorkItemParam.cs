using DataReader.Core.Enums;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Shells
{
  public record WorkItemParam(
      int workItemId,                   AnalyticsUpdatedDate inProgressDate,  AnalyticsUpdatedDate completedDate,
      string inProgressDateSK,          string completedDateSK,               AnalyticsUpdatedDate analyticsUpdatedDate,
      DataReaderGuid projectSK,         int workItemRevisionSK,               DataReaderGuid areaSK, 
      DataReaderGuid iterationSK,       DataReaderGuid assignedToUserSK,      DataReaderGuid changedByUserSK,
      DataReaderGuid createdByUserSK,   DataReaderGuid activatedByUserSK,     DataReaderGuid closedByUserSK,
      DataReaderGuid resolvedByUserSK,  string activatedDateSK,               string changedDateSK,
      string сlosedDateSK,              string createdDateSK,                 string resolvedDateSK,
      string stateChangeDateSK,         string workItemType,        AnalyticsUpdatedDate changedDate,
      AnalyticsUpdatedDate createdDate, string state,                         AnalyticsUpdatedDate activatedDate,
      AnalyticsUpdatedDate closedDate,  int priority,                         AnalyticsUpdatedDate resolvedDate,
      double completedWork,             string effort,                        AnalyticsUpdatedDate finishDate,
      string originalEstimate,          string remainingWork,                 string startDate,
      string storyPoints,               string targetDate,                    int parentWorkItemId,
      string tagNames,                  AnalyticsUpdatedDate stateChangeDate, string custom_Company,
      string custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
      string custom_Eksternareferenca,  string custom_ITServiceorApplication, string custom_Statusprojekta,
      string custom_TicketNo
    );
}
