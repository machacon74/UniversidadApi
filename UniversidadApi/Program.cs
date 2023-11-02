using Microsoft.Extensions.Configuration;
using UniversidadApi.Repositories.GeneroRepository;
using UniversidadApi.Services.GeneroService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer("workstation id=UNIVERSIDAD.mssql.somee.com;packet size=4096;user id=JESUS_MACHACON;pwd=jesusmachacon_SQLLogin_1\t;data source=UNIVERSIDAD.mssql.somee.com;persist security info=False;initial catalog=UNIVERSIDAD");
});
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IGeneroService, GeneroService>();

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
