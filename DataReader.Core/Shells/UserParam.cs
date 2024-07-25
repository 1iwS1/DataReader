using DataReader.Core.ValueObjects.User;
using DataReader.Core.ValueObjects;

namespace DataReader.Core.Shells
{
  public record UserParam(
    string userSK,
    string userId,
    string userName,
    string userEmail,
    string analyticsUpdatedDate,
    string gitHubUserId,
    string userType
  );
}
