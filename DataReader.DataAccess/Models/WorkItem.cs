namespace DataReader.DataAccess.Models
{
  public partial class WorkItem
  {
    public int WorkItemId { get; set; }
    public string? InProgressDate { get; set; }
    public string? CompletedDate { get; set; }
    public string? InProgressDateSk { get; set; }
    public string? CompletedDateSk { get; set; }
    public string? AnalyticsUpdatedDate { get; set; }
    public int? WorkItemRevisionSk { get; set; }
    public Guid? AreaSk { get; set; }
    public Guid? IterationSk { get; set; }
    public string? ActivatedDateSk { get; set; }
    public string? ChangedDateSk { get; set; }
    public string? ClosedDateSk { get; set; }
    public string? CreatedDateSk { get; set; }
    public string? ResolvedDateSk { get; set; }
    public string? StateChangeDateSk { get; set; }
    public string? WorkItemType { get; set; }
    public string? ChangedDate { get; set; }
    public string? CreatedDate { get; set; }
    public string? State { get; set; }
    public string? ActivatedDate { get; set; }
    public string? ClosedDate { get; set; }
    public int? Priority { get; set; }
    public string? ResolvedDate { get; set; }
    public decimal? CompletedWork { get; set; }
    public string? Effort { get; set; }
    public string? FinishDate { get; set; }
    public string? OriginalEstimate { get; set; }
    public string? RemainingWork { get; set; }
    public string? StartDate { get; set; }
    public string? StoryPoints { get; set; }
    public string? TargetDate { get; set; }
    public int? ParentWorkItemId { get; set; }
    public string? TagNames { get; set; }
    public string? StateChangeDate { get; set; }
    public string? Custom719f69f1002df7d0002d4baa002db6ce002de77ad5dfcdf3 { get; set; }
    public string? CustomCompany { get; set; }
    public string? CustomEksternareferenca { get; set; }
    public string? CustomItserviceorApplication { get; set; }
    public string? CustomStatusprojekta { get; set; }
    public string? CustomTicketNo { get; set; }
    public Guid? AssignedToUserSk { get; set; }
    public Guid? ChangedByUserSk { get; set; }
    public Guid? CreatedByUserSk { get; set; }
    public Guid? ActivatedByUserSk { get; set; }
    public Guid? ClosedByUserSk { get; set; }
    public Guid? ResolvedByUserSk { get; set; }
    public Guid? ProjectSk { get; set; }

    public virtual User? ActivatedByUserSkNavigation { get; set; }

    public virtual User? AssignedToUserSkNavigation { get; set; }

    public virtual User? ChangedByUserSkNavigation { get; set; }

    public virtual User? ClosedByUserSkNavigation { get; set; }

    public virtual User? CreatedByUserSkNavigation { get; set; }

    public virtual Project? ProjectSkNavigation { get; set; }

    public virtual User? ResolvedByUserSkNavigation { get; set; }
  }
}
