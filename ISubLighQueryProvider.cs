using SubLight.Query;
using System.Linq.Expressions;

namespace SubLight
{
    public interface ISubLighQueryProvider
        : IQueryProvider
    {
        
        TResult Translate<TResult>(Expression expression, IQueryTranslator<TResult> translator)
            where TResult: IQueryResult;
    }
}
