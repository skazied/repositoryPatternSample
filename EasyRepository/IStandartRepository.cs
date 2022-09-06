using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace EasyRepository
{
    public interface IStandartRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> FindAll();
        ValueTask<EntityEntry<TEntity>> CreateAsync(TEntity entity);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        Task CreateRangeAsync(IEnumerable<TEntity> entity);
        void UpdateRange(IEnumerable<TEntity> entity);
        public Task<int> SaveChangesAsync();
        TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> expression);
        TEntity? SingleOrDefault(Expression<Func<TEntity, bool>> expression);
        Task FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
        Task SingleOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
        public TEntity First(Expression<Func<TEntity, bool>> expression);
        TEntity Single(Expression<Func<TEntity, bool>> expression);
        Task FirstAsync(Expression<Func<TEntity, bool>> expression);
        Task SingleAsync(Expression<Func<TEntity, bool>> expression);
    }
}
