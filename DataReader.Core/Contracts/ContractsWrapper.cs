namespace DataReader.Core.Contracts
{
  public class ContractsWrapper
  {
    private readonly List<UsersRequest> _usersRequests = new();
    public IReadOnlyCollection<UsersRequest> UsersRequestCollection => _usersRequests;
    public void AddUsersRequests(List<UsersRequest> requests) => _usersRequests.AddRange(requests);

    private readonly List<LogRequest> _logsRequests = new();
    public IReadOnlyCollection<LogRequest> LogsRequestsCollection => _logsRequests;
    public void AddLogRequests(List<LogRequest> requests) => _logsRequests.AddRange(requests);

    private readonly List<ProjectsRequest> _projectsRequests = new();
    public IReadOnlyCollection<ProjectsRequest> ProjectsRequestsCollection => _projectsRequests;
    public void AddLogRequests(List<ProjectsRequest> requests) => _projectsRequests.AddRange(requests);

    private readonly List<WorkItemsRequest> _workItemsRequests = new();
    public IReadOnlyCollection<WorkItemsRequest> WorkItemsRequestsCollection => _workItemsRequests;
    public void AddLogRequests(List<WorkItemsRequest> requests) => _workItemsRequests.AddRange(requests);
  }
}
