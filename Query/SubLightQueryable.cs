using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SubLight.Query
{
    public class SubLightQueryable<TEntity>
        : IQueryable<TEntity>
    {
        public Expression Expression { get; }
        public ISubLighQueryProvider Provider { get; }

        public SubLightQueryable(ISubLighQueryProvider provider)
            : this(provider, Expression.Constant(typeof(TEntity)))
        {
        }

        public SubLightQueryable(ISubLighQueryProvider provider, Expression expression)
        {
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));
            Expression = expression ?? throw new ArgumentNullException(nameof(expression));
        }

        public Type ElementType => typeof(TEntity);
        
        public IEnumerator<TEntity> GetEnumerator() => Provider.Execute<IEnumerable<TEntity>>(Expression).GetEnumerator();

        IQueryProvider IQueryable.Provider => Provider;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
