using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Quartz;

using DataReader.DataAccess;
using DataReader.ExternalAPI.DependencyInjection;


var builder = Host.CreateDefaultBuilder()
  .ConfigureServices((context, services) =>
  {
    services.AddDbContext<DataDbContext>(options =>
      options.UseSqlServer("")); // строка подключения

    services.AddQuartz();
    services.AddQuartzHostedService(q =>
    {
      q.WaitForJobsToComplete = true;
    });

    services.AddServices();

  }).Build();

await builder.RunAsync();
