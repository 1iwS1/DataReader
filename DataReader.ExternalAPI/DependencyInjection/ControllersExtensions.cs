using Microsoft.Extensions.DependencyInjection;

using DataReader.ExternalAPI.Controllers;


namespace DataReader.ExternalAPI.DependencyInjection
{
  public static class ControllersExtensions
  {
    public static IServiceCollection AddControllers(this IServiceCollection services)
    {
      services.AddTransient<MainControllerJob>();
      services.AddTransient<LogController>();
      services.AddTransient<UserController>();
      services.AddTransient<ProjectController>();
      services.AddTransient<WorkItemController>();

      return services;
    }
  }
}
