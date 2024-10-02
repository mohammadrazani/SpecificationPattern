using System.Linq.Expressions;

namespace Domain.Specifications.Base
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> Criteria { get; }

        List<Expression<Func<TEntity, object>>> Includes { get; }

        Expression<Func<TEntity, object>> OrderBy { get; }

        Expression<Func<TEntity, object>> OrderByDescending { get; }
    }
}
