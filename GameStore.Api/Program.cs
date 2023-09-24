using GameStore.Api.Endpoints;
using GameStore.Api.Repositories;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddScoped<IGamesRepository, InMemGamesRepository>();
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();

var connString = builder.Configuration.GetConnectionString("GameStoreContext");

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
