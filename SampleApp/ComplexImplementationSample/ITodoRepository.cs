using EasyRepository;
using SampleApp.Entities;

namespace SampleApp.ComplexImplementationSample
{
    public interface ITodoRepository: IStandartRepository<ComplexImplementationTodoEntity>
    {
        ComplexImplementationTodoEntity FindById(int Id);
    }
}
