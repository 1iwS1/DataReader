using DataReader.Core.Models;
using DataReader.Core.ValueObjects;


namespace DataReader.Core.Commands.Users
{
  public class UpdateUserCommand
  {
    public required DataReaderGuid targetId { get; set; }
    public required User user { get; set; }
  }
}
