namespace DataReader.Core.Abstractions.DALHandlers
{
  public interface ICommandHandler<TResult, TCommand>
  {
    TResult Handle(TCommand command);
  }
}
