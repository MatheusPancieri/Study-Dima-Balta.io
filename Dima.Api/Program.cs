using Dima.Api.Common.Api;
using Dima.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.AddConfiguration();
builder.AddSecurity();
builder.AddDataContexts();
builder.AddCrossOrigin();
builder.AddDocumentation();
builder.AddServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.ConfigureDevEnvironment();

// Adiciona o roteamento antes de configurar os endpoints
app.UseRouting();

app.UseSecurity();

// Mapeia os endpoints
app.MapEndpoints();

// Configura os endpoints e registra no console
app.UseEndpoints(endpoints =>
{
    foreach (var endpoint in endpoints.DataSources.SelectMany(ds => ds.Endpoints))
    {
        Console.WriteLine($"Endpoint registered: {endpoint.DisplayName}");
    }
});

app.Run();
