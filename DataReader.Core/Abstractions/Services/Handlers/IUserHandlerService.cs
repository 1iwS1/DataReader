﻿using CSharpFunctionalExtensions;

using DataReader.Core.Contracts.Params;


namespace DataReader.Core.Abstractions.Services.Handlers
{
  public interface IUserHandlerService
  {
    Task<Result> Sync(List<UsersDTOParam> users);
    Task<Result> Parsing(string json);
  }
}
