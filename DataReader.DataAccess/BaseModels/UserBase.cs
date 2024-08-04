using System.ComponentModel.DataAnnotations.Schema;

using DataReader.Core.ValueObjects.User;
using DataReader.Core.ValueObjects;


namespace DataReader.DataAccess.BaseModels
{
  public class UserBase
  {
    [Column("UserSK")]
    public DataReaderGuid? UserSK { get; set; }

    [Column("UserId")]
    public DataReaderGuid? UserId { get; set; }

    [Column("UserName")]
    public UserName? UserName { get; set; }

    [Column("UserEmail")]
    public UserEmail? UserEmail { get; set; }

    [Column("AnalyticsUpdatedDate")]
    public AnalyticsUpdatedDate? AnalyticsUpdatedDate { get; set; }
    public string GitHubUserId { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty;

    public List<WorkItemBase>? WorkItems { get; set; }
  }
}
