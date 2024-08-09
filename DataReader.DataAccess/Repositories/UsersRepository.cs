//using Microsoft.EntityFrameworkCore;
//using CSharpFunctionalExtensions;

//using DataReader.Core.Abstractions.Repositories;
//using DataReader.Core.Models;
//using DataReader.Core.ValueObjects;
//using DataReader.DataAccess.BaseModels;


//namespace DataReader.DataAccess.Repositories
//{
//  public class UsersRepository : IUsersRepository
//  {
//    private readonly DataDbContext _dbContext;

//    public UsersRepository(DataDbContext dbContext)
//    {
//      _dbContext = dbContext;
//    }

//    public async Task<Result<bool>> GetById(DataReaderGuid id)
//    {
//      var userBase = await _dbContext.Users
//        .AsNoTracking()
//        .FirstOrDefaultAsync(u => u.UserId == id);

//      if (userBase == null)
//      {
//        return false;
//      }

//      return true;
//    }

//    public async Task<Result<bool>> Create(User user)
//    {
//      var userBase = new UserBase
//      {
//        UserSK = user.UserSK,
//        UserId = user.UserId,
//        UserName = user.UserName,
//        UserEmail = user.UserEmail,
//        AnalyticsUpdatedDate = user.AnalyticsUpdatedDate,
//        GitHubUserId = user.GitHubUserId,
//        UserType = user.UserType
//      };

//      await _dbContext.AddAsync(userBase);
//      await _dbContext.SaveChangesAsync();

//      return true;
//    }

//    public async Task<Result<bool>> Update(DataReaderGuid targetId, User user)
//    {
//      await _dbContext.Users
//        .Where(u => u.UserId == targetId)
//        .ExecuteUpdateAsync(u => u
//          .SetProperty(x => x.UserName, x => user.UserName)
//          .SetProperty(x => x.UserEmail, x => user.UserEmail)
//          .SetProperty(x => x.AnalyticsUpdatedDate, x => user.AnalyticsUpdatedDate)
//          .SetProperty(x => x.GitHubUserId, x => user.GitHubUserId)
//          .SetProperty(x => x.UserType, x => user.UserType));

//      return true;
//    }
//  }
//}
