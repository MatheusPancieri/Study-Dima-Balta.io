namespace Dima.Core.Requests.Transactions;

public class GetTransactionsByIdRequest : BaseRequest
{
    public long Id { get; set; }
}