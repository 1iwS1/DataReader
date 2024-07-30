using CSharpFunctionalExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DataReader.Core.Contracts.Params;
using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;
using DataReader.Core.Abstractions.Services.Parsers;


namespace DataReader.Application.ParseProcess
{
  public class WorkItemsJsonParserService : IWorkItemsJsonParserService
  {
    public WorkItemsJsonParserService() { }

    public Result<List<WorkItemsDTOParam>?> ParseWorkItem(string json)
    {
      try
      {
        List<WorkItemsDTOParam>? result = new();
        List<WorkItemParam>? workItemParam = new();

        //userParam = JsonConvert.DeserializeObject<List<UserParam>>(json);

        JObject obj = JObject.Parse(json);
        JArray array = (JArray)obj["value"];

        //if (array == null)
        //{
        //  return Result.Failure<List<UsersDTOParam>?>("empty json");
        //}

        if (array.Count != 0)
        {
          workItemParam = FillWorkItemParamList(array);
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
        int workItemId = (int)item["WorkItemId"];

        AnalyticsUpdatedDate inProgressDate =
          AnalyticsUpdatedDate.
          Create(item["InProgressDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        AnalyticsUpdatedDate completedDate =
          AnalyticsUpdatedDate.
          Create(item["CompletedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        string? inProgressDateSK = item["InProgressDateSK"]?.ToString();
        string? completedDateSK = item["CompletedDateSK"]?.ToString();

        AnalyticsUpdatedDate analyticsUpdatedDate =
          AnalyticsUpdatedDate.
          Create(item["AnalyticsUpdatedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        DataReaderGuid projectSK = DataReaderGuid.Create((Guid)item["ProjectSK"]).Value;
        int workItemRevisionSK = (int)item["WorkItemRevisionSK"];

        DataReaderGuid areaSK = DataReaderGuid.Create((Guid)item["AreaSK"]).Value;
        DataReaderGuid iterationSK = DataReaderGuid.Create((Guid)item["IterationSK"]).Value;
        DataReaderGuid assignedToUserSK = DataReaderGuid.Create((Guid)item["AssignedToUserSK"]).Value;
        DataReaderGuid changedByUserSK = DataReaderGuid.Create((Guid)item["ChangedByUserSK"]).Value;
        DataReaderGuid createdByUserSK = DataReaderGuid.Create((Guid)item["CreatedByUserSK"]).Value;
        DataReaderGuid activatedByUserSK = DataReaderGuid.Create((Guid)item["ActivatedByUserSK"]).Value;
        DataReaderGuid closedByUserSK = DataReaderGuid.Create((Guid)item["ClosedByUserSK"]).Value;
        DataReaderGuid resolvedByUserSK = DataReaderGuid.Create((Guid)item["ResolvedByUserSK"]).Value;

        string? activatedDateSK = item["ActivatedDateSK"]?.ToString();
        string? changedDateSK = item["ChangedDateSK"]?.ToString();
        string? closedDateSK = item["ClosedDateSK"]?.ToString();
        string? createdDateSK = item["CreatedDateSK"]?.ToString();
        string? resolvedDateSK = item["ResolvedDateSK"]?.ToString();
        string? stateChangeDateSK = item["StateChangeDateSK"]?.ToString();
        string? workItemType = item["WorkItemType"]?.ToString();

        AnalyticsUpdatedDate changedDate =
          AnalyticsUpdatedDate.
          Create(item["ChangedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        AnalyticsUpdatedDate createdDate =
          AnalyticsUpdatedDate.
          Create(item["CreatedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        string? state = item["State"]?.ToString();

        AnalyticsUpdatedDate activatedDate =
          AnalyticsUpdatedDate.
          Create(item["ActivatedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        AnalyticsUpdatedDate closedDate =
          AnalyticsUpdatedDate.
          Create(item["ClosedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        int priority = (int)item["Priority"];

        AnalyticsUpdatedDate resolvedDate =
          AnalyticsUpdatedDate.
          Create(item["ResolvedDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        double completedWork = (double)item["CompletedWork"];
        string? effort = item["Effort"]?.ToString();

        AnalyticsUpdatedDate finishDate =
          AnalyticsUpdatedDate.
          Create(item["FinishDate"].
          ToString(Formatting.Indented).
          Trim('"')).
          Value;

        string? originalEstimate = item["OriginalEstimate"]?.ToString();
        string? remainingWork = item["RemainingWork"]?.ToString();
        string? startDate = item["StartDate"]?.ToString();
        string? storyPoints = item["StoryPoints"]?.ToString();
        string? targetDate = item["TargetDate"]?.ToString();
        int parentWorkItemId = (int)item["ParentWorkItemId"];
        string? tagNames = item["TagNames"]?.ToString();

        AnalyticsUpdatedDate stateChangeDate =
          AnalyticsUpdatedDate.
          Create(item["StateChangeDate"].
          ToString(Formatting.Indented).
          Trim('"')).
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
