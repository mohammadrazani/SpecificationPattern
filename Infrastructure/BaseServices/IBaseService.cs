using Domain.Entities.Base;
using Domain.Interfaces;

namespace Infrastructure.BaseServices
{
    public interface IBaseService<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
    }
}
