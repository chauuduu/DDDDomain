using Application.Service.ClothService;
using Application.Service.TypeClothService;
using Infrastructure.Interface;
using Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

var Services = builder.Services;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

Services.AddTransient<IClothesRepository, ClothesRepository>();
Services.AddTransient<IClothesService,ClothesService>();
Services.AddTransient<ITypeClothesRepository, TypeClothesRepository>();
Services.AddTransient<ITypeClothesService, TypeClothesService>();


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
