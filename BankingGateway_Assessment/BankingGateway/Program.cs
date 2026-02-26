using BankingGateway.Helper;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseSerilog((context, services, config) =>
{
    config
        .Enrich.FromLogContext()
        .Enrich.WithMachineName()
        .WriteTo.Seq("https://localhost:5341")
        .WriteTo.File("logs/log.txt")
        .Destructure.ByTransforming<string>(s => SensitiveDataMasker.Mask(s));
});

builder.Services.AddControllers();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
app.UseExceptionHandler();
