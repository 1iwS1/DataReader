using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Models;


namespace DataReader.ExternalAPI.Controllers
{
  public class UserController
  {
    private readonly IHandlerService<Task<Result>, List<UsersDTOParam>> _usersHandler;

    public UserController(IHandlerService<Task<Result>, List<UsersDTOParam>> usersHandler)
    {
      _usersHandler = usersHandler;
    }

    public async Task<Result> GetDataByODataProtocol()
    {
      return new Result<Log>();
    }

    private async Task<Result> DoUsersParsing(string json)
    {
      return new Result<Log>();
    }
  }
}
