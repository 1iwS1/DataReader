namespace DataReader.Core.Abstractions.Services.Handlers
{
  public interface IUserHandlerService
  {
    Task Sync(string json);
  }
}
