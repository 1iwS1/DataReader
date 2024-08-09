using CSharpFunctionalExtensions;


namespace DataReader.Core.ValueObjects.Extensions
{
  public static class DataReaderGuidExtension
  {
    public static Result<DataReaderGuid> Validate(this Result<DataReaderGuid> dataReaderGuid)
    {
      if (dataReaderGuid.IsFailure)
      {
        throw new ArgumentException(dataReaderGuid.Error);
      }

      return dataReaderGuid;
    }
  }
}
