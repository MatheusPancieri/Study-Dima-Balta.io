using Dima.Api.Common.Api;
using Dima.Api.Endpoints.Categories;
using Dima.Api.Endpoints.Transactions;
using Dima.Core.Models;

namespace Dima.Api.Endpoints;

public static class Endpoint
{
    public static void MapEndpoints(this WebApplication app)
    {
        var endpoints = app.MapGroup("");
        endpoints.MapGroup("v1/categories")
            .WithTags("Categories")
            //.RequireAuthorization()
            .MapEndpoint<CreateCategoryEndpoint>()
            .MapEndpoint<DeleteCategoryEndpoint>()
            .MapEndpoint<GetAllCategoriesEndpoint>()
            .MapEndpoint<GetCategoryByIdEndpoint>()
            .MapEndpoint<UpdateCategoryEndpoint>();
        endpoints.MapGroup("v1/transactions")
            .WithTags("Transactions")
            .MapEndpoint<CreateTransactionsEndpoint>()
            .MapEndpoint<DeleteTransactionsEndpoint>()
            .MapEndpoint<GetTransactionsByIdEndpoint>()
            .MapEndpoint<GetTransactionsByPeriodEndpoint>()
            .MapEndpoint<UpdateTransactionsEndpoint>();
        
    }
    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app)
        where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }
}