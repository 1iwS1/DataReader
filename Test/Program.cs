using DataReader.Application.Handlers;
using DataReader.Application.ParseProcess;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;


public class Program
{
  public static void Main(string[] args)
  {
    string json = "{\r\n  \"@odata.context\": \"https://analytics.dev.azure.com/KAPPASTAR-IT/_odata/v3.0/$metadata#WorkItems(WorkItemId,InProgressDate,CompletedDate,InProgressDateSK,CompletedDateSK,AnalyticsUpdatedDate,ProjectSK,WorkItemRevisionSK,AreaSK,IterationSK,AssignedToUserSK,ChangedByUserSK,CreatedByUserSK,ActivatedByUserSK,ClosedByUserSK,ResolvedByUserSK,ActivatedDateSK,ChangedDateSK,ClosedDateSK,CreatedDateSK,ResolvedDateSK,StateChangeDateSK,WorkItemType,ChangedDate,CreatedDate,State,ActivatedDate,ClosedDate,Priority,ResolvedDate,CompletedWork,Effort,FinishDate,OriginalEstimate,RemainingWork,StartDate,StoryPoints,TargetDate,ParentWorkItemId,TagNames,StateChangeDate,Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3,Custom_Company,Custom_Eksternareferenca,Custom_ITServiceorApplication,Custom_Statusprojekta,Custom_TicketNo)\",\r\n  \"vsts.warnings@odata.type\": \"#Collection(String)\",\r\n  \"@vsts.warnings\": [\r\n    \"VS403509: The specified query exceeds the recommended size of 10 columns. Details on recommended query patterns are available here: https://go.microsoft.com/fwlink/?linkid=861060.\"\r\n  ],\r\n  \"value\": []\r\n}";

    IJsonParserService jsonParserService = new JsonParserService();
    IUserHandlerService userHandlerService = new UserHandlerService(jsonParserService);
    userHandlerService.Parsing(json);
  }
}
