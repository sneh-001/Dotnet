using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages
{
    public class CalculatorModel : PageModel
    {
        private readonly ILogger<CalculatorModel> _logger;

        public CalculatorModel(ILogger<CalculatorModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public double Number1 { get; set; }

        [BindProperty]
        public double Number2 { get; set; }

        [BindProperty]
        public string Operation { get; set; }

        public double? Result { get; set; }

        public void OnPost()
        {
            switch (Operation)
            {
                case "add":
                    Result = Number1 + Number2;
                    break;
                case "subtract":
                    Result = Number1 - Number2;
                    break;
                case "multiply":
                    Result = Number1 * Number2;
                    break;
                case "divide":
                    if (Number2 != 0)
                    {
                        Result = Number1 / Number2;
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Cannot divide by zero.");
                    }
                    break;
            }
        }
    }
}