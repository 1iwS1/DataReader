using DataReader.Core.Models;


namespace DataReader.Core.Commands.Logs
{
  public class CreateLogCommand
  {
    public required Log log { get; set; }
  }
}
