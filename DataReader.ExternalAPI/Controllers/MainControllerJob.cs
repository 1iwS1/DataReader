using CSharpFunctionalExtensions;
using Quartz;

using DataReader.Core.Models;


namespace DataReader.ExternalAPI.Controllers
{
  public class MainControllerJob : IJob
  {
    private readonly LogController _logController;
    private readonly UserController _userController;
    private readonly ProjectController _projectController;
    private readonly WorkItemController _workItemController;

    public MainControllerJob(
      LogController logController,
      UserController userController,
      ProjectController projectController,
      WorkItemController workItemController
      )
    {
      _logController = logController;
      _userController = userController;
      _projectController = projectController;
      _workItemController = workItemController;
    }

    public async Task Execute(IJobExecutionContext context)
    {
      Result<Log> logResult = await _logController.GetLog();

      await Task.CompletedTask;
    }
  }
}
