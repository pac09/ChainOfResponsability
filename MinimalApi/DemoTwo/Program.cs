using DemoTwo.DTOs;
using DemoTwo.Handlers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Minimal API Endpoint
app.MapPost("/payments", async (PaymentRequest request) =>
{
    var handler = new AmountValidationHandler();
    handler.SetNext(new CustomerValidationHandler())
           .SetNext(new BalanceValidationHandler());

    var result = await handler.HandleAsync(request);
    return Results.Json(result);
});

app.Run();
