using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace internship_exercise_1.Pages
{
    public class IndiaModel : PageModel
    {
        public void OnGet()
        {
            ViewData["v1"] = "ito ang mga tourist spot sa INDIA woah";
            ViewData["v2"] = "ito ang mga tourist spot sa INDIA wow nice";
            ViewData["v3"] = "ito ang mga tourist spot sa INDIA lupit";
            ViewData["v4"] = "ito ang mga tourist spot sa INDIA panis";
            ViewData["v5"] = "ito ang mga tourist spot sa INDIA oyyy";
        }
    }
}
