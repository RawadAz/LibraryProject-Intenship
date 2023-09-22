using Library.Configurations;
using Library.Configurations.CacheService;
using Library.Configurations.JwtUtils;
using Library.Data;
using Library.UnitsOfWork.BookUoW;
using Library.UnitsOfWork.BranchUoW;
using Library.UnitsOfWork.ClientUoW;
using Library.UnitsOfWork.DashboardUoW;
using Library.UnitsOfWork.EmployeeUoW;
using Library.UnitsOfWork.EventUoW;
using Library.UnitsOfWork.ReservationUoW;
using Library.UnitsOfWork.TransactionsUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using WatchDog;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped(_ =>new LibraryDBConnection(
    ConnectionString: builder.Configuration.GetConnectionString(name: "connection_string")));

// configure strongly typed settings object
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("JwtSettings"));

// configure DI for application services
builder.Services.AddScoped<IJwtUtils, JwtUtils>();

builder.Services.AddScoped<IClientUnitOfWork, ClientUnitOfWork>();

builder.Services.AddScoped<IBookUnitOfWork, BookUnitOfWork>();

builder.Services.AddScoped<IBranchUnitOfWork, BranchUnitOfWork>();

builder.Services.AddScoped<IEmployeeUnitOfWork, EmployeeUnitOfWork>();

builder.Services.AddScoped<IEventUnitOfWork, EventUnitOfWork>();

builder.Services.AddScoped<IReservationUnitOfWork, ReservationUnitOfWork>();

builder.Services.AddScoped<ITransactionsUnitOfWork, TransactionsUnitOfWork>();

builder.Services.AddScoped<IDashboardUnitOfWork, DashboardUnitOfWork>();

//Change invalid model response
builder.Services.Configure<ApiBehaviorOptions>(options =>
    options.InvalidModelStateResponseFactory = (context => 
    new BadRequestObjectResult("An error occurred, please check the info you entered")));

//Add watchDog service
builder.Services.AddWatchDogServices(Options => {
    Options.IsAutoClear = true;
    Options.ClearTimeSchedule = WatchDog.src.Enums.WatchDogAutoClearScheduleEnum.Weekly;
});
//adding in-memory cache service
builder.Services.AddScoped<ICacheService, CacheService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateActor = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["JwtSettings:Secret"]))
    };
});

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

// Injecting Golable Exception Handler
app.addGlobalErrorHandling();

// injecting watchdog
app.UseWatchDogExceptionLogger();

app.UseWatchDog(options =>
{
    options.WatchPageUsername = "admin";
    options.WatchPagePassword = "admin";
});

app.Run();