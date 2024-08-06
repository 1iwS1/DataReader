using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Queries.WorkItems;


namespace DataReader.DataAccess.Handlers.WorkItems
{
    public class GetByIdWorkItemQueryHandler : IQueryHandler<Task<Result<bool>>, GetByIdWorkItemQuery>
  {
    private readonly DataAzureContext _dbContext;

    public GetByIdWorkItemQueryHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(GetByIdWorkItemQuery query)
    {
      var workItemBase = await _dbContext.WorkItems
        .AsNoTracking()
        .FirstOrDefaultAsync(w => w.WorkItemId == query.id);

      if (workItemBase == null)
      {
        return false;
      }

      return true;
    }
  }
}
