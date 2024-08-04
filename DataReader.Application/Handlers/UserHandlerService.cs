using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;


namespace DataReader.Application.Handlers
{
  public class UserHandlerService : IHandlerService<Task<Result>, List<UsersDTOParam>>
  {
    private readonly IServiceProcess<Task<Result>, UsersRequest> _usersService;
    private readonly IJsonParserService<Result<List<UsersDTOParam>?>> _jsonParserService;

    public UserHandlerService(
      IServiceProcess<Task<Result>, UsersRequest> usersService,
      IJsonParserService<Result<List<UsersDTOParam>?>> jsonParserService
      )
    {
      _usersService = usersService;
      _jsonParserService = jsonParserService;
    }

    public async Task<Result> Parsing(string json)
    {
      Result<List<UsersDTOParam>?> users = _jsonParserService.Parse(json);

      if (users.IsFailure)
      {
        return users;
      }

      if (users.Value?.Count == 0)
      {
        return Result.Success();
      }

      return await Sync(users.Value!);
    }

    public async Task<Result> Sync(List<UsersDTOParam> users)
    {
      UsersRequest usersRequest = new();
      usersRequest.AddUserRequests(users);

      return await _usersService.SyncProcess(usersRequest);
      //throw new NotImplementedException();
    }
  }
}
