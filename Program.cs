using EIT.GraphQL.Test02;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
	.ConfigureFunctionsWorkerDefaults()
	.AddGraphQLFunction(b => b.AddQueryType<Query>().AddMutationType<Mutation>())//GraphQL server and Azure Functions integration set up
	.ConfigureServices(s => s.AddSingleton<PersonRepository>())
	.Build();

host.Run();
