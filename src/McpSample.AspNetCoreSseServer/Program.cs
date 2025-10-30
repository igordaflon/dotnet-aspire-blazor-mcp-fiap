using McpSample.AspNetCoreSseServer.Tools;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddProblemDetails();

builder.Services
    .AddMcpServer()
    .WithHttpTransport()
    .WithTools<ClimaTool>();

var app = builder.Build();

app.MapDefaultEndpoints();
app.UseHttpsRedirection();

app.MapGet("/", () => $"MCP Server OK - {DateTime.Now}");
app.MapMcp();

app.Run();
