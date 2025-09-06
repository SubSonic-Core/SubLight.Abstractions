using System.Collections;
using System.Linq.Expressions;

namespace SubLight.Query
{
    public class SubLightQueryable<TEntity>
        : IQueryable<TEntity> where TEntity : class
    {
        public Expression Expression { get; }
        public ISubLightQueryProvider Provider { get; }

        public SubLightQueryable(ISubLightQueryProvider provider)
            : this(provider, Expression.Constant(typeof(TEntity)))
        {
        }

        public SubLightQueryable(ISubLightQueryProvider provider, Expression expression)
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
