using DemoTwo.DTOs;

namespace DemoTwo.Handlers;
class CustomerValidationHandler : PaymentHandler
{
    public override async Task<PaymentResponse> HandleAsync(PaymentRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.CustomerId))
        {
            return new PaymentResponse(false, "Invalid customer ID");
        }
        return await base.HandleAsync(request);
    }
}