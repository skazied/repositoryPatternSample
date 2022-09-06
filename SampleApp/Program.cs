using Microsoft.EntityFrameworkCore;
using SampleApp.ComplexImplementationSample;
using SampleApp.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContext>(options => options.UseInMemoryDatabase("sampleDb"));

//****************************
//IMPLEMENTATIONS RIGHT HERE
//****************************

builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<IBaseRepository<EasyImplementationTodoEntity>, BaseRepository<EasyImplementationTodoEntity>>();
builder.Services.AddScoped<IBaseRepository<Easy2ImplementationTodoEntity>, BaseRepository<Easy2ImplementationTodoEntity>>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
