using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Contracts.Requests
{
  public partial class UsersRequest
  {

    private readonly List<UsersDTOParam> _list = new();
    public IReadOnlyCollection<UsersDTOParam> UsersRequestCollection => _list;
    public void AddUserRequest(List<UsersDTOParam> request) => _list.AddRange(request);
  }
}
