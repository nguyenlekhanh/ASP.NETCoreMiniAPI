using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRepositories(builder.Configuration);
// builder.Services.AddScoped<IGamesRepository, InMemGamesRepository>();
//builder.Services.AddScoped<IGamesRepository, EntityFrameworkGamesRepository>();


var app = builder.Build();

app.Services.InitializeDb();

app.MapGamesEndpoints();

app.Run();
