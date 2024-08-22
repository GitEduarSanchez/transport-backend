using Poliedro.Billing.Api;
using Poliedro.Billing.Application;
using Poliedro.Billing.Infraestructure.External.Plemsi;
using Poliedro.Billing.Infraestructure.External.TNS;
using Poliedro.Billing.Infraestructure.Persistence.Mysql;
using WorkerServiceBilling;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddWebApi()
    .AddApplication()
    .AddExternalPlemsi(builder.Configuration)
    .AddExternalTns(builder.Configuration)
    .AddPersistence(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddRouting(routing => routing.LowercaseUrls = true);
builder.Services.AddHostedService<Worker>();
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.MapControllers();
app.Run();


