using CSharpFunctionalExtensions;
using Quartz;

using DataReader.Core.Models;
using DataReader.Core.Shells;
using DataReader.Core.ValueObjects;
using DataReader.Core.Enums;


namespace DataReader.ExternalAPI.Controllers
{
  public class MainControllerJob(
      LogController logController,
      UserController userController,
      ProjectController projectController,
      WorkItemController workItemController
      ) : IJob
  {
    private readonly LogController _logController = logController;
    private readonly UserController _userController = userController;
    private readonly ProjectController _projectController = projectController;
    private readonly WorkItemController _workItemController = workItemController;

    private const string PAT = ""; // !!!!!!!!!!!!!!!!

    public async Task Execute(IJobExecutionContext context)
    {
      Result<Log> logResult = await _logController.GetLog();

      Result projectResult = new();
      Result userResult = new();
      Result workItemResult = new();

      bool resultOfGettingData = await ReadAllData(
        logResult.IsFailure ? "" : logResult.Value.LastSyncTime.Date,
        projectResult,
        userResult,
        workItemResult
      );

      Result<Log> log = Log.Create(new LogParam(
        DataReaderGuid.Create(Guid.NewGuid().ToString()).Value,
        AnalyticsUpdatedDate.Create(DateTime.Now.ToString("s") + "Z").Value,
        resultOfGettingData ? Results.Succeed : Results.Failed
      ));

      await _logController.CreateLog(log.Value);

      await Task.CompletedTask;
    }

    private async Task<bool> ReadAllData(string? dateToCompareWith, Result projectResult, Result userResult, Result workItemResult)
    {
      projectResult = await _projectController.GetDataByODataProtocol("");
      userResult = await _userController.GetDataByODataProtocol("");
      workItemResult = await _workItemController.GetDataByODataProtocol("", dateToCompareWith);

      if (projectResult.IsSuccess && userResult.IsSuccess && workItemResult.IsSuccess)
      {
        return true;
      }

      return false;
    }
  }
}
