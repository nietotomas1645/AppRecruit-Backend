using BackendApi.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// 2: coneccion con la base de datos sql

const string CONNECTIONNAME = "JobDB";

var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


// 3. Add contexto
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));


//5. Cors Configuration

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
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
// 6. Tell app to use CORS

app.UseCors("CorsPolicy");


app.Run();
