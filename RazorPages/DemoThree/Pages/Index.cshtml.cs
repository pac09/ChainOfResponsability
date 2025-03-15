using DemoThree.DTOs;
using DemoThree.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoThree.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public PaymentRequest Payment { get; set; } = new PaymentRequest("", 0);
    public string Message { get; private set; } = "";


    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public async Task<IActionResult> OnPostAsync()
    {
        var handler = new AmountValidationHandler();
        handler.SetNext(new CustomerValidationHandler())
               .SetNext(new BalanceValidationHandler());

        var result = await handler.HandleAsync(Payment);
        Message = result.Message;

        return Page();
    }
}
