using System.Text.Json.Serialization;

namespace Dima.Core.Responses;

public class Response<TData>
{
    private const int DefaultStatusCode = 200;

    private readonly int _code;

    [JsonConstructor]
    public Response(Task<Models.Transaction?> transaction) => _code = DefaultStatusCode;

    public Response(
        TData? data,
        int code = Configuration.DefaultStatusCode,
        string? message = null)
    {
        Data = data;
        _code = code;
        Message = message;
    }
    public TData? Data { get; set; }

    public string Message { get; set; } = string.Empty;

    [JsonIgnore]
    public bool IsSuccess => _code is >= 200 and <= 299;
}