using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HotChocolate;
using GraphQL;
using GraphQL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IRepository, Repository>();

// Add GraphQL services
builder.Services.AddGraphQLServer()
        .AddQueryType<Query>()
        //.AddMutationType<Mutation>()
        .AddApolloTracing();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Configure the GraphQL endpoint
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Redirect("/graphql", permanent: false);
        return;
    }
    await next();
});

app.Run();

