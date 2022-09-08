using Microsoft.EntityFrameworkCore;
using SampleApp.Entities;

namespace SampleApp
{
    public class RepositoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseInMemoryDatabase("sampleDb");
        }

        public virtual DbSet<ComplexImplementationTodoEntity> ComplexImplementationTodoEntities { get; set; }
        public virtual DbSet<EasyImplementationTodoEntity> EasyImplementationTodoEntities { get; set; }
        public virtual DbSet<Easy2ImplementationTodoEntity> Easy2ImplementationTodoEntities { get; set; }

    }
}
