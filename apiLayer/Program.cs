using dataLayer;
using Microsoft.EntityFrameworkCore;
using serviceLayer.Categories;
using serviceLayer.Products;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IConfiguration conf = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddCommandLine(args)
    .AddEnvironmentVariables()
    .Build();

String sconf = conf.GetConnectionString("Mycon");
builder.Services.AddDbContext<ProductContext>(opt => opt.UseSqlServer(sconf));
builder.Services.AddTransient(typeof(ICategorie), typeof(categorieService));
builder.Services.AddTransient(typeof(IProduct), typeof(productService));

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
