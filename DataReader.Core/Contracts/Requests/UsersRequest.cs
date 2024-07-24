using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Contracts.Requests
{
    public partial class UsersRequest
    {

        private readonly List<Param> _list = new();
        public IReadOnlyCollection<Param> UsersRequestCollection => _list;
        public void AddUserRequest(List<Param> request) => _list.AddRange(request);
    }
}
