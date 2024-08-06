using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.DALHandlers;
using DataReader.Core.Queries.Projects;


namespace DataReader.DataAccess.Handlers.Projects
{
  public class GetByIdProjectQueryHandler : IQueryHandler<Task<Result<bool>>, GetByIdProjectQuery>
  {
    private readonly DataAzureContext _dbContext;

    public GetByIdProjectQueryHandler(DataAzureContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<Result<bool>> Handle(GetByIdProjectQuery query)
    {
      var projectBase = await _dbContext.Projects
        .AsNoTracking()
        .FirstOrDefaultAsync(p => p.ProjectId == query.id.CustomGuid);

      if (projectBase == null)
      {
        return false;
      }

      return true;
    }
  }
}
