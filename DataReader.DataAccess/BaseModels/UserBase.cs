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

    public List<WorkItemBase>? AssignedWorkItems { get; set; }
    public List<WorkItemBase>? ChangedWorkItems { get; set; }
    public List<WorkItemBase>? CreatedWorkItems { get; set; }
    public List<WorkItemBase>? ActivatedWorkItems { get; set; }
    public List<WorkItemBase>? ClosedWorkItems { get; set; }
    public List<WorkItemBase>? ResolvedWorkItems { get; set; }
  }
}
