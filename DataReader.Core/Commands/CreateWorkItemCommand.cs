using DataReader.Core.Models;

namespace DataReader.DataAccess.Commands
{
  public class CreateWorkItemCommand
  {
    public required WorkItem workItem { get; set; }
  }
}
