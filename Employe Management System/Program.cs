using Ems.data;
using Ems.Services;
using Microsoft.EntityFrameworkCore;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<EmployeeServices>();
builder.Services.AddScoped<LoginServices>();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<DbContextDemo>(options =>
{
    options.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=1756;Database=RaviKiran;Pooling=true;");
});

var app = builder.Build();

app.UseCors(options => options
.AllowAnyOrigin()
  .AllowAnyMethod()
.AllowAnyHeader());
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
