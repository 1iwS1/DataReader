using DataReader.Core.Contracts.Params;
using DataReader.Core.Shells;


namespace DataReader.Core.Contracts.Requests
{
  public class WorkItemsRequest
  {
    private readonly List<WorkItemsDTOParam> _list = new();
    public IReadOnlyCollection<WorkItemsDTOParam> WorkItemsRequestCollection => _list;
    public void AddWorkItemRequests(List<WorkItemsDTOParam> request) => _list.AddRange(request);
  }
}
