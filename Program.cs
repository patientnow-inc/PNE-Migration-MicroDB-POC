using Microsoft.EntityFrameworkCore;
using PNE_Microservice_POC.Controllers;
using PNE_Microservice_POC.Data;
using PNE_Microservice_POC.Repositories;
using PNE_Microservice_POC.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure PostgreSQL Database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Repositories and Services
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

// Register Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

// Register API Routes
app.RegisterCustomerEndpoints();

app.Run();