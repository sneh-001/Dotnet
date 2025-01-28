using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 
namespace App.Pages
{
    public class MassModel : PageModel
    {
        [BindProperty]
        public double MassInKg { get; set; }
 
        public double MassInLbs { get; set; }
        public double MassInGrams { get; set; }
        public double MassInMg { get; set; }
 
        public void OnPost()
        {
            MassInLbs = MassInKg * 2.20462;
            MassInGrams = MassInKg * 1000;
            MassInMg = MassInKg * 1000000;
        }
    }
}