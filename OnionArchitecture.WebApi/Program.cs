using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Application.Services;
using OnionArchitecture.Domain.Repositories.CompanyRepositories;
using OnionArchitecture.Domain.Repositories.OrderRepositories;
using OnionArchitecture.Domain.Repositories.ProductRepositories;
using OnionArchitecture.Domain.UnitOfWork;
using OnionArchitecture.Persistance.Context;
using OnionArchitecture.Persistance.Repositories.CompanyRepositories;
using OnionArchitecture.Persistance.Repositories.OrderRepositories;
using OnionArchitecture.Persistance.Repositories.ProductRepositories;
using OnionArchitecture.Persistance.Services;
using OnionArchitecture.Persistance.UnitOfWork;
using OnionArchitecture.Presentatiton;

var builder = WebApplication.CreateBuilder(args);

#region DbContext
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer
        (builder.Configuration.GetConnectionString("SqlServer")));
#endregion

#region Dependency Injection
builder.Services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
builder.Services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
builder.Services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
builder.Services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion

builder.Services.AddMediatR(typeof(OnionArchitecture.Application.AssemblyReference).Assembly);

builder.Services.AddControllers()
    .AddApplicationPart(typeof(AssemblyReference).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
