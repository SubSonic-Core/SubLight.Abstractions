using SubLight.Query;
using System.Linq.Expressions;

namespace SubLight
{
    public interface ISubLightQueryProvider
        : IQueryProvider
    {
        TResult Translate<TResult>(Expression expression, IQueryTranslator<TResult> translator)
            where TResult: IQueryResult;
    }
}
