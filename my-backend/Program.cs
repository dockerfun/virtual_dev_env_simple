using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using MyBackend.DAL;
using System.Configuration;
using my_backend.Data.Repository;

var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UserContext>(options =>
{
     var connetionString = builder.Configuration.GetConnectionString("DefaultConnection");
     options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));
});

//builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(MyAllowSpecificOrigins);
}
else
{
    app.UseCors(MyAllowSpecificOrigins);  
}

app.UseAuthorization();

app.MapControllers();

app.Run();
