using System.ComponentModel.DataAnnotations;
using Dima.Core.Enums;

namespace Dima.Core.Requests.Transactions;

public class UpdateTransactionsRequest : BaseRequest
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Titulo Inválido")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Tipo Inválido")]
    public ETransactionType Type { get; set; }
    [Required(ErrorMessage = "Valor Inválido")]
    public decimal Amount { get; set; }
    [Required(ErrorMessage = "Categoria Inválido")]
    public long CategoryId { get; set; }
    [Required(ErrorMessage = "Titulo Inválido")]
    public DateTime PaidOrReceivedAt { get; set; }
}