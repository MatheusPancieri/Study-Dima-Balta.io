namespace Dima.Core.Requests.Transactions;

public class GetTransactionsByPeriodRequest : PageRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}