var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from DevOps CI/CD Pipeline!");

app.Run();