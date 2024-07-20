using DataReader.Core.ValueObjects.User;
using DataReader.Core.ValueObjects;

namespace DataReader.Core.Shells
{
  public record UserParam(
    DataReaderGuid userSK,
    DataReaderGuid userId,
    UserName userName,
    UserEmail userEmail,
    AnalyticsUpdatedDate analyticsUpdatedDate,
    DataReaderGuid gitHubUserId,
    string userType
  );
}
