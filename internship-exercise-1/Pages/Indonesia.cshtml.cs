using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace internship_exercise_1.Pages
{
    public class IndonesiaModel : PageModel
    {
        public void OnGet()
        {
            ViewData["v1"] = "ito ang mga tourist spot sa INDO woah";
            ViewData["v2"] = "ito ang mga tourist spot sa INDO wow nice";
            ViewData["v3"] = "ito ang mga tourist spot sa INDO lupit";
            ViewData["v4"] = "ito ang mga tourist spot sa INDO panis";
            ViewData["v5"] = "ito ang mga tourist spot sa INDO oyyy";
        }
    }
}
