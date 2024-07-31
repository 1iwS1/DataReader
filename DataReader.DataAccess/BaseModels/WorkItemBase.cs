using DataReader.Core.ValueObjects;


namespace DataReader.DataAccess.BaseModels
{
  public class WorkItemBase
  {
    public int WorkItemId { get; set; }
    public AnalyticsUpdatedDate? InProgressDate { get; set; }
    public AnalyticsUpdatedDate? CompletedDate { get; set; }
    public string? InProgressDateSK { get; set; }
    public string? CompletedDateSK { get; set; }
    public AnalyticsUpdatedDate? AnalyticsUpdatedDate { get; set; }
    public int? WorkItemRevisionSK { get; set; }
    public DataReaderGuid? AreaSK { get; set; } // понадобятся в будущем
    public DataReaderGuid? IterationSK { get; set; } // понадобятся в будущем
    public string? ActivatedDateSK { get; set; }
    public string? ChangedDateSK { get; set; }
    public string? ClosedDateSK { get; set; }
    public string? CreatedDateSK { get; set; }
    public string? ResolvedDateSK { get; set; }
    public string? StateChangeDateSK { get; set; }
    public string? WorkItemType { get; set; }
    public AnalyticsUpdatedDate? ChangedDate { get; set; }
    public AnalyticsUpdatedDate? CreatedDate { get; set; }
    public string? State { get; set; }
    public AnalyticsUpdatedDate? ActivatedDate { get; set; }
    public AnalyticsUpdatedDate? ClosedDate { get; set; }
    public int? Priority { get; set; }
    public AnalyticsUpdatedDate? ResolvedDate { get; set; }
    public double? CompletedWork { get; set; }
    public string? Effort { get; set; }
    public AnalyticsUpdatedDate? FinishDate { get; set; }
    public string? OriginalEstimate { get; set; }
    public string? RemainingWork { get; set; }
    public string? StartDate { get; set; }
    public string? StoryPoints { get; set; }
    public string? TargetDate { get; set; }
    public int? ParentWorkItemId { get; set; }
    public string? TagNames { get; set; }
    public AnalyticsUpdatedDate? StateChangeDate { get; set; }
    public string? Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 { get; set; }
    public string? Custom_Company { get; set; }
    public string? Custom_Eksternareferenca { get; set; }
    public string? Custom_ITServiceorApplication { get; set; }
    public string? Custom_Statusprojekta { get; set; }
    public string? Custom_TicketNo { get; set; }

    public DataReaderGuid? AssignedToUserSK { get; set; } // foreign key Users
    public DataReaderGuid? ChangedByUserSK { get; set; } // foreign key Users
    public DataReaderGuid? CreatedByUserSK { get; set; } // foreign key Users
    public DataReaderGuid? ActivatedByUserSK { get; set; } // foreign key Users
    public DataReaderGuid? ClosedByUserSK { get; set; } // foreign key Users
    public DataReaderGuid? ResolvedByUserSK { get; set; } // foreign key Users
    public UserBase? User { get; set; }

    public DataReaderGuid? ProjectSK { get; set; } // foreign key to Project (1:1)
    public ProjectBase? Project { get; set; }

  }
}
