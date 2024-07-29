using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Contracts.Requests
{
  public class ProjectsRequest
  {
    private readonly List<ProjectsDTOParam> _list = new();
    public IReadOnlyCollection<ProjectsDTOParam> ProjectsRequestCollection => _list;
    public void AddProjectRequests(List<ProjectsDTOParam> request) => _list.AddRange(request);
  }
}
