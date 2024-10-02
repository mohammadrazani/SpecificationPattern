using Domain.Entities.Base;
using Domain.Interfaces;
using Domain.Specifications.Base;
using Infrastructure.Data;
using Infrastructure.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class Repository<TEntity>(AppDbContext context) : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbSet<TEntity> _dbSet = context.Set<TEntity>();

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<TEntity> GetAll(ISpecification<TEntity> specification)
        {
            return SpecificationEvaluator<TEntity>.GetQuery(_dbSet.AsQueryable(), specification);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
    }
}
