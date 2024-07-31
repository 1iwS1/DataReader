using DataReader.Core.Abstractions.Repositories;


namespace DataReader.DataAccess.Repositories
{
  public class ProjectsRepository : IProjectsRepository
  {
    private readonly DataDbContext _dbContext;

    public ProjectsRepository(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }


  }
}
