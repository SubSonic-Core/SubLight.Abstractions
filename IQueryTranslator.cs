using System.Linq.Expressions;

namespace SubLight
{
    public interface IQueryTranslator
    {
        string Translate(Expression expression);
    }
}
