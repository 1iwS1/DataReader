﻿using DataReader.Core.Abstractions.Services;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;
using DataReader.Core.Contracts.Params;
using DataReader.Core.Contracts.Requests;


namespace DataReader.Application.Handlers
{
  public class UserHandlerService : IUserHandlerService
  {
    private readonly IUsersService _usersService;
    private readonly IJsonParserService _jsonParserService;

    public UserHandlerService(/*IUsersService usersService, */IJsonParserService jsonParserService)
    {
      //_usersService = usersService;
      _jsonParserService = jsonParserService;
    }

    public async Task Sync(string json)
    {
      List<UsersDTOParam>? users = _jsonParserService.ParseUser(json).Value;

      UsersRequest usersRequest = new UsersRequest();
      usersRequest.AddUserRequest(users);

      //await _usersService.SyncUser(usersRequest);
    }
  }
}
