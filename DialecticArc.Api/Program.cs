using DialecticArc.Api.Data;
using DialecticArc.Api.Schema;

var builder = WebApplication.CreateBuilder(args);

// Register repositories
builder.Services.AddSingleton<HousingRepository>();

// Register GraphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
