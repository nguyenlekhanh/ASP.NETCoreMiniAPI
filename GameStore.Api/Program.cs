using GameStore.Api.Data;
using GameStore.Api.Endpoints;
using GameStore.Api.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddScoped<IGamesRepository, InMemGamesRepository>();
builder.Services.AddSingleton<IGamesRepository, InMemGamesRepository>();

var connString = builder.Configuration.GetConnectionString("GameStoreContext");
builder.Services.AddSqlServer<GameStoreContext>(connString);

var app = builder.Build();

app.Services.InitializeDb();

app.MapGamesEndpoints();

app.Run();
