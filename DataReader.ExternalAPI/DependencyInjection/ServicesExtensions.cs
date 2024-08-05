using Microsoft.Extensions.DependencyInjection;
using CSharpFunctionalExtensions;

using DataReader.Application.Handlers;
using DataReader.Application.ModelsServices;
using DataReader.Application.ParseProcess;
using DataReader.Application.Services;
using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Abstractions.Services;
using DataReader.Core.Commands.Logs;
using DataReader.Core.Commands.Projects;
using DataReader.Core.Commands.Users;
using DataReader.Core.Commands.WorkItems;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;
using DataReader.Core.Queries.Logs;
using DataReader.Core.Queries.Projects;
using DataReader.Core.Queries.Users;
using DataReader.Core.Queries.WorkItems;
using DataReader.DataAccess.Handlers.Logs;
using DataReader.DataAccess.Handlers.Projects;
using DataReader.DataAccess.Handlers.Users;
using DataReader.DataAccess.Handlers.WorkItems;


namespace DataReader.ExternalAPI.DependencyInjection
{
  public static class ServicesExtensions
  {
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
      services.AddScoped<ILogHandlerService, LogHandlerService>();
      services.AddScoped<IHandlerService<Task<Result>, List<ProjectsDTOParam>>, ProjectHandlerService>();
      services.AddScoped<IHandlerService<Task<Result>, List<UsersDTOParam>>, UserHandlerService>();
      services.AddScoped<IHandlerService<Task<Result>, List<WorkItemsDTOParam>>, WorkItemHandlerService>();

      services.AddScoped<ILogsService, LogsService>();
      services.AddScoped<IServiceProcess<Task<Result>, ProjectsRequest>, ProjectsService>();
      services.AddScoped<IServiceProcess<Task<Result>, UsersRequest>, UsersService>();
      services.AddScoped<IServiceProcess<Task<Result>, WorkItemsRequest>, WorkItemsService>();

      services.AddScoped<IJsonParserService<Result<List<ProjectsDTOParam>?>>, ProjectsJsonParserService>();
      services.AddScoped<IJsonParserService<Result<List<UsersDTOParam>?>>, UsersJsonParserService>();
      services.AddScoped<IJsonParserService<Result<List<WorkItemsDTOParam>?>>, WorkItemsJsonParserService>();

      services.AddScoped<ICommandHandler<Task<Result>, CreateLogCommand>, CreateLogCommandHandler>();
      services.AddScoped<IQueryHandler<Task<Result<Log>>, GetLastSuccessfulLogQuery>, GetLastSuccessfulLogQueryHandler>();

      services.AddScoped<ICommandHandler<Task<Result<bool>>, UpdateProjectCommand>, UpdateProjectCommandHandler>();
      services.AddScoped<IQueryHandler<Task<Result<bool>>, GetByIdProjectQuery>, GetByIdProjectQueryHandler>();
      services.AddScoped<ICommandHandler<Task<Result<bool>>, CreateProjectCommand>, CreateProjectCommandHandler>();

      services.AddScoped<ICommandHandler<Task<Result<bool>>, UpdateUserCommand>, UpdateUserCommandHandler>();
      services.AddScoped<IQueryHandler<Task<Result<bool>>, GetByIdUserQuery>, GetByIdUserQueryHandler>();
      services.AddScoped<ICommandHandler<Task<Result<bool>>, CreateUserCommand>, CreateUserCommandHandler>();

      services.AddScoped<ICommandHandler<Task<Result<bool>>, UpdateWorkItemCommand>, UpdateWorkItemCommandHandler>();
      services.AddScoped<IQueryHandler<Task<Result<bool>>, GetByIdWorkItemQuery>, GetByIdWorkItemQueryHandler>();
      services.AddScoped<ICommandHandler<Task<Result<bool>>, CreateWorkItemCommand>, CreateWorkItemCommandHandler>();

      //services.AddScoped<ILogsRepository, LogRepository>();
      //services.AddScoped<IProjectsRepository, ProjectsRepository>();
      //services.AddScoped<IUsersRepository, UsersRepository>();
      //services.AddScoped<IWorkItemsRepository, WorkItemsRepository>();

      return services;
    }
  }
}
