using CSharpFunctionalExtensions;
using System.Text;

using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.ExternalAPI.Controllers.Common;
using DataReader.Core.Contracts.Params;


namespace DataReader.ExternalAPI.Controllers
{
  public class UserController
  {
    private readonly IHandlerService<Task<Result>, List<UsersDTOParam>> _usersHandler;

    public UserController(IHandlerService<Task<Result>, List<UsersDTOParam>> usersHandler)
    {
      _usersHandler = usersHandler;
    }

    public async Task<Result> GetDataByODataProtocol(string pat)
    {
      try
      {
        string result = "";
        string dataObject = "Users";
        string filter = "?$select=*";
        StringBuilder query = new StringBuilder($"{dataObject}{filter}");

        result = await AzureClient.GetFromAzure(query.ToString(), pat);

        return await DoUsersParsing(result);
      }

      catch (Exception ex)
      {
        return Result.Failure(ex.Message);
      } 
    }

    private async Task<Result> DoUsersParsing(string json)
    {
      return await _usersHandler.Parsing(json);
    }
  }
}
