using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PercentageCalculatorApp.Pages
{
    public class PercentageModel : PageModel
    {
        [BindProperty]
        public double Subject1 { get; set; }

        [BindProperty]
        public double Subject2 { get; set; }

        [BindProperty]
        public double Subject3 { get; set; }

        [BindProperty]
        public double Subject4 { get; set; }

        [BindProperty]
        public double Subject5 { get; set; }

        public double? Percentage { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // Calculate Percentage based on the marks
            double totalMarks = Subject1 + Subject2 + Subject3 + Subject4 + Subject5;
            Percentage = totalMarks / 5; // Assuming equal weightage for all subjects
        }
    }
}