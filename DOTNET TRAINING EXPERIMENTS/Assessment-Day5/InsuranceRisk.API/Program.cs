using InsuranceRisk.Application.Interfaces;
using InsuranceRisk.Application.Services;
using InsuranceRisk.Application.Validators;
using InsuranceRisk.Infrastructure.Implemetation;
using InsuranceRisk.Infrastructure.Logging;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRiskService, RiskService>();
builder.Services.AddScoped<ILoggerService, LoggerService>();
builder.Services.AddScoped<IApplicantValidator, ApplicantValidator>();
builder.Services.AddScoped<IRiskService, RiskService>();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
