namespace EIT.GraphQL.Test02;

using HotChocolate.AzureFunctions;

using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

public class GraphQLFunction
{
	private readonly IGraphQLRequestExecutor _executor;

	public GraphQLFunction(IGraphQLRequestExecutor executor)
	{
		this._executor = executor;
	}

	[Function("GraphQLHttpFunction")]
	public Task<HttpResponseData> Run(
		[HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql/{**slug}")] HttpRequestData request)
	{
		return this._executor.ExecuteAsync(request);
	}
}