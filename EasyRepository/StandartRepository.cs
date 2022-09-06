using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace EasyRepository
{
    public abstract class StandartRepository<TEntity> : IStandartRepository<TEntity> where TEntity : class
    {
        protected DbContext _context { get; set; }

        public StandartRepository(DbContext repositoryContext)
        {
            _context = repositoryContext;
        }

        public TEntity Create(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity).Entity;
        }

        public TEntity Update(TEntity entity)
        {
            return _context.Set<TEntity>().Update(entity).Entity;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> FindAll()
        {
            return _context.Set<TEntity>();
        }

        public ValueTask<EntityEntry<TEntity>> CreateAsync(TEntity entity)
        {
            return _context.Set<TEntity>().AddAsync(entity);
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task CreateRangeAsync(IEnumerable<TEntity> entity)
        {
            return _context.Set<TEntity>().AddRangeAsync(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entity)
        {
            _context.Set<TEntity>().UpdateRange(entity);
        }

        public TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().FirstOrDefault(expression);
        }

        public TEntity? SingleOrDefault(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().SingleOrDefault(expression);
        }

        public Task FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        }
        public Task SingleOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().SingleOrDefaultAsync(expression);
        }

        public TEntity First(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().First(expression);
        }

        public TEntity Single(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Single(expression);
        }

        public Task FirstAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().FirstAsync(expression);
        }
        public Task SingleAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().SingleAsync(expression);
        }
    }
}