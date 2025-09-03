using System.Linq.Expressions;

namespace SubLight.Query
{
    public interface IQueryTranslator<TResult>
        where TResult : class
    {
        TResult Translate(Expression expression);
    }
}
