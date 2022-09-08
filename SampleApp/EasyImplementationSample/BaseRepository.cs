using EasyRepository;
using Microsoft.EntityFrameworkCore;
using SampleApp.Entities;

namespace SampleApp.ComplexImplementationSample
{
    public class BaseRepository<TEntity> : StandartRepository<TEntity, RepositoryContext>, IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
