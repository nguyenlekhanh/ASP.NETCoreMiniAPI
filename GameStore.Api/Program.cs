using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRepositories(builder.Configuration);
// builder.Services.AddScoped<IGamesRepository, InMemGamesRepository>();
//builder.Services.AddScoped<IGamesRepository, EntityFrameworkGamesRepository>();


var app = builder.Build();

await app.Services.InitializeDbAsync();

app.MapGamesEndpoints();

app.Run();
