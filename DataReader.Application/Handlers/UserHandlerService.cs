using CSharpFunctionalExtensions;

using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;
using DataReader.Core.Models;


namespace DataReader.Application.Handlers
{
  public class UserHandlerService : IUserHandlerService
  {
    private readonly IUsersService _usersService;
    private readonly IUsersJsonParserService _jsonParserService;

    public UserHandlerService(/*IUsersService usersService, */IUsersJsonParserService jsonParserService)
    {
      //_usersService = usersService;
      _jsonParserService = jsonParserService;
    }

    public async Task<Result> Parsing(string json)
    {
      Result<List<UsersDTOParam>?> users = _jsonParserService.ParseUser(json);

      if (users.IsFailure)
      {
        return users;
      }

      if (users.Value?.Count == 0)
      {
        return new Result();
      }

      return await Sync(users.Value);
    }

    public async Task<Result> Sync(List<UsersDTOParam>? users)
    {
      UsersRequest usersRequest = new UsersRequest();
      usersRequest.AddUserRequests(users);

      //return await _usersService.SyncUser(usersRequest);
      throw new NotImplementedException();
    }
  }
}
