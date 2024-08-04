using DataReader.Core.ValueObjects;


namespace DataReader.Core.Queries.Users
{
    public class GetByIdUserQuery
    {
        public required DataReaderGuid id { get; set; }
    }
}
