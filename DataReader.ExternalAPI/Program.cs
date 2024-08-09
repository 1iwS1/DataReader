using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Quartz;

using DataReader.DataAccess;
using DataReader.ExternalAPI.DependencyInjection;
using DataReader.ExternalAPI.Scheduler;
using DataReader.ExternalAPI.Properties.Configs.ClassConfigs;


HostApplicationBuilder builder = Host.CreateApplicationBuilder();

string absolutePath = "C:\\Users\\Максим\\OneDrive\\Рабочий стол\\Работа\\Project\\" +
    "DataReader\\DataReader.ExternalAPI\\Properties\\Configs\\";

builder.Configuration
  .AddJsonFile($"{absolutePath}appsettings.json", true, true)
  .AddJsonFile($"{absolutePath}secrets.json", true, true)
  .AddJsonFile($"{absolutePath}connect.json", true, true);

builder.Services.Configure<Secrets>(
  builder.Configuration.GetSection(
    key: nameof(Secrets)));

var connectionOptions = builder.Configuration.GetSection("GetConnectionString")
  .Get<ConnectionString>();

var intervalOptions = builder.Configuration.GetSection(nameof(IntervalForSynchronisation))
  .Get<IntervalForSynchronisation>();

builder.Services
  .AddDbContext<DataAzureContext>(options => options.UseSqlServer(connectionOptions!.SqlServerConnection))
  .AddQuartz()
  .AddQuartzHostedService(q =>
  {
    q.WaitForJobsToComplete = true;
  })
  .AddServices()
  .AddControllers();


using IHost host = builder.Build();

QuartzScheduler quartzScheduler = new(host);
IScheduler scheduler = await quartzScheduler.GetSchedulerAndJob();
ITrigger trigger = (ITrigger)quartzScheduler.triggers[intervalOptions!.Interval]!;

await scheduler.ScheduleJob(quartzScheduler.Job!, trigger);

await host.RunAsync();
