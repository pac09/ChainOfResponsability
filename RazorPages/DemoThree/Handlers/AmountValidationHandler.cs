using DemoThree.DTOs;

namespace DemoThree.Handlers;

class AmountValidationHandler : PaymentHandler
{
    public override async Task<PaymentResponse> HandleAsync(PaymentRequest request)
    {
        if (request.Amount <= 0)
        {
            return new PaymentResponse(false, "Invalid payment amount");
        }
        return await base.HandleAsync(request);
    }
}