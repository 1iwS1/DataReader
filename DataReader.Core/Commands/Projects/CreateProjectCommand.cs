using DataReader.Core.Models;


namespace DataReader.Core.Commands.Projects
{
  public class CreateProjectCommand
  {
    public required Project project { get; set; }
  }
}
