﻿using DataReader.Core.Abstractions.UseCases;
using DataReader.Core.Contracts;


namespace DataReader.Application.SyncProcess
{
  public class UsersSync : ISync
  {
    private readonly IRead _usersRead;
    private readonly IWrite _usersWrite;
    private readonly IUpdate _usersUpdate;

    public UsersSync(IRead usersRead, IWrite usersWrite, IUpdate usersUpdate)
    {
      _usersRead = usersRead;
      _usersWrite = usersWrite;
      _usersUpdate = usersUpdate;
    }

    public async Task Synchronisation(List<UsersRequest> requests)
    {

    }
  }
}
