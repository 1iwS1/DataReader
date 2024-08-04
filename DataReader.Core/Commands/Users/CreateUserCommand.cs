using DataReader.Core.Models;


namespace DataReader.Core.Commands.Users
{
  public class CreateUserCommand
  {
    public required User user { get; set; }
  }
}
