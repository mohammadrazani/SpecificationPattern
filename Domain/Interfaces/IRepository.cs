using Domain.Entities.Base;
using Domain.Specifications.Base;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAll(ISpecification<TEntity> specification);

        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
