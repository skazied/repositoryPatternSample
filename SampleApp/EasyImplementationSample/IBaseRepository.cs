using EasyRepository;
using SampleApp.Entities;

namespace SampleApp.ComplexImplementationSample
{
    public interface IBaseRepository<TEntity>: IStandartRepository<TEntity, RepositoryContext> where TEntity : class
    {
    }
}
