using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CurrencyModel : PageModel
{
    [BindProperty]
    public decimal? AmountInInr { get; set; }
    public decimal? AmountInUsd { get; set; }

    public void OnPost()
    {
        if (AmountInInr.HasValue)
        {
            // Assuming a conversion rate of 1 INR = 0.013 USD
            decimal conversionRate = 0.013m;
            AmountInUsd = AmountInInr.Value * conversionRate;
        }
    }
}