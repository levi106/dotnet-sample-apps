using BackendService6;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpLogging();
app.MapApiRoutes();

app.Run();

public partial class Program
{ }