using EasyRepository;
using SampleApp.Entities;

namespace SampleApp.ComplexImplementationSample
{
    public interface ITodoRepository: IStandartRepository<ComplexImplementationTodoEntity, RepositoryContext>
    {
        ComplexImplementationTodoEntity FindById(int Id);
    }
}
