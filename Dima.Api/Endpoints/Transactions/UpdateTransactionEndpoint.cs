
using Dima.Api.Common.Api;
using Dima.Core.Models;
using Dima.Core.Requests.Transactions;
using Dima.Core.Responses;
using Dima.Core.Handlers;


namespace Dima.Api.Endpoints.Transactions;

public class UpdateTransactionsEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
        => app.MapPut("/{id}", HandleAsync)
            .WithName("Categories: Update")
            .WithSummary("Atualiza uma categoria")
            .WithDescription("Atualiza uma categoria")
            .WithOrder(2)
            .Produces<Response<Transaction?>>();

    private static async Task<IResult> HandleAsync(
        ITransactionHandler handler,
        UpdateTransactionsRequest request,
        long id)
    {
        request.UserId = "teste@balta.io";
        request.Id = id;
        var result = await handler.UpdateAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
}