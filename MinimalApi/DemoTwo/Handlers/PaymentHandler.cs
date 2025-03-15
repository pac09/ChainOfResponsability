using DemoTwo.DTOs;

namespace DemoTwo.Handlers;

abstract class PaymentHandler
{
    private PaymentHandler? _nextHandler;

    public PaymentHandler SetNext(PaymentHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    public virtual async Task<PaymentResponse> HandleAsync(PaymentRequest request)
    {
        if (_nextHandler != null)
        {
            return await _nextHandler.HandleAsync(request);
        }
        return new PaymentResponse(true, "Payment processed successfully");
    }
}