using GraphQLDemo.API.Schema.Mutations;
using GraphQLDemo.API.Schema.Queries;
using GraphQLDemo.API.Schema.Subscriptions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();
    //.AddSubscriptionType<Subscription>();

IServiceCollection services = new ServiceCollection();
//services.AddInMemorySubscriptions();

var app = builder.Build();

app.UseRouting();

//app.UseWebSockets();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();
