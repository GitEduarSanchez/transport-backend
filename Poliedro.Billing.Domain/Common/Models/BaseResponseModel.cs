namespace Poliedro.Billing.Domain.Common.Models;

public class BaseResponseModel
{
    public int StatusCode { get; set; }
    public bool Success { get; set; } = false;
    public string? Message { get; set; } = null;
    public dynamic? Data { get; set; } = null;
}
