
using ASPNET.Core_API_Minimal;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ServicesRegistration();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapEndpoints(); //Map Modules EndPoints

app.Run();