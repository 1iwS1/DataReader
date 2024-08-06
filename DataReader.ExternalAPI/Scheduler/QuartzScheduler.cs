using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quartz;

using DataReader.ExternalAPI.Controllers;


namespace DataReader.ExternalAPI.Scheduler
{
  public class QuartzScheduler
  {
    private ISchedulerFactory SchedulerFactory { get; set; }
    public IJobDetail? Job { get; set; }

    private delegate ITrigger TriggerDelegate();
    private static TriggerDelegate dailyTrigger = new TriggersFactory().CreateDailyTrigger;
    private static TriggerDelegate hourlyTrigger = new TriggersFactory().CreateHourlyTrigger;
    private static TriggerDelegate secondlyTrigger = new TriggersFactory().CreateSecondlyTrigger;

    public IDictionary triggers = new Dictionary<string, ITrigger>()
    {
      { "daily", dailyTrigger() },
      { "hourly", hourlyTrigger() },
      { "secondly", secondlyTrigger() }
    };

    public QuartzScheduler(IHost builder)
    {
      SchedulerFactory = builder.Services.GetRequiredService<ISchedulerFactory>();
    }

    public async Task<IScheduler> GetSchedulerAndJob()
    {
      IScheduler scheduler = await SchedulerFactory.GetScheduler();

      Job = JobBuilder.Create<MainControllerJob>()
        .WithIdentity("MainController", "Group1")
        .Build();

      await scheduler.Start();

      return scheduler;
    }
  }
}
