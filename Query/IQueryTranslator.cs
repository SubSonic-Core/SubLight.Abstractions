using System.Linq.Expressions;

namespace SubLight.Query
{
    public interface IQueryTranslator<TResult>
        where TResult : IQueryResult
    {
        TResult Translate(Expression expression);
    }
}
