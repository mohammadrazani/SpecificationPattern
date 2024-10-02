using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApiServices(builder.Configuration);

var app = builder.Build();

app.ConfigureApiApplication();

app.Run();
