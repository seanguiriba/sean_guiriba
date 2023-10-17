using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace internship_exercise_1.Pages
{
    public class MalaysiaModel : PageModel
    {
        public void OnGet()
        {
            ViewData["v1"] = "ito ang mga tourist spot sa MALAY woah";
            ViewData["v2"] = "ito ang mga tourist spot sa MALAY wow nice";
            ViewData["v3"] = "ito ang mga tourist spot sa MALAY lupit";
            ViewData["v4"] = "ito ang mga tourist spot sa MALAY panis";
            ViewData["v5"] = "ito ang mga tourist spot sa MALAY oyyy";
        }
    }
}
