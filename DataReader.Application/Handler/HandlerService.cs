using DataReader.Application.SyncProcess;
using DataReader.Core.Abstractions.UseCases;


namespace DataReader.Application.Handler
{
  public class HandlerService
  {
    private ISync _sync;

    public async Task UsersHandle(string json)
    {
      _sync = DoMakeSync();
    }

    public override ISync DoMakeSync()
    {
      return new UsersSync();
    }
  }
}
