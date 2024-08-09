using Microsoft.Extensions.Options;
using CSharpFunctionalExtensions;
using Quartz;

using DataReader.ExternalAPI.Properties.Configs.ClassConfigs;
using DataReader.Core.ValueObjects;
using DataReader.Core.Models;
using DataReader.Core.Shells;
using DataReader.Core.Enums;


namespace DataReader.ExternalAPI.Controllers
{
  public class MainControllerJob(
      LogController logController,
      UserController userController,
      ProjectController projectController,
      WorkItemController workItemController,
      IOptions<Secrets> options
      ) : IJob
  {
    private readonly LogController _logController = logController;
    private readonly UserController _userController = userController;
    private readonly ProjectController _projectController = projectController;
    private readonly WorkItemController _workItemController = workItemController;

    private readonly Secrets secrets = options.Value;

    public async Task Execute(IJobExecutionContext context)
    {
      Result<Log> logResult = await _logController.GetLog();

      bool resultOfGettingData = await ReadAllData(
        logResult.IsFailure ? "" : logResult.Value.LastSyncTime.Date
      );

      Result<Log> log = Log.Create(new LogParam(
        DataReaderGuid.Create(Guid.NewGuid().ToString()).Value,
        AnalyticsUpdatedDate.Create(DateTime.Now.ToString("s") + "Z").Value,
        resultOfGettingData ? Results.Succeed : Results.Failed
      ));

      await _logController.CreateLog(log.Value);

      await Task.CompletedTask;
    }

    private async Task<bool> ReadAllData(string? dateToCompareWith)
    {
      Result projectResult = await _projectController.GetDataByODataProtocol(secrets.PAT);
      Result userResult = await _userController.GetDataByODataProtocol(secrets.PAT);
      Result workItemResult = await _workItemController.GetDataByODataProtocol(secrets.PAT, dateToCompareWith);

      if (projectResult.IsSuccess && userResult.IsSuccess && workItemResult.IsSuccess)
      {
        return true;
      }

      return false;
    }
  }
}
