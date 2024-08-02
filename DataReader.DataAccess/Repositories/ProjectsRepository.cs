using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Repositories;
using DataReader.Core.Models;
using DataReader.Core.ValueObjects;
using DataReader.Core.Shells;
using DataReader.DataAccess.BaseModels;


namespace DataReader.DataAccess.Repositories
{
  public class ProjectsRepository : IProjectsRepository
  {
    private readonly DataDbContext _dbContext;

    public ProjectsRepository(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<Project>> GetById(DataReaderGuid id)
    {
      var projectBase = await _dbContext.Projects
        .AsNoTracking()
        .FirstOrDefaultAsync(p => p.ProjectID == id);

      if (projectBase == null)
      {
        return Result.Failure<Project>(nameof(projectBase));
      }

      Result<Project> project = Project.Create(new ProjectParam(
        projectBase.ProjectSK!, 
        projectBase.ProjectID!, 
        projectBase.ProjectName!,
        projectBase.AnalyticsUpdatedDate!,
        projectBase.ProjectVisibility
        ));

      return project;
    }

    public async Task<Result> Create(Project project)
    {
      var projectBase = new ProjectBase
      {
        ProjectSK = project.ProjectSK,
        ProjectID = project.ProjectID,
        ProjectName = project.ProjectName,
        AnalyticsUpdatedDate = project.AnalyticsUpdatedDate,
        ProjectVisibility = project.ProjectVisibility
      };

      await _dbContext.AddAsync(projectBase);
      await _dbContext.SaveChangesAsync();

      return Result.Success<Project>(project);
    }

    public async Task<Result> Update(DataReaderGuid targetId, Project project)
    {
      await _dbContext.Projects
       .Where(p => p.ProjectID == targetId)
       .ExecuteUpdateAsync(u => u
         .SetProperty(x => x.ProjectName, x => project.ProjectName)
         .SetProperty(x => x.AnalyticsUpdatedDate, x => project.AnalyticsUpdatedDate)
         .SetProperty(x => x.ProjectVisibility, x => project.ProjectVisibility));

      return Result.Success<Project>(project);
    }
  }
}
