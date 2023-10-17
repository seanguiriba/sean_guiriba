using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace internship_exercise_1.Pages
{
    public class ThailandModel : PageModel
    {
        public void OnGet()
        {
            ViewData["v1"] = "ito ang mga tourist spot sa THAI woah";
            ViewData["v2"] = "ito ang mga tourist spot sa THAI wow nice";
            ViewData["v3"] = "ito ang mga tourist spot sa THAI lupit";
            ViewData["v4"] = "ito ang mga tourist spot sa THAI panis";
            ViewData["v5"] = "ito ang mga tourist spot sa THAI oyyy";
        }
    }
}
