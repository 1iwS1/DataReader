using DataReader.Core.Models;


namespace DataReader.Core.Commands.WorkItems
{
    public class UpdateWorkItemCommand
    {
        public int? targetId { get; set; }
        public required WorkItem workItem { get; set; }
    }
}
