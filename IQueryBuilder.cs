using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SubLight
{
    public interface IQueryBuilder
    {
        IQueryBuilder Where<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : class;
        IQueryBuilder Select<TEntity, TResult>(Expression<Func<TEntity, TResult>> selector)
            where TEntity : class;
        // ... other query composition methods

        // Provider-specific translation
        string Translate(IQueryTranslator translator);
    }
}
