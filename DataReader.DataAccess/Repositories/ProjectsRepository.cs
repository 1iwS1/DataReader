//using Microsoft.EntityFrameworkCore;
//using CSharpFunctionalExtensions;

//using DataReader.Core.Abstractions.Repositories;
//using DataReader.Core.Models;
//using DataReader.Core.ValueObjects;
//using DataReader.DataAccess.BaseModels;


//namespace DataReader.DataAccess.Repositories
//{
//  public class ProjectsRepository : IProjectsRepository
//  {
//    private readonly DataDbContext _dbContext;

//    public ProjectsRepository(DataDbContext dbContext)
//    {
//      _dbContext = dbContext;
//    }

//    public async Task<Result<bool>> GetById(DataReaderGuid id)
//    {
//      var projectBase = await _dbContext.Projects
//        .AsNoTracking()
//        .FirstOrDefaultAsync(p => p.ProjectID == id);

//      if (projectBase == null)
//      {
//        return false;
//      }

//      return true;
//    }

//    public async Task<Result<bool>> Create(Project project)
//    {
//      var projectBase = new ProjectBase
//      {
//        ProjectSK = project.ProjectSK,
//        ProjectID = project.ProjectID,
//        ProjectName = project.ProjectName,
//        AnalyticsUpdatedDate = project.AnalyticsUpdatedDate,
//        ProjectVisibility = project.ProjectVisibility
//      };

//      await _dbContext.AddAsync(projectBase);
//      await _dbContext.SaveChangesAsync();

//      return true;
//    }

//    public async Task<Result<bool>> Update(DataReaderGuid targetId, Project project)
//    {
//      await _dbContext.Projects
//       .Where(p => p.ProjectID == targetId)
//       .ExecuteUpdateAsync(u => u
//         .SetProperty(x => x.ProjectName, x => project.ProjectName)
//         .SetProperty(x => x.AnalyticsUpdatedDate, x => project.AnalyticsUpdatedDate)
//         .SetProperty(x => x.ProjectVisibility, x => project.ProjectVisibility));

//      return true;
//    }
//  }
//}
