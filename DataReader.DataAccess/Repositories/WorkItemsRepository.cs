using DataReader.Core.Abstractions.Repositories;


namespace DataReader.DataAccess.Repositories
{
  public class WorkItemsRepository : IWorkItemsRepository
  {
    private readonly DataDbContext _dbContext;

    public WorkItemsRepository(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }


  }
}
