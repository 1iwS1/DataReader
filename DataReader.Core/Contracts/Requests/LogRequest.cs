using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Contracts.Requests
{
  public class LogsRequest
  {
    private readonly List<LogsDTOParam> _list = new();
    public IReadOnlyCollection<LogsDTOParam> LogsRequestCollection => _list.AsReadOnly();
    public void AddLogRequests(List<LogsDTOParam> request) => _list.AddRange(request);
  }
}
