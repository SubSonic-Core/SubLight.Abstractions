#region Copyright (c) 2025
// RM / Hybrid ORM: Resource Manager / Hybrid ORM
//
// License: Dual-license
//  - Free for educational, research, personal, or nonprofit projects that are not directly or indirectly used to generate revenue
//  - Commercial use requires a per-service paid license
//
// Disclaimer: Provided "as-is"; no warranty; author not liable for any damages, data loss, or business interruptions.
// Production use must be fully tested and validated within the enterprise environment.
//
// Contributions: All contributions are voluntary and licensed under this project’s dual-license; may be included in commercial releases.
// See CLA.md for Contributor License Agreement.
//
// For commercial licensing or paid support inquiries: Kenneth Carter
#endregion
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
