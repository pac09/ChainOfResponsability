using DemoThree.DTOs;

namespace DemoThree.Handlers;

class BalanceValidationHandler : PaymentHandler
{
    public override async Task<PaymentResponse> HandleAsync(PaymentRequest request)
    {
        if (request.Amount > 1000)
        {
            return new PaymentResponse(false, "Insufficient balance");
        }
        return await base.HandleAsync(request);
    }
}