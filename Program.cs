var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Define a single endpoint at the root URL
app.MapGet("/", () => "Hello World");

app.Run();
