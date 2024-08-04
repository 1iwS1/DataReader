using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Queries.Users;


namespace DataReader.DataAccess.Handlers.Users
{
  public class GetByIdUserQueryHandler : IQueryHandler<Task<Result<bool>>, GetByIdUserQuery>
  {
    private readonly DataDbContext _dbContext;

    public GetByIdUserQueryHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(GetByIdUserQuery query)
    {
      var userBase = await _dbContext.Users
        .AsNoTracking()
        .FirstOrDefaultAsync(u => u.UserId == query.id);

      if (userBase == null)
      {
        return false;
      }

      return true;
    }
  }
}
