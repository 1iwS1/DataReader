namespace DataReader.Core.Abstractions.Services
{
  public interface IUserHandlerService
  {
    Task Sync(string json);
  }
}
