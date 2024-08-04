using DataReader.Core.ValueObjects;


namespace DataReader.Core.Queries.Projects
{
  public class GetByIdProjectQuery
  {
    public required DataReaderGuid id { get; set; }
  }
}
