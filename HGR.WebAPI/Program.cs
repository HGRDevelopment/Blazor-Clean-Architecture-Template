using Autofac.Extensions.DependencyInjection;
using Autofac;
using HGR.Application;
using HGR.Application.Abstractions;
using HGR.Infrastructure;
using HGR.Infrastructure.Repositories;
using HGR.WebAPI;
using HGR.WebAPI.Modules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiServices();
builder.Services.AddInfrastructureLayerDependencies(builder.Configuration);
builder.Host
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>((container) =>
    {
        container.RegisterModule(new ApplicationModule());
    });
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
