using DataReader.Application.SyncProcess;
using DataReader.Core.Abstractions.UseCases;


namespace DataReader.Application.Handler
{
  public class HandlerService
  {
    private readonly ISync _sync;

    public HandlerService(ISync sync)
    {
      _sync = sync;
    }

    public async Task UsersHandle(string json)
    {
      // парсинг

      await _sync.Synchronisation();
    }

    public async Task LogsHandle(string json)
    {
      // парсинг

      await _sync.Synchronisation();
    }

    public async Task ProjectsHandle(string json)
    {
      // парсинг

      await _sync.Synchronisation();
    }

    public async Task WorkItemsHandle(string json)
    {
      // парсинг

      await _sync.Synchronisation();
    }
  }
}
