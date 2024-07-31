using DataReader.Core.ValueObjects.Project;
using DataReader.Core.ValueObjects;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataReader.DataAccess.BaseModels
{
  public class ProjectBase
  {
    [Column("ProjectSK")]
    public DataReaderGuid? ProjectSK { get; set; }

    [Column("ProjectID")]
    public DataReaderGuid? ProjectID { get; set; }

    [Column("ProjectName")]
    public ProjectName? ProjectName { get; set; }

    [Column("AnalyticsUpdatedDate")]
    public AnalyticsUpdatedDate? AnalyticsUpdatedDate { get; set; }
    public string ProjectVisibility { get; set; } = string.Empty;

    public List<WorkItemBase>? WorkItems { get; set; }
  }
}
