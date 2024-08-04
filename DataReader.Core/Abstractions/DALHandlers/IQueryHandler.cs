namespace DataReader.Core.Abstractions.DALHandlers
{
  public interface IQueryHandler<TResult, TQuery>
  {
    TResult Handle(TQuery query);
  }
}
