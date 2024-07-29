using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Contracts.Requests
{
  public class UsersRequest
  {

    private readonly List<UsersDTOParam> _list = new();
    public IReadOnlyCollection<UsersDTOParam> UsersRequestCollection => _list;
    public void AddUserRequests(List<UsersDTOParam> request) => _list.AddRange(request);
  }
}
