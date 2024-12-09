var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    Console.WriteLine("UseHsts will be called");
    app.UseHsts();
}
Console.WriteLine($"Environment is {app.Environment.EnvironmentName}, {app.Environment.WebRootPath}");
app.UseHttpsRedirection();
app.UseDefaultFiles();
//comment the line 13 and uncomment line 14 to make it work 
app.MapStaticAssets();
//app.UseStaticFiles(); 
app.MapGet("/text", () => "Hello World!");

app.Run();
