using Domain.Entities.Base;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.BaseServices
{
    public class BaseService<TEntity> : Repository<TEntity>, IBaseService<TEntity> where TEntity : BaseEntity
    {
        public BaseService(AppDbContext context) : base(context)
        {
        }
    }
}
