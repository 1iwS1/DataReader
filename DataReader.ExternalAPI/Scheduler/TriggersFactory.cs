using Quartz;


namespace DataReader.ExternalAPI.Scheduler
{
  public class TriggersFactory
  {
    public ITrigger CreateDailyTrigger()
    {
      return TriggerBuilder.Create()
        .WithIdentity("DailyTrigger", "Group1")
        .WithCronSchedule("0 0 23 * * ?")
        .Build();
    }

    public ITrigger CreateHourlyTrigger()
    {
      return TriggerBuilder.Create()
        .WithIdentity("HourlyTrigger", "Group1")
        .WithCronSchedule("0 0 * * * ?")
        .Build();
    }

    public ITrigger CreateSecondlyTrigger()
    {
      return TriggerBuilder.Create()
        .WithIdentity("DailyTrigger", "Group1")
        //.WithSimpleSchedule(x => x
        //  .WithIntervalInSeconds(15)
        //  .RepeatForever())
        .StartAt(DateBuilder.FutureDate(5, IntervalUnit.Second))
        .Build();
    }
  }
}
