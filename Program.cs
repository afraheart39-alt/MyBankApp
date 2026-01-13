var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// This tells the app to respond with "Hello from Render!" 
// for any request it receives.
app.MapGet("/", () => "Hello from Render!");

app.Run();