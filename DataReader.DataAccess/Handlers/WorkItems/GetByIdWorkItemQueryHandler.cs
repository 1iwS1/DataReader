using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Queries;


namespace DataReader.DataAccess.Handlers.WorkItems
{
    public class GetByIdWorkItemQueryHandler : IQueryHandler<Task<Result<bool>>, GetByIdWorkItemQuery>
  {
    private readonly DataDbContext _dbContext;

    public GetByIdWorkItemQueryHandler(DataDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(GetByIdWorkItemQuery command)
    {
      var workItemBase = await _dbContext.WorkItems
        .AsNoTracking()
        .FirstOrDefaultAsync(w => w.WorkItemId == command.id);

      if (workItemBase == null)
      {
        return false;
      }

      return true;
    }
  }
}
