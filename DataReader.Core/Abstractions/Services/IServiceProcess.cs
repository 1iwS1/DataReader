namespace DataReader.Core.Abstractions.Services
{
  public interface IServiceProcess<TResult, TRequest>
  {
    TResult SyncProcess(TRequest request);
  }
}
