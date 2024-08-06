namespace DataReader.DataAccess.Models
{
  public partial class User
  {
    public Guid UserSk { get; set; }
    public string? UserId { get; set; }
    public string? UserName { get; set; }
    public string? UserEmail { get; set; }
    public string? AnalyticsUpdatedDate { get; set; }
    public string? GitHubUserId { get; set; }
    public string? UserType { get; set; }

    public virtual ICollection<WorkItem> WorkItemActivatedByUserSkNavigations { get; set; } = new List<WorkItem>();

    public virtual ICollection<WorkItem> WorkItemAssignedToUserSkNavigations { get; set; } = new List<WorkItem>();

    public virtual ICollection<WorkItem> WorkItemChangedByUserSkNavigations { get; set; } = new List<WorkItem>();

    public virtual ICollection<WorkItem> WorkItemClosedByUserSkNavigations { get; set; } = new List<WorkItem>();

    public virtual ICollection<WorkItem> WorkItemCreatedByUserSkNavigations { get; set; } = new List<WorkItem>();

    public virtual ICollection<WorkItem> WorkItemResolvedByUserSkNavigations { get; set; } = new List<WorkItem>();
  }
}
