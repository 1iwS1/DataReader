using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Quartz;

using DataReader.DataAccess;
using DataReader.ExternalAPI.DependencyInjection;
using DataReader.ExternalAPI.Scheduler;


var builder = Host.CreateDefaultBuilder()
  .ConfigureServices((context, services) =>
  {
    services.AddDbContext<DataAzureContext>(options =>
      options.UseSqlServer("Server=DESKTOP-UCP7EO7;Database=DataAzure;Trusted_Connection=True;TrustServerCertificate=true;"));

    services.AddQuartz();
    services.AddQuartzHostedService(q =>
    {
      q.WaitForJobsToComplete = true;
    });

    services.AddServices();
    services.AddControllers();

  }).Build();

QuartzScheduler quartzScheduler = new(builder);
IScheduler scheduler = await quartzScheduler.GetSchedulerAndJob();
ITrigger trigger = (ITrigger)quartzScheduler.triggers["secondly"]!;

await scheduler.ScheduleJob(quartzScheduler.Job!, trigger);

await builder.RunAsync();
