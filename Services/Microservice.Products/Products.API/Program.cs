using Mapster;
using MassTransit;
using MassTransit.Contract.Configuration;
using Products.Application;
using Products.Application.Abstractions;
using Products.Domain.Abstractions;
using Products.Infrastructure;
using Products.Infrastructure.MassTransit;
using Products.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDbContext>();
builder.Services.AddMapster();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
builder.Services.ConfigureServices(builder.Configuration, new MassTransitConfiguration
{
    Configuration = bus =>
    {
        bus.AddConsumer<GetProductByIdConsumer>();
        bus.AddConsumer<CreateProductConsumer>();
    },

});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
