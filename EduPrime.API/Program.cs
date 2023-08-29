using EduPrime.Infrastructure.Data;
using EduPrime.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Infrastructure.Filters;
using EduPrime.Infrastructure.Services;
using EduPrime.Infrastructure.AzureServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.CacheProfiles.Add("OneMinuteCache", new CacheProfile
    {
        Duration = 60
    });
    options.Filters.Add<GlobalExceptionFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddResponseCaching();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IEmployeeRepositoryService, EmployeeRepositoryService>();
builder.Services.Configure<AzureSettings>(builder.Configuration.GetSection("azureSettings"));
builder.Services.AddSingleton<IBlobStorageService, BlobStorageService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(options => options.AddPolicy("AppCorsPolicy", build =>
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AppCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
