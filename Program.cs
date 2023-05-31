var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

if (!app.Environment.IsDevelopment())
{
	app.UseHttpsRedirection();
}
