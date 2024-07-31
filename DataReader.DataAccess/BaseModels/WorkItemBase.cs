using System.ComponentModel.DataAnnotations.Schema;

using DataReader.Core.ValueObjects;


namespace DataReader.DataAccess.BaseModels
{
  public class WorkItemBase
  {
    public int WorkItemId { get; set; }

    [Column("InProgressDate")]
    public AnalyticsUpdatedDate? InProgressDate { get; set; }

    [Column("CompletedDate")]
    public AnalyticsUpdatedDate? CompletedDate { get; set; }
    public string? InProgressDateSK { get; set; }
    public string? CompletedDateSK { get; set; }

    [Column("AnalyticsUpdatedDate")]
    public AnalyticsUpdatedDate? AnalyticsUpdatedDate { get; set; }
    public int? WorkItemRevisionSK { get; set; }

    [Column("AreaSK")]
    public DataReaderGuid? AreaSK { get; set; } // понадобятся в будущем

    [Column("IterationSK")]
    public DataReaderGuid? IterationSK { get; set; } // понадобятся в будущем
    public string? ActivatedDateSK { get; set; }
    public string? ChangedDateSK { get; set; }
    public string? ClosedDateSK { get; set; }
    public string? CreatedDateSK { get; set; }
    public string? ResolvedDateSK { get; set; }
    public string? StateChangeDateSK { get; set; }
    public string? WorkItemType { get; set; }

    [Column("ChangedDate")]
    public AnalyticsUpdatedDate? ChangedDate { get; set; }

    [Column("CreatedDate")]
    public AnalyticsUpdatedDate? CreatedDate { get; set; }
    public string? State { get; set; }

    [Column("ActivatedDate")]
    public AnalyticsUpdatedDate? ActivatedDate { get; set; }

    [Column("ClosedDate")]
    public AnalyticsUpdatedDate? ClosedDate { get; set; }
    public int? Priority { get; set; }

    [Column("ResolvedDate")]
    public AnalyticsUpdatedDate? ResolvedDate { get; set; }
    public double? CompletedWork { get; set; }
    public string? Effort { get; set; }

    [Column("FinishDate")]
    public AnalyticsUpdatedDate? FinishDate { get; set; }
    public string? OriginalEstimate { get; set; }
    public string? RemainingWork { get; set; }
    public string? StartDate { get; set; }
    public string? StoryPoints { get; set; }
    public string? TargetDate { get; set; }
    public int? ParentWorkItemId { get; set; }
    public string? TagNames { get; set; }

    [Column("StateChangeDate")]
    public AnalyticsUpdatedDate? StateChangeDate { get; set; }
    public string? Custom_719f69f1__002Df7d0__002D4baa__002Db6ce__002De77ad5dfcdf3 { get; set; }
    public string? Custom_Company { get; set; }
    public string? Custom_Eksternareferenca { get; set; }
    public string? Custom_ITServiceorApplication { get; set; }
    public string? Custom_Statusprojekta { get; set; }
    public string? Custom_TicketNo { get; set; }

    [Column("AssignedToUserSK")]
    public DataReaderGuid? AssignedToUserSK { get; set; } // foreign key Users

    [Column("ChangedByUserSK")]
    public DataReaderGuid? ChangedByUserSK { get; set; } // foreign key Users

    [Column("CreatedByUserSK")]
    public DataReaderGuid? CreatedByUserSK { get; set; } // foreign key Users

    [Column("ActivatedByUserSK")]
    public DataReaderGuid? ActivatedByUserSK { get; set; } // foreign key Users

    [Column("ClosedByUserSK")]
    public DataReaderGuid? ClosedByUserSK { get; set; } // foreign key Users

    [Column("ResolvedByUserSK")]
    public DataReaderGuid? ResolvedByUserSK { get; set; } // foreign key Users
    public UserBase? User { get; set; }

    [Column("ProjectSK")]
    public DataReaderGuid? ProjectSK { get; set; } // foreign key to Project (1:1)
    public ProjectBase? Project { get; set; }

  }
}
