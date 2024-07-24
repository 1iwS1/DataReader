using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Contracts.Requests
{
    public partial class UsersRequest
    {

        private readonly List<DTOParam> _list = new();
        public IReadOnlyCollection<DTOParam> UsersRequestCollection => _list;
        public void AddUserRequest(List<DTOParam> request) => _list.AddRange(request);
    }
}
