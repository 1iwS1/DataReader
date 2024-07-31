using DataReader.Core.ValueObjects.User;
using DataReader.Core.ValueObjects;

namespace DataReader.DataAccess.BaseModels
{
  public class UserBase
  {
    public DataReaderGuid? UserSK { get; set; }
    public DataReaderGuid? UserId { get; set; }
    public UserName? UserName { get; set; }
    public UserEmail? UserEmail { get; set; }
    public AnalyticsUpdatedDate? AnalyticsUpdatedDate { get; set; }
    public string GitHubUserId { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty;

    public List<WorkItemBase>? WorkItems { get; set; }
  }
}
