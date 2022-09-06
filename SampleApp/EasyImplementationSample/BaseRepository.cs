using EasyRepository;
using Microsoft.EntityFrameworkCore;
using SampleApp.Entities;

namespace SampleApp.ComplexImplementationSample
{
    public class BaseRepository<TEntity> : StandartRepository<TEntity>, IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
