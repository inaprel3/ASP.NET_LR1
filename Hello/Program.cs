



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Company company = new();
company.Name = "Hello";
Random random = new Random();
int randomInRange = random.Next(101);
app.MapGet("/", () => company.Name+ "\n"+ randomInRange.ToString());
app.Run();
