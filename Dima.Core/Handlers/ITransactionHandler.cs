using Dima.Core.Models;
using Dima.Core.Requests.Transactions;
using Dima.Core.Responses;

namespace Dima.Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateTransactionsRequest request);
    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionsRequest request);
    Task<Response<Transaction?>> DeleteAsync(DeleteTransactionsRequest request);
    Task<Response<Transaction?>> GetByIdAsync(GetTransactionsByIdRequest request);
    Task<PageResponse<List<Transaction?>>> GetByPeriodAsync(GetTransactionsByPeriodRequest request);
}