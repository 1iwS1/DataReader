using CSharpFunctionalExtensions;
using DataReader.Core.Contracts.Params;

namespace DataReader.Core.Abstractions.Services.Parsers
{
  public interface IJsonParserService<TResult>
  {
    TResult Parse(string json);
  }
}
