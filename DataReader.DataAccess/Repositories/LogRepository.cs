using DataReader.Core.Abstractions.Repositories;


namespace DataReader.DataAccess.Repositories
{
  public class LogRepository : ILogsRepository
  {
    private readonly DataDbContext _dbContext;

    public LogRepository(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }


  }
}
