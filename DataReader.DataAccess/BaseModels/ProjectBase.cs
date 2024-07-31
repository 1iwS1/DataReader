using DataReader.Core.ValueObjects.Project;
using DataReader.Core.ValueObjects;


namespace DataReader.DataAccess.BaseModels
{
  public class ProjectBase
  {
    public DataReaderGuid? ProjectSK { get; set; }
    public DataReaderGuid? ProjectID { get; set; }
    public ProjectName? ProjectName { get; set; }
    public AnalyticsUpdatedDate? AnalyticsUpdatedDate { get; set; }
    public string ProjectVisibility { get; set; } = string.Empty;
  }
}
