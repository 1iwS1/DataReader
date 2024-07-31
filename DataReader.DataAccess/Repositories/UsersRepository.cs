using DataReader.Core.Abstractions.Repositories;


namespace DataReader.DataAccess.Repositories
{
  public class UsersRepository : IUsersRepository
  {
    private readonly DataDbContext _dbContext;

    public UsersRepository(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }


  }
}
