using EasyRepository;
using Microsoft.EntityFrameworkCore;
using SampleApp.Entities;

namespace SampleApp.ComplexImplementationSample
{
    public class TodoRepository : StandartRepository<ComplexImplementationTodoEntity, RepositoryContext>, ITodoRepository
    {
        public TodoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public ComplexImplementationTodoEntity FindById(int Id)
        {
            return base.Single(x => x.Id == Id);
        }
    }
}
