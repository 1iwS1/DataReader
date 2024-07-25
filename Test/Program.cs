using DataReader.Application.Handlers;
using DataReader.Application.ParseProcess;
using DataReader.Core.Abstractions.Services.Handlers;
using DataReader.Core.Abstractions.Services.Parsers;


public class Program
{
  public static async void Main(string[] args)
  {
    string json = ;

    IJsonParserService jsonParserService = new JsonParserService();
    IUserHandlerService userHandlerService = new UserHandlerService(jsonParserService);
    await userHandlerService.Sync(json);
  }
}
