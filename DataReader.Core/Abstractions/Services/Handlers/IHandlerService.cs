namespace DataReader.Core.Abstractions.Services.Handlers
{
  public interface IHandlerService<TResult, TListParamDTO>
  {
    TResult Parsing(string json);
    TResult Sync(TListParamDTO projects);
  }
}
