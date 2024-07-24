using DataReader.Core.Abstractions.Services;


namespace DataReader.Application.Handler
{
  public class UserHandlerService
  {
    private readonly IUsersService _usersService;

    public UserHandlerService(IUsersService usersService)
    {
      _usersService = usersService;
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
