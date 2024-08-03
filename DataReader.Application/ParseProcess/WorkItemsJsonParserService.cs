using CSharpFunctionalExtensions;
using Newtonsoft.Json.Linq;

using DataReader.Core.Contracts.Params;
using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;
using DataReader.Core.Abstractions.Services.Parsers;


namespace DataReader.Application.ParseProcess
{
  public class WorkItemsJsonParserService : IJsonParserService<Result<List<WorkItemsDTOParam>?>>
  {
    public WorkItemsJsonParserService() { }

    public Result<List<WorkItemsDTOParam>?> Parse(string json)
    {
      try
      {
        List<WorkItemsDTOParam>? result = new();
        List<WorkItemParam>? workItemParam = new();

        JObject obj = JObject.Parse(json);
        JArray? array = (JArray?)obj["value"];

        if (array?.Count != 0)
        {
          workItemParam = FillWorkItemParamList(array!);
          result = FillResultList(workItemParam);
        }

        return Result.Success<List<WorkItemsDTOParam>?>(result);
      }

      catch (Exception ex)
      {
        return Result.Failure<List<WorkItemsDTOParam>?>(ex.Message);
      }
    }

    private List<WorkItemParam> FillWorkItemParamList(JArray array)
    {
      List<WorkItemParam>? temp = new();

      foreach (var item in array)
      {
        int workItemId = item["WorkItemId"].Type != JTokenType.Null ? (int)item["WorkItemId"] : 0;

        AnalyticsUpdatedDate inProgressDate =
          AnalyticsUpdatedDate.
          Create(item["InProgressDate"]).
          Value;

        AnalyticsUpdatedDate completedDate =
          AnalyticsUpdatedDate.
          Create(item["CompletedDate"]).
          Value;

        string? inProgressDateSK = item["InProgressDateSK"]?.ToString();
        string? completedDateSK = item["CompletedDateSK"]?.ToString();

        AnalyticsUpdatedDate analyticsUpdatedDate =
          AnalyticsUpdatedDate.
          Create(item["AnalyticsUpdatedDate"]).
          Value;

        DataReaderGuid projectSK = DataReaderGuid.Create(item["ProjectSK"].ToString()).Value;
        int workItemRevisionSK = item["WorkItemRevisionSK"].Type != JTokenType.Null ? (int)item["WorkItemRevisionSK"] : 0;

        DataReaderGuid areaSK = DataReaderGuid.Create(item["AreaSK"].ToString()).Value;
        DataReaderGuid iterationSK = DataReaderGuid.Create(item["IterationSK"].ToString()).Value;
        DataReaderGuid assignedToUserSK = DataReaderGuid.Create(item["AssignedToUserSK"].ToString()).Value;
        DataReaderGuid changedByUserSK = DataReaderGuid.Create(item["ChangedByUserSK"].ToString()).Value;
        DataReaderGuid createdByUserSK = DataReaderGuid.Create(item["CreatedByUserSK"].ToString()).Value;
        DataReaderGuid activatedByUserSK = DataReaderGuid.Create(item["ActivatedByUserSK"].ToString()).Value;
        DataReaderGuid closedByUserSK = DataReaderGuid.Create(item["ClosedByUserSK"].ToString()).Value;
        DataReaderGuid resolvedByUserSK = DataReaderGuid.Create(item["ResolvedByUserSK"].ToString()).Value;

        string? activatedDateSK = item["ActivatedDateSK"]?.ToString();
        string? changedDateSK = item["ChangedDateSK"]?.ToString();
        string? closedDateSK = item["ClosedDateSK"]?.ToString();
        string? createdDateSK = item["CreatedDateSK"]?.ToString();
        string? resolvedDateSK = item["ResolvedDateSK"]?.ToString();
        string? stateChangeDateSK = item["StateChangeDateSK"]?.ToString();
        string? workItemType = item["WorkItemType"]?.ToString();

        AnalyticsUpdatedDate changedDate =
          AnalyticsUpdatedDate.
          Create(item["ChangedDate"]).
          Value;

        AnalyticsUpdatedDate createdDate =
          AnalyticsUpdatedDate.
          Create(item["CreatedDate"]).
          Value;

        string? state = item["State"]?.ToString();

        AnalyticsUpdatedDate activatedDate =
          AnalyticsUpdatedDate.
          Create(item["ActivatedDate"]).
          Value;

        AnalyticsUpdatedDate closedDate =
          AnalyticsUpdatedDate.
          Create(item["ClosedDate"]).
          Value;

        int priority = item["Priority"].Type != JTokenType.Null ? (int)item["Priority"] : 0;

        AnalyticsUpdatedDate resolvedDate =
          AnalyticsUpdatedDate.
          Create(item["ResolvedDate"]).
          Value;

        double completedWork = item["CompletedWork"].Type != JTokenType.Null ? (double)item["CompletedWork"] : 0.0;
        string? effort = item["Effort"]?.ToString();

        AnalyticsUpdatedDate finishDate =
          AnalyticsUpdatedDate.
          Create(item["FinishDate"] ).
          Value;

        string? originalEstimate = item["OriginalEstimate"]?.ToString();
        string? remainingWork = item["RemainingWork"]?.ToString();
        string? startDate = item["StartDate"]?.ToString();
        string? storyPoints = item["StoryPoints"]?.ToString();
        string? targetDate = item["TargetDate"]?.ToString();
        int parentWorkItemId = item["ParentWorkItemId"].Type != JTokenType.Null ? (int)item["ParentWorkItemId"] : 0;
        string? tagNames = item["TagNames"]?.ToString();

        AnalyticsUpdatedDate stateChangeDate =
          AnalyticsUpdatedDate.
          Create(item["StateChangeDate"]).
          Value;

        string? custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 =
          item["Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3"]?.ToString();
        string? custom_Company = item["Custom_Company"]?.ToString();
        string? custom_Eksternareferenca = item["Custom_Eksternareferenca"]?.ToString();
        string? custom_ITServiceorApplication = item["Custom_ITServiceorApplication"]?.ToString();
        string? custom_Statusprojekta = item["Custom_Statusprojekta"]?.ToString();
        string? custom_TicketNo = item["Custom_TicketNo"]?.ToString();

        WorkItemParam param = new(
          workItemId, inProgressDate, completedDate, inProgressDateSK, completedDateSK, analyticsUpdatedDate,
          projectSK, workItemRevisionSK, areaSK, iterationSK, assignedToUserSK, changedByUserSK, createdByUserSK,
          activatedByUserSK, closedByUserSK, resolvedByUserSK, activatedDateSK, changedDateSK, closedDateSK, createdDateSK,
          resolvedDateSK, stateChangeDateSK, workItemType, changedDate, createdDate, state, activatedDate, closedDate,
          priority, resolvedDate, completedWork, effort, finishDate, originalEstimate, remainingWork, startDate, storyPoints,
          targetDate, parentWorkItemId, tagNames, stateChangeDate, custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,
          custom_Company, custom_Eksternareferenca, custom_ITServiceorApplication, custom_Statusprojekta, custom_TicketNo
        );
        temp.Add(param);
      }

      return temp;
    }

    private List<WorkItemsDTOParam> FillResultList(List<WorkItemParam> workItemParam)
    {
      List<WorkItemsDTOParam>? temp = new();

      foreach (var param in workItemParam)
      {
        WorkItemsDTOParam dto = new(param);
        temp.Add(dto);
      }

      return temp;
    }
  }
}
