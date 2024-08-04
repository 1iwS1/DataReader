using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Commands.Projects
{
  public class UpdateProjectCommand
  {
    public required DataReaderGuid targetId { get; set; }
    public required Project project { get; set; }
  }
}
