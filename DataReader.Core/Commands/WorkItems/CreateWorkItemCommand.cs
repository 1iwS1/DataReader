using DataReader.Core.Models;


namespace DataReader.Core.Commands.WorkItems
{
    public class CreateWorkItemCommand
    {
        public required WorkItem workItem { get; set; }
    }
}
